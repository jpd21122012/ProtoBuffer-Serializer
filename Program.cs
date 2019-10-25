using ProtoSerialization.Data;
using ProtoSerialization.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProtoSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ProtoBuff Serializer !!!");
            //Binary Data of Object<T>
            byte[] tempByte = SerializationHelpers.SerializeHelper.ProtoSerialize(ProjectObjects.ProjectList);
            //Save those bytes on a bin file
            File.WriteAllBytes("projectObject.bin",tempByte);
            //Retrieve byte[] of bin file
            var protoBytes = File.ReadAllBytes("projectObject.bin");
            //Deserialize Object<T> to use it in somewhere
            var protoObjBack = SerializationHelpers.SerializeHelper.ProtoDeserialize<List<Project>>(protoBytes);
            //Print the Name of the first obj<T>
            Console.WriteLine(protoObjBack.First().Name);
            Console.Read();
        }
    }
}
