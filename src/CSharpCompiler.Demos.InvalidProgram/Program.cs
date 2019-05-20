using System;

namespace CSharpCompiler.Demos.InvalidProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    // type definition is recursive but the struct layout is not - the field is static
    // reason for the failure is that both the instance and static layout are done together
    struct Leaf
    {
        public Leaf Foo;
        //public static readonly Leaf? Default = null;
    }

    // legal type topology in C#
    struct Leaf<T>
    {
    }

    struct Tree
    {
        public Leaf<Tree> Leaf { get; set; }
    }
}
