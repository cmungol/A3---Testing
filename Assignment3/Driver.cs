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
            //income
            ulong inc = 0UL;
            bool execute = true;

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
            ulong dep = 0UL;
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
            Compute comp = new Compute() { income = inc, dependent = dep, tax = 0.0f };
            comp.Run();

            //print results
            Console.WriteLine("Income: " + comp.income + " Dependent: " + comp.dependent + " Tax: " + comp.tax);
        }
    }
}
