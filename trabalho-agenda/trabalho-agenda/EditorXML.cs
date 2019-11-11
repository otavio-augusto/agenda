using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace trabalho_agenda
{
    class EditorXML<T>
    {
        public void serializar(List<T> lista, string arquivo)
        {
            lista.AddRange(deserializar(arquivo));
            criar(arquivo);
            TextWriter writer = new StreamWriter(arquivo);
            XmlSerializer serializer = new XmlSerializer(lista.GetType());
            serializer.Serialize(writer, lista);
            writer.Close();
        }

        public List<T> deserializar(string arquivo)
        {
            criar(arquivo);
            List<T> lista = new List<T>();
            FileStream fileStream = new FileStream(arquivo, FileMode.Open);
            fileStream.Position = 0;
            XmlSerializer serializer = new XmlSerializer(lista.GetType());
            try
            {
                lista = (List<T>)serializer.Deserialize(fileStream);
            }
            catch (Exception)
            {
                lista = new List<T>();
            }
            fileStream.Close();
            return lista;
        }
        public void criar(string arquivo)
        {
            if (!File.Exists(arquivo))
                File.Create(arquivo);
        }
    }
}
