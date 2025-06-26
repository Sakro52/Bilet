using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class InsuranceClient
    {
        private string name;
        private string insuranceType;
        private double insuranceAmount;

        public InsuranceClient(string name, string insuranceType, double insuranceAmount)
        {
            this.name = name;
            this.insuranceType = insuranceType;
            this.insuranceAmount = insuranceAmount;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Клиент: " + name);
            Console.WriteLine("Вид страховки: " + insuranceType);
            Console.WriteLine("Размер страховки: " + String.Format("{0:F2}", insuranceAmount));
            Console.WriteLine();
        }

        public string InsuranceType
        {
            get { return insuranceType; }
        }

        public double InsuranceAmount
        {
            get { return insuranceAmount; }
        }
    }
}
