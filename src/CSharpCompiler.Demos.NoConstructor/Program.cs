using System;
using System.Runtime.Serialization;

namespace CSharpCompiler.Demos.NoConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Minnie");
            dog.Bark();

            #region weird
            //var dog2 = (Dog)FormatterServices.GetUninitializedObject(typeof(Dog));
            //dog2.Bark();
            #endregion

            Console.ReadLine();
        }
    }

    class Dog
    {
        private string _name;

        public Dog(string name)
        {
            _name = name;
        }

        public void Bark()
        {
            Console.WriteLine($"Woof woof! {_name} barks!");
        }
    }
}
