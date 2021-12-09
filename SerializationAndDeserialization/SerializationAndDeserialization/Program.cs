using System;

namespace SerializationAndDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySerialization binary = new BinarySerialization();
            //binary.Serialization();
            binary.Deserialization();
            JSONSerialization serialization = new JSONSerialization();
            serialization.JsonSerialize();
            serialization.JsonDeserialize();
        }
    }
}
