using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace trabalho_agenda
{
    public class root<T>
    {
        [XmlElement("root")]
        public List<T> lista = new List<T>();
    }
}
