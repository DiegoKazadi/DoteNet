using System;
using System.Collections.Generic;
using System.Linq;
using GerenciarTesteAcoes.Data;
using GerenciarTesteAcoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarTesteAcoes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcaoController : ControllerBase
    {
        private DataContext dataContext;

        public AcaoController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public ActionResult<List<Acao>> ObterTodasAcoes()
        {
            // select * from acoes
            return dataContext.Acao.ToList();
        }

        [HttpPost("cadastrando")]
        public ActionResult<Acao> cadastrarAcoes([FromBody] Acao acao)
        {
            acao.Id = Guid.NewGuid();

            dataContext.Acao.Add(acao);

            dataContext.SaveChanges();

            return acao;
        }

        [HttpDelete("{id}")]
        public ActionResult<Guid> excluirById(Guid id)
        {
            Acao acao = dataContext.Acao.Where(acaoTemp => acaoTemp.Id == id).FirstOrDefault();
            if (acao != null)
            {
                dataContext.Acao.Remove(acao);
                dataContext.SaveChanges();
            }
            return id;
        }

        [HttpGet("Obter/{id}")]
        public ActionResult<Acao> Listar(Guid id)
        {
            return dataContext.Acao.Where(acaoTemp => acaoTemp.Id == id).FirstOrDefault();
        }

        [HttpPut("editar")]
        public ActionResult<Guid> atualizarAcoes([FromBody] Acao acaoEdit)
        {
            Acao acao = dataContext.Acao.Where(acaoTemp => acaoTemp.Id == acaoEdit.Id).FirstOrDefault();
            if (acao != null)
            {
                acao.Id = acaoEdit.Id;
                dataContext.Acao.Update(acao);
                dataContext.SaveChanges();
            }
            return acao.Id;
        }
    }
}
