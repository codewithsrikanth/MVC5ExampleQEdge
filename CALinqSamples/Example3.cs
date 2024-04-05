using System.Xml.Linq;
using System.IO;

namespace CALinqSamples
{
    class Example3
    {
        static void Main(string[] args)
        {
            string filepath = "C:\\SrikanthFiles\\MVC\\MVCControllers\\CALinqSamples\\StudentInfo.xml";
            XDocument doc = new XDocument();
            if (File.Exists(filepath))
            {
                doc = XDocument.Load(filepath);
            }
            else
            {
                Console.WriteLine("No File Found on the location");
            }

            //var students = from student in doc.Descendants("Student")
            //select new
            //{
            //    Name = student.Element("Name").Value,
            //    Age = student.Element("Age").Value
            //};

            var students = from student in doc.Descendants("Student")
                           where (int)student.Element("Age") > 20
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = (int)student.Element("Age")
                           };

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Name}     -   {item.Age}");
            }

            Console.WriteLine("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            //To Add new element into array
            XElement newStd = new XElement("Student",
                    new XElement("Name", name),
                    new XElement("Age", age));
            doc.Root.Add(newStd);
            doc.Save(filepath);
            Console.WriteLine("XML file updated");
            Console.Read();
        }
    }
}
