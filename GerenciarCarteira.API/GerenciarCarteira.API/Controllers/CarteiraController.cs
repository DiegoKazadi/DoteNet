using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GerenciarCarteira.API.Data;
using GerenciarCarteira.API.Model;
using GerenciarCarteira.Domain;

namespace PGerenciarCarteira.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarteiraController : ControllerBase
    {
        private DataContext dataContext;

        public CarteiraController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public ActionResult<Response> ObterTodos()
        {
            // select * from carteiras
            Response response = new Response();
            response.Model = dataContext.Carteiras.Include(tabela => tabela.Posts).ToList();

            return response;
        }

        [HttpGet("obterCarteira/{id}")]
        public ActionResult<Response> PesquisarPorId(Guid id)
        {
            Response response = new Response();
            response.Model = dataContext.Carteiras.Include(tabela => tabela.Posts).Where(carteiraTemp => carteiraTemp.Id == id).FirstOrDefault();

            if (response.Model == null)
            {
                response.Model = HttpStatusCode.NotFound;
                response.MessageError = "Carteira não encontrado";
            }

            return response;
        }

        [HttpPost("registro")]
        public ActionResult<Carteira> Cadastrar([FromBody] Carteira carteira)
        {
            carteira.Id = Guid.NewGuid();

            carteira.Posts.ForEach(post => post.Date = DateTime.Now);

            dataContext.Carteiras.Add(carteira);
            dataContext.SaveChanges();

            return carteira;
        }

        [HttpPut()]
        public ActionResult<Guid> Put([FromBody] Carteira carteiraToEdit)
        {
            Carteira carteira = dataContext.Carteiras.Where(carteiraTemp => carteiraTemp.Id == carteiraToEdit.Id).FirstOrDefault();

            if (carteira != null)
            {
                carteira.Name = carteiraToEdit.Name;
                dataContext.Carteiras.Update(carteira);
                dataContext.SaveChanges();
            }

            return carteira.Id;
        }

        [HttpDelete("{id}")] 
        public ActionResult<Guid> Delete(Guid id)
        {
            Carteira carteira = dataContext.Carteiras.Include(tabela => tabela.Posts).Where(carteiraTemp => carteiraTemp.Id == id).FirstOrDefault();

            if(carteira != null)
            {
                dataContext.Carteiras.Remove(carteira);
                dataContext.SaveChanges();
            }

            return id;
        }
    }
}