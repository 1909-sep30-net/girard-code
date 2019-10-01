using System;

namespace DogApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog;
            try
            {
                // in the try bloc, you put the code that you think may throw an exception that you can handle here
                dog = new Dog(null, -5);

                //in C#, we have "bloc scope"
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("error, recovering");
                dog = new Dog("Spot", 5);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("error, recovering some argument error");
                dog = new Dog("Spot", 5);
            }
            
            //dog.name = "Spot";
            //dog.age = 4;
        }
    }
}
