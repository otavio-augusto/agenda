using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace trabalho_agenda
{
    [Serializable]
    public class Paciente:Pessoa
    {
        [XmlElement("TipoSang")]
        public string TipoSang { get; set; }
    }
}
