using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            ulong inc = 0UL;
            bool execute = true;
            ulong dep = 0UL;
            string Continue = "yes";

            do
            {
                //income
                while (execute)
                {
                    try
                    {
                        Console.WriteLine("Enter income: ");
                        inc = ulong.Parse(Console.ReadLine());
                        execute = false;
                    }

                    //catch if income is not a valid integer
                    catch (FormatException e)
                    {
                        Console.WriteLine("Enter a valid number for income!");
                        execute = true;
                    }
                }
                //dependents
                execute = true;
                while (execute)
                {
                    try
                    {
                        Console.WriteLine("Enter # of Dependents");
                        dep = ulong.Parse(Console.ReadLine());
                        execute = false;
                    }

                    //catch if dependents are not a valid integer
                    catch (FormatException e)
                    {
                        Console.WriteLine("Enter a valid number for dependents!");
                        execute = true;
                    }
                }
                //Compute
                Compute comp = new Compute() { income = inc, dependent = dep, tax = (decimal)0.0 };
                comp.Run();

                //print results
                Console.WriteLine("Income: " + comp.income + " Dependent: " + comp.dependent + " Tax: " + comp.tax);

                Console.WriteLine("Continue? yes or no");
                Continue = Console.ReadLine();

                execute = true;

            } while (String.Compare(Continue, "yes", true) == 0 ? true : false );
        }
    }
}
