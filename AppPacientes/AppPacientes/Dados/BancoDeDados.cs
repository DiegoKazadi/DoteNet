using AppPacientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPacientes.Dados
{
    public class BancoDeDados
    {
        private static List<Paciente> pacientes;

        private static BancoDeDados instance;

        public static BancoDeDados Instance()
        {
            if (instance == null)
            {
                pacientes = new List<Paciente>();
                instance = new BancoDeDados();
            }

            return instance;
        }

        public void Add(Paciente paciente)
        {
            pacientes.Add(paciente);
        }

        public void Remover(int id)
        {
            Paciente pacienteParaRemover = pacientes.Where(l => l.Id == id).FirstOrDefault();
            pacientes.Remove(pacienteParaRemover);
        }

        public List<Paciente> GetAll()
        {
            return pacientes;
        }
    }
}
