using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050720
{
    public class Animal
    {
        public string _name;
        public Animal(string name)
        {
            this._name = name;
        }
        public virtual void MakeSound()
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} {_name}";
        }
    }
}
