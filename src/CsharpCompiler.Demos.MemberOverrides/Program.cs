using Articles;
using System;

namespace CsharpCompiler.Demos.MemberOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            var gift = new ToyGift();
            Console.WriteLine(gift.GetDescription());
        }
    }
}
