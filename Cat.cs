using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Cat : Animal, ISound
{
    public Cat(string name, string sex, byte age) : base() 
    {
    }
    public abstract string MakeSound(string sound);
}
