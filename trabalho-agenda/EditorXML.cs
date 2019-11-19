﻿using System;
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
        public void Serializar(List<T> lista, string arquivo, bool append = true)
        {
            Criar(arquivo);
            XmlSerializer serializer = new XmlSerializer(lista.GetType());
            XElement Raiz = XElement.Load(arquivo);
            XElement xElement;
            using (var stream = new MemoryStream())   //Memory Stream usa a memoria para salvar.
            {                                         //Using fecha a Stream automaticamente.
                serializer.Serialize(stream, lista);  //Salva os dados serializados na memoria.
                stream.Position = 0;
                using (XmlReader reader = XmlReader.Create(stream))
                {
                    xElement = XElement.Load(reader); //Cria um XElement com os dados na memoria.
                }
            }
            Raiz.Add(xElement.Elements());            //Adiciona o XElement.
            Raiz.Save(arquivo);                       //Salva o arquivo XML.
        }

        public void Serializar(T objeto, string arquivo, bool append = true)
        {
            Criar(arquivo);
            XmlSerializer serializer = new XmlSerializer(objeto.GetType());
            XElement Raiz = XElement.Load(arquivo);
            XElement xElement;
            using (var stream = new MemoryStream())    //Memory Stream usa a memoria para salvar.
            {                                          //Using fecha a Stream automaticamente.
                XmlSerializerNamespaces nameSpace = new XmlSerializerNamespaces();
                nameSpace.Add("", "");                            //Remove notações desnecessarias.
                serializer.Serialize(stream, objeto, nameSpace);  //Salva os dados serializados na memoria.
                stream.Position = 0;
                using (XmlReader reader = XmlReader.Create(stream))
                {
                    xElement = new XElement(objeto.GetType().ToString());   //Adiciona o elemento raiz.
                    xElement.Add(XElement.Load(reader)); //Adiciona os Dados na Memoria ao XElement.
                }
            }
            Raiz.Add(xElement.Elements());            //Adiciona o XElement.
            Raiz.Save(arquivo);                       //Salva o arquivo XML.
        }

        public List<T> Deserializar(string arquivo)
        {
            Criar(arquivo);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream fileStream = new FileStream(arquivo, FileMode.Open))
            {
 
                    return (List<T>)serializer.Deserialize(fileStream);

                
            }
        }

        public void Alterar(string arquivo, XElement oldElemento, XElement newElemento)
        {
            Criar(arquivo);
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
                new XDocument(new XElement("root")).Save(arquivo);
        }
    }
}
