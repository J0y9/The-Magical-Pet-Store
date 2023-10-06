using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Magical_Pet_Store
{
    public class MagicalPet
    {
        public string Name { get; set; }
        public string SpecialAbility { get; set; }

        public MagicalPet(string name,string specialAbility)
        {
             Name = name;
             SpecialAbility = specialAbility;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, SpecialAbility: {SpecialAbility}");
        }
    }
}
