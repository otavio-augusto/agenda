using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_agenda
{
    public class Consulta
    {
        public string CPFPaciente { get; set; }
        public string NomePaciente { get; set; }
        public string CPFMedico { get; set; }
        public string NomeMedico { get; set; }       
        public string Especialidade { get; set; }
        public DateTime Horario { get; set; }
        public string Status { get; set; }

    }
}
