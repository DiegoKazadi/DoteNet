using CadastroPacientesClinicaOdonto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPacientesClinicaOdonto.NovaPasta1
{
    public class BancosDeDados

    {
        private static List<Pacientes> pacientes;

        private static List<Procedimentos> procedimentos;

        private static BancosDeDados instance;

        private static BancosDeDados Instance()
        {
            if (instance == null)
            {
                pacientes = List<Pacientes>();
                instance = new BancosDeDados();
            }
            return instance;
        }

        public void Add(Pacientes paciente)
        {
            pacientes.Add(paciente);
        }

        public void Add(Procedimentos procedimento)
        {
            procedimentos.Add(procedimento);
        }
        public List<Pacientes> GetAll()
        {
            return pacientes;
        }
       }
}
