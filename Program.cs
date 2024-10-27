namespace Lab_uppgift_6_OOP_Arv_Joel
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Horse horse = new Horse(30, "Henry", "Mustang", "Black", 120, "Hay", 8);
            Dog dog1 = new Dog("Shepard", "Albert", "Dog", "Brown", 12, "Dog food", 9);
            Cat cat = new Cat(5, "Missy", "Cat", "Grey", 4, "Canned food", 4);
            Chihuahua chihuahua = new Chihuahua("Very loud", "Chihuahua", "Gilbert", "Dog", "White", 3, "Dog treats", 12);
            Bulldog bulldog = new Bulldog("Very cute", "Bulldog", "Sunshine", "Dog", "Grey", 15, "Dog bones", 6);
           await dog1.MakeSound();
            await dog1.DisplayAnimal();
            await horse.MakeSound();
            await horse.DisplayAnimal();
            await cat.MakeSound();
            await cat.DisplayAnimal();
            bulldog.LowPitchBark();
            chihuahua.HighPitchBark();
        }
    }
}
