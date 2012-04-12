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
        public float tax { get; set; }

        public void Run()
        {
            if (0 < income && income <= 20000)
                tax = income * .04f;
            else if (20000 < income && income <= 30000)
                tax = income * .05f;
            else if (30000 < income && income <= 40000)
                tax = income * .06f;
            else if (40000 < income && income <= 50000)
                tax = income * .07f;
            else if (50000 < income && income <= 90000)
                tax = income * .10f;
            else
                tax = income * .13f;

            if (dependent == 1)
                tax = tax - (0.1f * tax);
            else if (2 <= dependent && dependent <= 3)
                tax = tax - (0.25f * tax);
            else if (3 < dependent)
                tax = tax - (.4f * tax);
            //might be a redundant statement
            else
                tax = tax;
        }
    }
}
