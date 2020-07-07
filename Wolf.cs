using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050720
{
    class Wolf : Dog
    {
        public string _nameOfPack;
        public Wolf(string name, string favoriteDogFood, string nameOfPack) :base(name, favoriteDogFood)
        {
            this._nameOfPack = nameOfPack;
        }

        public override void MakeSound()
        {
            Bark();
        }
        public override string ToString()
        {
            return $"{base.ToString()} , Name of pack : {_nameOfPack}";
        }
    }
}
