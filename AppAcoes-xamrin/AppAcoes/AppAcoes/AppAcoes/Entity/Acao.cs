using System;
using System.Collections.Generic;
using System.Text;

namespace AppAcoes.Entity
{
    public class Acao
    {
        public string NomeAcao { get; }
        public string QtdAcao { get; }

        public string codigoAcao { get; }
        public string PrecoAcao { get; }
        public DateTime Data { get; set; }


        public Acao(string nomeAcao, string qtdAcao, string precoAcao, string codigoAcao)
        {
            this.Data = DateTime.Now;
            this.NomeAcao = nomeAcao;
            this.QtdAcao = qtdAcao;
            this.PrecoAcao = precoAcao;
            this.codigoAcao = codigoAcao;


        }
    }

}
