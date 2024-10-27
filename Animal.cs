using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_uppgift_6_OOP_Arv_Joel
{
    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Color { get; set; }
        public int Weight { get; set; }
        public string Eat { get; set; }
        public int DisplayTime { get; set; }

        public Animal(string name, string species, string color, int weight, string eat, int displayTime)
        {
            Name = name;
            Species = species;
            Color = color;
            Weight = weight;
            Eat = eat;
            DisplayTime = displayTime;
        }
        public virtual async Task MakeSound()
        {
            
        }

        public virtual async Task DisplayAnimal()
        {
            
        }
        
    }
}
