using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_uppgift_6_OOP_Arv_Joel
{
    public class Horse : Animal
    {
        public double RunningSpeed { get; set; }
        public Horse(double runningSpeed, string name, string species, string color, int weight, string eat, int displayTime) : base(name, species, color, weight, eat, displayTime)
        {
            RunningSpeed = runningSpeed;
        }
        public void Race()
        {

        }
        public override async Task MakeSound()
        {
            Console.WriteLine("Hästens ljud är: Gnägg!");
            await Task.Delay(DisplayTime * 1000);
            await Task.CompletedTask;
        }
        public override async Task DisplayAnimal()
        {
            Console.WriteLine($"Hästens namn: {Name}, hästens art: {Species}, hästens färg: {Color}, hästens vikt: {Weight}, hästens favorit mat: {Eat} ");
            await Task.CompletedTask;
        }
    }
}
