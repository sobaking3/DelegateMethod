using System;

namespace DelegateMethod
{
    public delegate string Hello(string name);
    class SomeClass
    {
        public string SayHello(string s)
        {
            return $"Привет, {s}:";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();
            Hello hD = new Hello(someClass.SayHello);
            Console.WriteLine(hD("Медведь"));
            Console.ReadKey();
        }
    }
}
