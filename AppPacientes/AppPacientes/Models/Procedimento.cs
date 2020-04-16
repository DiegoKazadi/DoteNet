using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPacientes.Models
{
    public class Procedimento
    {

        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "O nome do procedimento é obrigatório", AllowEmptyStrings = false)]
        [Display(Name="Nome")]
       
        public string Nome { get; set; }

        public List<Procedimento> ListaProcedimento()
        {
            return new List<Procedimento>

            {
                new Procedimento{ id = 1, Nome = "Clariamento"}
            };
        }
    }
}
