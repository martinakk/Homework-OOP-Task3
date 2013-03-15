using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Frog:Animal
{
    private string color;
    private string frogSay = "Kvak";

    public string Color
    {
        get { return this.color; }
        set { this.color = value; }
    }

    public Frog(string name, string sex, byte age, string color)
        : base()
    {
        this.Name = name;
        this.Sex = sex;
        this.Age = age;
        this.color = color;
    }

    public string MakeSound(string frogSay)
    {
        return this.frogSay.ToString();
    }
}
