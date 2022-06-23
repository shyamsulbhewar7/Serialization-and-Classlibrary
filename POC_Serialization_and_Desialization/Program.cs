using System;
using System.IO;
using System.Xml.Serialization;

[Serializable]
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
class DataSerializer
{
    public void XmlSerialize(Type dataType, object data, string filepath)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(dataType);
        if (File.Exists(filepath))
        {
            File.Delete(filepath);
        }
        TextWriter writer = new StreamWriter(filepath);
        xmlSerializer.Serialize(writer, data);
        writer.Close();
    }
    public object XmlDeserialize(Type dataType,string filePath)
    {
        object obj = null;
        XmlSerializer xmlSerializer = new XmlSerializer(dataType);
        if (File.Exists(filePath))
        {
            TextReader textReader = new StreamReader(filePath);
            obj = xmlSerializer.Deserialize(textReader);
            textReader.Close();
        }
        return obj;
    }
}

class class1
{
    static void Main(string[] args)
    {
        Person person1 = new Person(){FirstName = "Shyam", LastName = "Sulbhewar"};
        Person person2 = null;
        string filePath = "C:\\Users\\DELL\\Desktop\\SwabhavTechLab\\Assignment\\Serialization and Class Library\\POC_Serialization_and_Desialization\\data.txt";
        DataSerializer dataSerializer = new DataSerializer();
        dataSerializer.XmlSerialize( typeof(Person), person1, filePath);
        person2 = dataSerializer.XmlDeserialize(typeof(Person), filePath) as Person;
        Console.WriteLine("Person 1 data : " + person1.FirstName);
        Console.WriteLine("Person 2 data : " + person2.FirstName);
    }
}