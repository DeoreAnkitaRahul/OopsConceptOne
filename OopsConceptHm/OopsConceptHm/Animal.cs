using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptHm
{
   public class Animal
    {
         public void Eat()
            {
                Console.WriteLine("Animal is eating");
            }
   }
        class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("Dog is barking");
            }
        }
        class Mammal : Animal
        {
            public void Run()
            {
                Console.WriteLine("Mammal is running");
            }
        }
        class Horse : Mammal
        {
            public void Gallop()
            {
                Console.WriteLine("Horse is galloping");
            }
        }
    
}
