using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dog:Animal,ISound
{
    private string breed;
    private string dogSay = "Bau";

    public string Breed
    {
        get { return this.breed; }
        set { this.breed = value; }
    }

    public Dog(string name, string sex, byte age, string breed)
        : base()
    {
        this.Name = name;
        this.Sex = sex;
        this.Age = age;
        this.breed = breed;
    }
    public string MakeSound(string dogSay)
    {
        return this.dogSay.ToString();
    }
}
