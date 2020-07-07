using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _050720
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog("Shon", "Bonzo");
            Poodle p = new Poodle("pilpel", "Cats", "12");
            Wolf w = new Wolf("Alpha", "fish", "Loneliness");
            Horse h = new Horse("Chita", true);
        }
        public static void  AnimalSing(Animal[] a)
        {
            a[1] = new Dog("Shon", "Bonzo");
            a[2] = new Poodle("pilpel", "Cats", "12");
            a[3] = new Wolf("Alpha", "fish", "Loneliness");
            a[4] = new Horse("Chita", true);
            a[5] = new PetWolf("Wolfy", "Birds", "Loneliness");

            for (int i = 0; i < a.Length; i++)
            {
                a[i].MakeSound();
                Console.WriteLine(a[i]);
            }         
        }

    }
}
