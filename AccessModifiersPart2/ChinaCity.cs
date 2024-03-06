using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersPart2
{
    internal class ChinaCity:City
    {
        public int Population {
            get
            {
            return _population;
            }
            set
            {
                if (value < 100000)
                {
                    Console.WriteLine("duzgun sayi yaz");
                    return;
                }
                _population = value;
            }
         }
        public ChinaCity() : base()
        {
            
        }
        public ChinaCity(string _name, int _population):base(_name,_population)
        {
            
        }
    }
}
