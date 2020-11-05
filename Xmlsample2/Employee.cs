using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Xmlsample2
{
    //[Serializable]
    [XmlRoot("New Employees", Namespace = "www.nerdinc.ninja")]
    public class Employee
    {
        [XmlAttribute("Empoyee ID")]
        public int ID { get; set; }
        [XmlElement("Full Name")]
        public string Name { get; set; }
        [XmlElement("Social Security Number")]
        public double ssNumber { get; set; }
        [XmlElement("Today's Date")]

        public DateTime EntryDate { get; set; }
    }
}