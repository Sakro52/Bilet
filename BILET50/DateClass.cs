using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class DateClass
    {
        private DateTime data;

        public DateClass()
        {
            data = DateTime.Now;
        }

        public DateClass(int year, int month, int day)
        {
            data = new DateTime(year, month, day);
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public DateTime PreviousDay()
        {
            return data.AddDays(-1);
        }

        public DateTime NextDay()
        {
            return data.AddDays(1);
        }
    }
}
