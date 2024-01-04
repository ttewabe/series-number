using System;

namespace MyNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            string address, city, state;

            Console.Write("Enter a address: ");
            address = Console.ReadLine();

            Console.Write("Enter a city: ");
            city = Console.ReadLine();

            Console.Write("Enter a state: ");
            state = Console.ReadLine();

            Console.Write("He lives in " + address + ", ");
            Console.Write("The city of " + city + ", ");
            Console.Write("in the state of " + state + " USA.");

            Console.Read();



        }
    }
}
