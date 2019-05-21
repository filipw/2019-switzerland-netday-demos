using Example;
using System;

namespace CsharpCompiler.Demos.MemberOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            var westie = new Westie();
            Console.WriteLine(westie.GetDescription());
        }
    }
}
