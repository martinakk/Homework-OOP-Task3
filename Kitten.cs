using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kitten : Cat
{
    private string kittenSay = "miau-miau";

    public Kitten(string name, byte age):base(name,"female",age)
    {
        this.Name = name;
        this.Age = age;
    }
    public override string ToString()
    {
        StringBuilder kitten = new StringBuilder();
        kitten.Append(this.Name.ToString() + " ");
        kitten.Append(this.Age.ToString() + " ");
        kitten.Append(this.Sex.ToString() + " ");
        kitten.Append(this.MakeSound(kittenSay));
        return kitten.ToString();
    }

    public override string MakeSound(string animalSound)
    {
        return this.kittenSay.ToString();
    }
}
