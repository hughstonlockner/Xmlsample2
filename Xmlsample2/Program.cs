using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace Xmlsample2
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee();

            emp.ID = 123;
            emp.Name = "Hughston";
            emp.ssNumber = 123456789;
            emp.EntryDate = DateTime.Now;

            Console.WriteLine($"Employee ID: {emp.ID} \nEmployee Name: {emp.Name} \nEmployee SS#: {emp.ssNumber} \nDate Created: {emp.EntryDate}");

            string FilePath = "c:/Temp/";
            string FileName = "Samurai.xml";

            TextWriter writer = new StreamWriter(FilePath + FileName);

            XmlSerializer ser = new XmlSerializer(typeof(Employee));

            ser.Serialize(writer, emp);
            writer.Close();

            Console.ReadLine();
            
        }
    }
}
