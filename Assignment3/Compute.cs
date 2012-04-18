using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    public class Compute
    {
        public ulong income { get; set; }
        public ulong dependent { get; set; }
        public decimal tax { get; set; }

        public void Run()
        {
            if (0 < income && income <= 20000)
                tax = income * (decimal).04;
            else if (20000 < income && income <= 30000)
                tax = income * (decimal).05;
            else if (30000 < income && income <= 40000)
                tax = income * (decimal).06;
            else if (40000 < income && income <= 50000)
                tax = income * (decimal).07;
            else if (50000 < income && income <= 90000)
                tax = income * (decimal).10;
            else
                tax = income * (decimal).13;

            if (dependent == 1)
                tax = tax - ((decimal)0.1 * tax);
            else if (2 <= dependent && dependent <= 3)
                tax = tax - ((decimal)0.25 * tax);
            else if (3 < dependent)
                tax = tax - ((decimal).4 * tax);
            else
                tax = tax;

            //round
            tax = (decimal)Math.Round(tax, MidpointRounding.AwayFromZero);
        }
    }
}
