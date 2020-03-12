using System;
using System.Collections.Generic;
using System.Linq;


namespace CadastrarBolsasDeValores
{
    public class Carteira
                
    {
        public int codigo { get; private set; }
        public int contador { get; private set;}
        public List<Acao> acoes;

        public Carteira(int codigo)
        {
            this.codigo = codigo;
            acoes = new List<Acao>();
        }

        public void adicionarAcoes(Acao acao)
        {
            this.acoes.Add(acao);
            this.contador + 1;
        }

        public List<Acao> acoesRegistradas()
        {
            List<Acao> acoesRegistradas = new List<Acao>();

            foreach (var id in acoes)
            {
                Acao acao = BolsasDeValores.acoes.Where(p => p.codigo == codigo).FirstOrDefault();
                if (acao != null) acoesRegistradas.Add(acao);
            }

            return acoesRegistradas;
        }
                public override string ToString()
        {
            return $"CODIGO: {this.codigo}, AÇÔES: {this.acoes}, QUANTIDADE DE AÇÔES: {this.contador} ";
        }

    }
}
    
