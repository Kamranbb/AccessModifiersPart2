using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersPart2
{
    internal class City
    {
        internal string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                bool isLetter=true;
                if (!(value.Length > 3 && value.Length < 20))
                {
                    Console.WriteLine("duzgun araliqda yazin");
                    return;
                }
                foreach (var item in value)
                {
                    if (!(char.IsLetter(item)))
                    {
                        isLetter = false;
                        break;
                    }
                    
                }
                if (isLetter)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("duzgun ad yazin");
                    return ;
                }

            }
        }

        internal int _population;
         public int Population
        {
            get
            {
                return _population;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Deyer 0-dan asagi ola bilmez.");
                    return;
                }
                //if (value < 100000)
                //{
                  //  Console.WriteLine("duzgun sayi yaz");
                    //return; 
               // }
                _population = value;
            }
        }
        public City()
        {
            
        }
        public City(string _name ,int _populatin)
        {
            _populatin = Population;
            _name=Name;
        }

    }
    }
 

