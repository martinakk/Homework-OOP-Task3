using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Animal: IComparable<Animal>
{
    public string Name{get;set;}
    public string Sex { get; set; }
    public byte Age { get; set; }

    public override string ToString()
    {
        return @"This is " + this.Name.ToString()+
            "It is "+ this.Sex.ToString()+
            "And is "+this.Age+" years old.";
    } 

    public int CompareTo(Animal other)
    {
        return this.Age.CompareTo(other.Age);
    }
}
