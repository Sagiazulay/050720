using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _050720
{
    class PetWolf :Wolf
    {
        public PetWolf(string name, string favoriteDogFood, string nameOfPack) :base (name, favoriteDogFood, nameOfPack)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("WHOOOOOOOOOOOOOOoo");
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
