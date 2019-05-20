using System;
using System.Runtime.CompilerServices;
using Calculator;

[assembly: IgnoresAccessChecksTo("Calculator")]
namespace CrazyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var square = new Square(4);
            var calculator = new AreaCalculator();
            var area = calculator.Calculate(square);
            Console.WriteLine($"Square with a side of 4 has an area of {area}");

            #region moar
            //double* ptr;
            //ptr = &area;

            //// displaying value of area using pointer 
            //Console.WriteLine("The value of area using a pointer is " + *ptr);
            #endregion
        }
    }
}

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class IgnoresAccessChecksToAttribute : Attribute
    {
        public IgnoresAccessChecksToAttribute(string assemblyName)
        {
            AssemblyName = assemblyName;
        }

        public string AssemblyName { get; }
    }
}
