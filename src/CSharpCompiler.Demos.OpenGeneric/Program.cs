using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompiler.Demos.OpenGeneric
{
    class Program
    {
        static void Main()
        {
            var yellow = Gift.Color.Yellow;
            var green = Gift<int>.Color.Green;
            //var green2 = Gift<>.Color.Green;

            #region different
            var normal = Enum.ToObject(typeof(Gift.Color), 0);
            var normalTyped = Enum.ToObject(typeof(Gift<int>.Color), 0);
            var weird = Enum.ToObject(typeof(Gift<>.Color), 0);

            Inspect(normal);
            Inspect(normalTyped);
            Inspect(weird);
            #endregion
        }

        private static void Inspect(object o)
        {
            Console.WriteLine(o);
            Console.WriteLine(o.GetType());
            Console.WriteLine(o.GetType().IsGenericTypeDefinition);
            Console.ReadKey();
            Console.WriteLine(Activator.CreateInstance(o.GetType()));

            Console.WriteLine();
            Console.ReadLine();
        }
    }


    class Gift<T>
    {
        public enum Color { Green, Blue }
    }

    class Gift
    {
        public enum Color { Yellow, Red }
    }
}
