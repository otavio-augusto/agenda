using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace trabalho_agenda
{
    class EditorXML<T>
    {
        public void serializar(List<T> lista, string arquivo, bool append = true)
        {
            criar(arquivo);
            XmlSerializer serializer = new XmlSerializer(lista.GetType());
            XElement Raiz = XElement.Load(arquivo);
            XElement xElement;
            using (var stream = new MemoryStream())   //Memory Stream usa a memoria ao inves de arquivo.
            {
                serializer.Serialize(stream, lista);  //Salva os dados serializados na memoria.
                stream.Position = 0;
                using (XmlReader reader = XmlReader.Create(stream)) //Cria um leitor de XML
                {
                    xElement = XElement.Load(reader);               //Cria um XElement apartir do "arquivo" na memoria.
                }
            }
            Raiz.Add(xElement.Elements());  //Adiciona o XElement
            Raiz.Save(arquivo);             // Salva
        }

        public List<T> deserializar(string arquivo)
        {
            criar(arquivo);
            List<T> lista = new List<T>();
            FileStream fileStream = new FileStream(arquivo, FileMode.OpenOrCreate);
            XmlSerializer serializer = new XmlSerializer(lista.GetType());
            try
            {
                lista = (List<T>)serializer.Deserialize(fileStream);
            }
            catch (System.InvalidOperationException)// XML Vazio
            {
                lista = new List<T>();
            }
            fileStream.Close();
            return lista;
        }


        public void criar(string arquivo)
        {
            if (!File.Exists(arquivo))
                new XDocument(new XElement("root")).Save(arquivo);
        }
    }
}
