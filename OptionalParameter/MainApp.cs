using System;

namespace OptionalParameter
{
    class MainApp
    {
        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }
        static void Main(string[] args)
        {
            PrintProfile("중근");
            PrintProfile("관순", "000-0000-0000");
            PrintProfile(name: "중근", phone: "000-000-0000");
        }
    }
}
