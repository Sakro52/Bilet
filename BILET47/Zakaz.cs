using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Zakaz
    {
        private string fam;
        private int size;
        private string comfort;

        public string Fam
        {
            get { return fam; }
            set { fam = value; }
        }

        public int Size
        {
            get { return size; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Количество мест должно быть положительным!");
                size = value;
            }
        }

        public string Comfort
        {
            get { return comfort; }
            set { comfort = value; }
        }

        public Zakaz()
        {
            fam = "Не указано";
            size = 1;
            comfort = "Стандарт";
        }

        public Zakaz(string fam)
        {
            this.fam = fam;
            size = 1;
            comfort = "Стандарт";
        }

        public Zakaz(string fam, int size)
        {
            this.fam = fam;
            Size = size;
            comfort = "Стандарт";
        }

        public Zakaz(string fam, int size, string comfort)
        {
            this.fam = fam;
            Size = size;
            this.comfort = comfort;
        }

        public void Show()
        {
            Console.WriteLine($"Фамилия: {fam}");
            Console.WriteLine($"Количество мест: {size}");
            Console.WriteLine($"Комфортность: {comfort}");
            Console.WriteLine();
        }
    }
}
