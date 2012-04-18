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
                    Console.WriteLine("\n##################################");
                    try
                    {
                        Console.Write("\nEnter income: ");
                        try
                        {
                            inc = ulong.Parse(Console.ReadLine());
                            if (inc == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n!! - Enter a valid number for income");
                                Console.ResetColor();
                                execute = true;

                            }
                            else
                                execute = false;
                        }
                        catch (OverflowException e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n!! - Enter a valid number for income");
                            Console.ResetColor();
                            execute = true;
                        }
                    }

                    //catch if income is not a valid integer
                    catch (FormatException e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n!! - Enter a valid number for income");
                        Console.ResetColor();
                        execute = true;
                    }
                }
                //dependents
                execute = true;
                while (execute)
                {
                    try
                    {
                        Console.Write("\nEnter # of Dependents: ");
                        try
                        {
                            dep = ulong.Parse(Console.ReadLine());
                            execute = false;
                        }
                        catch (OverflowException e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n!! - Enter a valid number for dependents!");
                            Console.ResetColor();
                            execute = true;
                        }

                    }

                    //catch if dependents are not a valid integer
                    catch (FormatException e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n!! - Enter a valid number for dependents!");
                        Console.ResetColor();
                        execute = true;
                    }
                }
                //Compute
                Compute comp = new Compute() { income = inc, dependent = dep, tax = (decimal)0.0 };
                comp.Run();

                //print results
                Console.WriteLine("\nIncome: " + comp.income + " Dependent: " + comp.dependent + " Tax: " + comp.tax);

                do
                {
                    Console.Write("\nContinue? yes or no: ");
                    Continue = Console.ReadLine();
                    execute = true;
                } while ((String.Compare(Continue, "yes", true) == 0) || (String.Compare(Continue, "no", true) == 0) ? false : true);
                    
            } while (String.Compare(Continue, "yes", true) == 0 ? true : false);
        }
    }
}