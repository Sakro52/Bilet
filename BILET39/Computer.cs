using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Computer
    {
        private string model;
        private int ram;
        private int hdd;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Ram
        {
            get { return ram; }
            set
            {
                if (value >= 2 && value <= 32)
                {
                    ram = value;
                }
                else
                {
                    throw new ArgumentException("ОЗУ должно быть от 2 до 32 ГБ!");
                }
            }
        }

        public int Hdd
        {
            get { return hdd; }
            set
            {
                if (value >= 200 && value <= 2000)
                {
                    hdd = value;
                }
                else
                {
                    throw new ArgumentException("HDD должно быть от 200 до 2000 ГБ!");
                }
            }
        }

        public Computer(string model, int ram, int hdd)
        {
            this.model = model;
            Ram = ram;
            Hdd = hdd;
        }

        public double CalculateCost()
        {
            return 500 + ram * 50 + hdd * 0.5;
        }
    }
}
