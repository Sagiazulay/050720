using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050720
{
    class Poodle : Dog
    {
        public string _numberOfPonyTails;
        public Poodle (string name, string favoriteGodFood, string numberOfPonyTails):base (name, favoriteGodFood)
        {
            this._numberOfPonyTails = numberOfPonyTails;
        }
        public override void Bark()
        {
            Console.WriteLine("Poodly Poodly");
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Number of pony tails:{_numberOfPonyTails}";
        }
    }
}
