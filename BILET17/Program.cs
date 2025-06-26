using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISwitchable> devices = new List<ISwitchable>();
            devices.Add(new TVSet());
            devices.Add(new PersonalComputer());

            int i;
            for (i = 0; i < devices.Count; i++)
            {
                devices[i].TurnOn();
                devices[i].TurnOff();
                Console.WriteLine();
            }
        }
    }
}
