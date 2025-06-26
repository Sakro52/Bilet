using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Tour
    {
        public double TourCalc()
        {
            Console.WriteLine("Тур: Минское море, бесплатно");
            return 0;
        }

        public double TourCalc(string country)
        {
            double cost = 50;
            Console.WriteLine("Тур: " + country + ", 1 день, стоимость: " + String.Format("{0:F2}", cost));
            return cost;
        }

        public double TourCalc(string country, int days)
        {
            double cost = 50 * days;
            Console.WriteLine("Тур: " + country + ", " + days + " дней, стоимость: " + String.Format("{0:F2}", cost));
            return cost;
        }
    }
}
