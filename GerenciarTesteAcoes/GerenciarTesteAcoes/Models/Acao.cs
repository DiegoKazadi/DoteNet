using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciarTesteAcoes.Models
{
    public class Acao
    {
        public Guid Id { get; set; }
        public string codigoAcao { get; set; }
        public double precoAcao { get; set; }
        public int quantidAcao { get; set; }
        public string data { get; set; }

    }
}
