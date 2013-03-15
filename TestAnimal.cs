using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class TestAnimal
    {

        public static void AverageAge(List<Kitten> animals)
        {
            byte sum = 0;
            foreach (var animal in animals)
            {
                sum += animal.Age;
            }
            float average = sum / 2;
            Console.WriteLine("The average age of all kittens is {0}", average); 
        }
        public static void AverageAge(List<Tomcat> animals)
        {
            byte sum = 0;
            foreach (var animal in animals)
            {
                sum += animal.Age;
            }
            float average = sum / 2;
            Console.WriteLine("The average age of all tomcats is {0}", average);
        }
        public static void AverageAge(List<Dog> animals)
        {
            byte sum = 0;
            foreach (var animal in animals)
            {
                sum += animal.Age;
            }
            float average = sum / 2;
            Console.WriteLine("The average age of all dogs is {0}", average);
        }
        public static void AverageAge(List<Frog> animals)
        {
            byte sum = 0;
            foreach (var animal in animals)
            {
                sum += animal.Age;
            }
            float average = sum / 2;
            Console.WriteLine("The average age of all frogs is {0}", average);
        }

        static void Main()
        {
            List<Kitten> kittens = new List<Kitten>();
            kittens.Add(new Kitten("Shushi", 1));
            kittens.Add(new Kitten("Linda", 2));
            kittens.Add(new Kitten("Miki", 5));

            AverageAge(kittens);

            List<Tomcat> tomcats = new List<Tomcat>();
            tomcats.Add(new Tomcat("Shush", 2));
            tomcats.Add(new Tomcat("Joro", 3));
            tomcats.Add(new Tomcat("Miki", 6));

            AverageAge(tomcats);

            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Shusho", "male",8,"breeed"));
            dogs.Add(new Dog("Joro", "male",4,"breeeeeed"));
            dogs.Add(new Dog("Miki", "female",2,"breeeed"));

            AverageAge(dogs);

            List<Frog> frogs = new List<Frog>();
            frogs.Add(new Frog("Shusho", "male", 1, "pink"));
            frogs.Add(new Frog("Joro", "male", 2, "green"));
            frogs.Add(new Frog("Miki", "female", 3, "purple"));

            AverageAge(frogs);
        }
    }
}
