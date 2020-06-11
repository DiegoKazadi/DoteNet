using AppAcoes.Data;
using AppAcoes.Models;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;


namespace AppAcoes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcoesControllers : ControllerBase
    {
        private DataContext dataContext;

        public AcoesControllers(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public ActionResult<List<Acoes>> listarAcoes()
        {
            return dataContext.Acoes.ToList();
        }


        [HttpPost("cadastrar")]
        public ActionResult<Acoes> cadastrarAcoes([FromBody] Acoes acao)
        {
            acao.Id = Guid.NewGuid();

            dataContext.Acoes.Add(acao);

            dataContext.SaveChanges();

            return acao;
        }

        [HttpGet("listar/{id}")]
        public ActionResult<Acoes> Listar(Guid id)
        {
            return dataContext.Acoes.Where(acaoTemp => acaoTemp.Id == id).FirstOrDefault();
        }

        [HttpDelete("{id}")]
        public ActionResult<Guid> excluirById(Guid id)
        {
            Acoes acao = dataContext.Acoes.Where(acaoTemp => acaoTemp.Id == id).FirstOrDefault();
            if (acao != null)
            {
                dataContext.Acoes.Remove(acao);
                dataContext.SaveChanges();
            }
            return id;
        }

        [HttpPut("editar")]
        public ActionResult<Guid> atualizarAcoes([FromBody] Acoes acaoEdit)
        {
            Acoes acao = dataContext.Acoes.Where(acaoTemp => acaoTemp.Id == acaoEdit.Id).FirstOrDefault();
            if (acao != null)
            {
                acao.Id = acaoEdit.Id;
                dataContext.Acoes.Update(acao);
                dataContext.SaveChanges();
            }
            return acao.Id;
        }
    }
}
