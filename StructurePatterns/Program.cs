using System;
using lab;
namespace StructurePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator generator = new();
            


            OutputModule emptymodule = new();
            Format1Decorator moduleWithFormat1 = new(emptymodule);
            Format2Decorator moduleWithFormat2 = new(emptymodule);
            Format2Decorator moduleWithAllFormats = new(moduleWithFormat1);



        }
    }
}
