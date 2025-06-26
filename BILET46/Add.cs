using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Add : ICalculation
    {
        private double value;

        public Add(double value)
        {
            this.value = value;
        }

        public double Perform(double number)
        {
            return number + value;
        }
    }
}
