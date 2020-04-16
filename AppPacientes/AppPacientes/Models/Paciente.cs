namespace AppPacientes.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Procedimento procediemento;
    }
}
