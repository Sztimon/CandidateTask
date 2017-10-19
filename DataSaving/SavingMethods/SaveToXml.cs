using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataSaving.Models;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace DataSaving.SavingMethods
{
    public class SaveToXml
    {

        public void Save(List<LogDTO> logDTO)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + "App_Data\\XmlUserData.xml";
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            if (File.Exists(path))
            {
                XDocument xmlDoc = XDocument.Load(path);
                
                int index = xmlDoc.Descendants("Name").Count();
                foreach (var log in logDTO)
                {
                    XElement id = new XElement("Id", index);
                    xmlDoc.Root.Add(id);
                    XElement name = new XElement("Name", log.Name);
                    xmlDoc.Root.Add(name);
                    XElement surname = new XElement("Surname", log.Surname);
                    xmlDoc.Root.Add(surname);
                    index++;
                }
                xmlDoc.Save(path);
            }
            else
            {
                using (XmlWriter writer = XmlWriter.Create(path, settings))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("LogDTO");
                    int i = 0;
                    foreach (var log in logDTO)
                    {
                        writer.WriteElementString("Id", i.ToString());
                        writer.WriteElementString("Name", log.Name);
                        writer.WriteElementString("Surname", log.Surname);
                        i++;
                    }
                    writer.WriteEndElement();
                    writer.Flush();
                    writer.WriteEndDocument();
                }              
            }
        }
    }
}
