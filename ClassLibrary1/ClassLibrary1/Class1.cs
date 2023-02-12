using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        string name;
        public Class1(string name)
        {
            this.name = name;
        }
        public void Print() => Console.WriteLine($"Name: {name}");
        

    }
}
