using System;
using System.Collections.Generic;
using System.Linq;


namespace CadastrarBolsasDeValores
{
    public class Carteira
                
    {
        public int quantidade { get; private set; }
        public List<Acao> acoes;


        public Carteira(int quantidade)
        {
            this.quantidade = quantidade;
            acoes = new List<Acao>();
        }

        public void adicionarAcoes(Acao acao)
        {
            this.acoes.Add(acao);
        }

        public List<Acao> acoesRegistradas()
        {
            List<Acao> acoesRegistradas = new List<Acao>();

            foreach (var id in acoes)
            {
                Acao acao = BolsasDeValores.acoes.Where(p => p.acao == acao).FirstOrDefault();
                if (acao != null) acoesRegistradas.Add(acao);
            }

            return acoesRegistradas;
        }
                public override string ToString()
        {
            return $"QUANTIDADE: {this.quantidade}, AÇÔES: {this.acoes}";
        }

    }
}
    
