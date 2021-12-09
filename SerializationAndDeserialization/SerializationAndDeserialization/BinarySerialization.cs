using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationAndDeserialization
{
    public class BinarySerialization
    {
        public void Serialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"F:\SAD\SerializationAndDeserialization\SerializationAndDeserialization\SerializationAndDeserialization\File\");
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
            Console.WriteLine();
        }
        public void Deserialization()
        {
            FileStream fileStream = new FileStream(@"F:\SAD\SerializationAndDeserialization\SerializationAndDeserialization\SerializationAndDeserialization\File\Example.txt");
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializedSampleDemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"Application Name : { deserializedSampleDemo.ApplicationName}     ---      Application ID : {deserializedSampleDemo.ApplicationId}");
            Console.WriteLine();
        }
    }
    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialize";
        public int ApplicationId { get; set; } = 1001;
    }
}
