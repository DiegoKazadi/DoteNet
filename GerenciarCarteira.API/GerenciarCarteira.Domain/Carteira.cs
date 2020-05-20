using System;
using System.Collections.Generic;

namespace GerenciarCarteira.Domain
{
    public class Carteira
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        //OneToMany
        public List<Acao> Acoes { get; set; }
    }
}
