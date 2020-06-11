using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAcoes.Models
{
    public class Acoes
    {

        public Guid Id { get; set; }
        public string codigoAcao { get; set; }
        public int qtdAcao { get; set; }
        public double precoAcao { get; set; }
        public string data { get; set; }
    }
}
