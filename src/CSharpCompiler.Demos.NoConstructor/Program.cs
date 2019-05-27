using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace CSharpCompiler.Demos.NoConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Minnie");
            dog.Bark();

            Console.ReadLine();
        }

        #region weird
        static Dog CreateWeirdDog()
        {
            return (Dog)RuntimeHelpers.GetUninitializedObject(typeof(Dog));
        }
        #endregion

    }

    class Dog
    {
        private string _name;

        public Dog(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Dog needs a name, you stupid developer", nameof(name));
            }

            _name = name;
        }

        public void Bark()
        {
            Console.WriteLine($"Woof woof! {_name} barks!");
        }
    }
}
