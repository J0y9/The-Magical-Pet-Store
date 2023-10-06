using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Magical_Pet_Store
{
    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public void FeedPet(MagicalPet pet)
        {
            Console.WriteLine($"{Name} feeding {pet.Name}");
        }
        public void ExercisePet(MagicalPet pet)
        {
            Console.WriteLine($"{Name} exercising {pet.Name}");
        }

        public void UsePetAbility(MagicalPet pet)
        {
            Console.WriteLine($"{pet.Name} is {pet.SpecialAbility}");
        }
    }
}
