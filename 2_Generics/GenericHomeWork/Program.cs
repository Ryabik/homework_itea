using System;

namespace GenericPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person<double, Shape> horse = new Person<double, Shape>(2.2, new Shape());

            Console.WriteLine(horse.ReturnCondition());
        }
    }
}
