using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Ukrainian : Human
    {
        public Ukrainian(string name) : base(name) { }

        public override void SayGreeting()
        {
            Console.WriteLine($"{name}: Привiт!");
        }
    }
}
