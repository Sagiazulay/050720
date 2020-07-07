using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050720
{
    class Horse : Animal
    {
        public bool _racingHorse;
        public Horse (string name) : base (name)
        {

        }
        public Horse(string name, bool racingHorse) :base(name)
        {
            this._racingHorse = racingHorse;
        }
        public virtual void Neigh()
        {

        }
        public override void MakeSound()
        {
            Neigh();
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Racing Horse: {_racingHorse}";
        }
    }
}
