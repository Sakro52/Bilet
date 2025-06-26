using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Multiply : ICalculation
    {
        private double factor;

        public Multiply(double factor)
        {
            this.factor = factor;
        }

        public double Perform(double number)
        {
            return number * factor;
        }
    }
}
