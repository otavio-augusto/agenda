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
        public void Serializar(List<T> lista, string arquivo)
        {
            lista.AddRange(Deserializar(arquivo));
            Criar(arquivo);
            TextWriter writer = new StreamWriter(arquivo);
            XmlSerializer serializer = new XmlSerializer(lista.GetType());
            serializer.Serialize(writer, lista);
            writer.Close();
        }

        public void Serializar(T objeto, string arquivo)
        {
            List<T> lista = new List<T>();
            lista.Add(objeto);
            Serializar(lista, arquivo);
        }

        public List<T> Deserializar(string arquivo)
        {
            Criar(arquivo);
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

        public void Alterar(string arquivo, XElement oldElemento, XElement newElemento)
        {
            XDocument xDocument = XDocument.Load(arquivo);
            var pesquisa = from x in xDocument.Elements(oldElemento.Name) // Procura um XElement
                           where (x == oldElemento)                         // Com o valor do antigo
                           select x;

            foreach (XElement xElement in pesquisa)                       // Para cada elemento igual
                xElement.ReplaceWith(newElemento);                        // Substitui as entradas

            xDocument.Save(arquivo);                                      // Salva as alterações
        }

        public void Deletar(string arquivo, XElement oldElemento)
        {
            Criar(arquivo);
            XDocument xDocument = XDocument.Load(arquivo);
            var pesquisa = from x in xDocument.Elements(oldElemento.Name) // Procura um XElement
                           where (x == oldElemento)                       // Com o valor do antigo
                           select x;

            foreach (XElement xElement in pesquisa)                       // Para cada elemento igual
                xElement.Remove();                                        // Deleta as entradas

            xDocument.Save(arquivo);                                      // Salva as alterações
        }

        public void Criar(string arquivo)
        {
            if (!File.Exists(arquivo))
                File.Create(arquivo);
        }
    }
}
