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
            try
            {
                Human[] people = new Human[]
                {
                    new Russian("Ivan"),
                    new Ukrainian("Oleh"),
                    new American("John")
                };

                for (int i = 0; i < people.Length; i++)
                {
                    people[i].SayGreeting();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
