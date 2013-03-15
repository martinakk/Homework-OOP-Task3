using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tomcat : Cat, ISound
{
    private string tomcatSay = "MAU MAU";

    public Tomcat(string name, byte age):base(name,"male", age)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
    {
        StringBuilder tomcat = new StringBuilder();
        tomcat.Append(this.Name.ToString() + " ");
        tomcat.Append(this.Age.ToString() + " ");
        tomcat.Append(this.Sex.ToString() + " ");
        tomcat.Append(this.MakeSound(tomcatSay));
        return tomcat.ToString();
    }

    public override string MakeSound(string animalSound)
    {
        return this.tomcatSay.ToString();
    }
}
