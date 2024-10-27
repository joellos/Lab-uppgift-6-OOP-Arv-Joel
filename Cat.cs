using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_uppgift_6_OOP_Arv_Joel
{
    public class Cat : Animal
    {
        public double JumpHeight { get; set; }
        public Cat(double jumpHeight, string name, string species, string color, int weight, string eat, int displayTime) : base(name, species, color, weight, eat, displayTime)
        {
            JumpHeight = jumpHeight;
        }
        public void Claw()
        {

        }
        public override async Task MakeSound()
        {
            Console.WriteLine("Kattens ljud är: Mjau!");
            await Task.CompletedTask;
        }
        public override async Task DisplayAnimal()
        {
            Console.WriteLine($"Kattens namn: {Name}, kattens art: {Species}, kattens färg: {Color}, kattens vikt: {Weight}, kattens favorit mat: {Eat} ");
            await Task.CompletedTask;
        }
    }
}
