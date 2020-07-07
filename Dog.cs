using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050720
{
    class Dog : Animal 
    {
        public string favoriteDogFood;
        public Dog(string name) : base(name)
        {
            this._name = name;
        }
        public Dog(string name, string favoriteDogFood) :base (name)
        {
            this.favoriteDogFood = favoriteDogFood;
        }
        public virtual void Bark()
        {
            Console.WriteLine("WHAF WHAF");
        }

        public override void MakeSound()
        {
            Bark();
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {favoriteDogFood}, ";
        }
    }
}
