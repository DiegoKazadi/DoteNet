using AppPacientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AppPacientes.Dados
{
	public class BancoProcedimento
	{
        private static List<Paciente> pacientes;

        private static BancoProcedimento instance;

        public static BancoDeDados Instance()
        {
            if (instance == null)
            {
                pacientes = new List<Procedimento>();
                instance = new BancoProcedimento();
            }

            return instance;

        }
        public void Add(Procediemento procediemento)
        {
            pacientes.Add(procediemento);
        }

        public void Remover(int id)
        {
            Paciente procedimentoParaRemover = pacientes.Where(l => l.Id == id).FirstOrDefault();
            pacientes.Remove(procedimentoParaRemover);
        }

        public List<Procedimento> GetAll()
        {
            return procedimento;
        }

    }
    

}
