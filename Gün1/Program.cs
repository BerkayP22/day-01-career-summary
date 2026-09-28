using System;

namespace Gun1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Adınız: ");
            string name = Console.ReadLine();
            Console.Write("Yaşınız: ");
            int age;
            if (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.WriteLine("Geçerli bir yaş girin.");
                return;
            }
            Console.Write("Kariyer hedefiniz: ");
            string goal = Console.ReadLine();
            Console.WriteLine($"{name}, {age} yaşında. Hedefi: {goal}.");
        }
    }
}
