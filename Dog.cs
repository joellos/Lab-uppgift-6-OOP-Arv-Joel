using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_uppgift_6_OOP_Arv_Joel
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string breed,string name, string species, string color, int weight, string eat, int displayTime) : base(name, species, color, weight, eat, displayTime)
        {
            Breed = breed;

        }
        
        public override async Task MakeSound()
        {
            Console.WriteLine("Hunden låter Voff!");
            await Task.Delay(DisplayTime * 1000);
            await Task.WhenAll();
        }

        public override async Task DisplayAnimal()
        {
            Console.WriteLine($"Hundens namn: {Name}, hundens art: {Species}, hundens färg: {Color}, hundens vikt: {Weight}, hundens favorit mat: {Eat} ");
            await Task.CompletedTask;
        }
    }

    public class Chihuahua : Dog
    {
        public string Loud { get; set; }
        public Chihuahua(string loud, string breed, string name, string species, string color, int weight, string eat, int displayTime) : base(breed, name, species, color, weight, eat, displayTime)
        {
            Loud = loud;
        }
        public void HighPitchBark()
        {
            Console.WriteLine("Chihuahua skäller med ljus ton!");
        }
    }
    public class Bulldog : Dog
    {
        public string Cute { get; set; }
        public Bulldog(string cute, string breed, string name, string species, string color, int weight, string eat, int displayTime) : base(breed, name, species, color, weight, eat, displayTime)
        {
            Cute = cute;
        }
        public void LowPitchBark()
        {
            Console.WriteLine("Bulldog skäller med låg ton!");
        }
    }
}
