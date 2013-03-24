using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class TestAnimal
    {

        public static void AverageAge(List<Animal> animals)
        {
            byte sum = 0;
            string kind = "";
            foreach (var animal in animals)
            {
                sum += animal.Age;
                kind = animal.GetType().ToString();
            }
            float average = sum / 2;
            Console.WriteLine("The average age of all {0}s is {1}", kind, average); 
        }

        static void Main()
        {
            List<Animal> kittens = new List<Animal>();
            kittens.Add(new Kitten("Shushi", 1));
            kittens.Add(new Kitten("Linda", 2));
            kittens.Add(new Kitten("Miki", 5));

            AverageAge(kittens);

            List<Animal> tomcats = new List<Animal>();
            tomcats.Add(new Tomcat("Shush", 2));
            tomcats.Add(new Tomcat("Joro", 3));
            tomcats.Add(new Tomcat("Miki", 6));

            AverageAge(tomcats);

            List<Animal> dogs = new List<Animal>();
            dogs.Add(new Dog("Shusho", "male",8,"breeed"));
            dogs.Add(new Dog("Joro", "male",4,"breeeeeed"));
            dogs.Add(new Dog("Miki", "female",2,"breeeed"));

            AverageAge(dogs);

            List<Animal> frogs = new List<Animal>();
            frogs.Add(new Frog("Shusho", "male", 1, "pink"));
            frogs.Add(new Frog("Joro", "male", 2, "green"));
            frogs.Add(new Frog("Miki", "female", 3, "purple"));

            AverageAge(frogs);
        }
    }
}
