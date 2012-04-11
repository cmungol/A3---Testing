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
            int bracket = 0;
            if (0 < income && income <= 20000)
                bracket = 1;
            else if (20000 < income && income <= 30000)
                bracket = 2;
            else if (30000 < income && income <= 40000)
                bracket = 3;
            else if (40000 < income && income <= 50000)
                bracket = 4;
            else if (50000 < income && income <= 90000)
                bracket = 5;
            else
                bracket = 6;

            switch (bracket)
            {
                case 1:
                    tax = income * .04f;
                    break;
                case 2:
                    tax = income * .05f;
                    break;
                case 3:
                    tax = income * .06f;
                    break;
                case 4:
                    tax = income * .07f;
                    break;
                case 5:
                    tax = income * .10f;
                    break;
                case 6:
                    tax = income * .13f;
                    break;
                default:
                    Console.WriteLine("Something is wrong with the income bracket computation");
                    break;
            }

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
