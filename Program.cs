using System;

namespace HowOld
{
    internal class Program
    {
        /// <summary>
        /// Tells you how old you are
        /// </summary>
        /// <param name="year">The year you were born</param>
        /// <param name="month">[Optional] The month you were born</param>
        /// <param name="day">[Optional] The day you were born</param>
        public static void Main(int year, int month = 0, int day = 0)
        {
            if (year == 0)
            {
                Console.WriteLine("You must supply a year (with --year)");
                return;
            }
            var age = DateTime.Now.Year - year;

            if (month > 0)
            {
                if (month > DateTime.Now.Month)
                {
                    age--;
                }
                else if (month == DateTime.Now.Month && day > 0)
                {
                    if (day > DateTime.Now.Day)
                    {
                        age--;
                    }
                }
            }

            Console.WriteLine("You are " + age + " year(s) old!");
        }
    }
}


