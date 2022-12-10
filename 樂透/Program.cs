using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //lottery program
                int count = 0, j = 0;
                int[] a = new int[7]; //Declare array variable to place lotto numbers
                Random r = new Random(); //Declare random variable r
            aa:
                Console.Write("How many lotto groups do you want?:");

                try //Judgment input value is an integer
                {
                    int k = int.Parse(Console.ReadLine());

                    while (true)
                    {

                        if (j == k) break; //Judging that the number of lottery groups matches, leave the While loop
                        count = 0;
                        j++;
                        Console.WriteLine("Lotto numbers:");
                        for (int i = 0; i < 7; i++)
                        {
                            a[i] = r.Next(1, 40);
                            int b = r.Next(1, 10);
                            for (int h = 0; h < i; h++)
                            {
                                while (a[h] == a[i]) //Determine whether the random number is repeated, if it is repeated, it will be regenerated
                                {
                                    count += 1; //Record the number of repetitions of random numbers
                                    h = 0;
                                    a[i] = r.Next(1, 40);
                                    b = r.Next(1, 10);
                                }
                            }
                            if (i < 6 )
                            {
                                Console.Write("{0}.", a[i]); //Print 6 lotto numbers
                                Thread.Sleep(100); //Delay 100m/s
                            }
                            else
                            {
                                Console.Write("\tPowerball Number:{0} ", b); //print powerball
                                Console.Write("\tRepetitions{0} ", count); //print out the number of repetitions
                            }
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception ex) //non-numeric treatment
                {
                    Console.WriteLine("Please enter a value");
                    goto aa; //back to aa
                }

                Console.Read();
            }
           
        }
    }
}
