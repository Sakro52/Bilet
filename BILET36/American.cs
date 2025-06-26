using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class American : Human
    {
        public American(string name) : base(name) { }

        public override void SayGreeting()
        {
            Console.WriteLine($"{name}: Hi!");
        }
    }
}
