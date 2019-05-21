using System;

namespace CSharpCompiler.Demos.InvalidProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    // legal type topology in C#
    // type definition is recursive but the struct layout is not - the field is static
    struct Leaf
    {
        //public Leaf? Foo;
        public static Leaf? Foo;
    }
}
