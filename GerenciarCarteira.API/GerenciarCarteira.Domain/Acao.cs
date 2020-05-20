using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciarCarteira.Domain
{
    public class Acoa
    {
        public int Id { get; set; }
        public int quantidade { get; set; }
        public double precoUnitario { get; set; }
        public DateTime Date { get; set; }

        //ManyToOne
        public Carteira  Carteira { get; set; }
        public virtual Guid CarteiraId { get; set; }
    }
}
