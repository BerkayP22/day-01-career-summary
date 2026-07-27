using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gün1
{
    public class dayOne
    {
        public string name, dss, ds, stat;
        public decimal Hour;
        public int age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            dayOne dayOne = new dayOne();
            
            Console.WriteLine("------------CareerTracker------------");
            Console.WriteLine(" ");
            Console.Write("Name:");
            dayOne.name=Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Age:");
            dayOne.age = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("DSS:");
            dayOne.dss = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("DS:");
            dayOne.ds = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("STATUS:");
            dayOne.stat = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Hour:");
            dayOne.Hour = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Clear();

            Console.WriteLine("------------CareerTracker------------");
            Console.WriteLine(" ");

            Console.WriteLine($"Name:{dayOne.name}\n Age:{dayOne.age}\n");
            Console.ReadLine();
        }
    }
}
