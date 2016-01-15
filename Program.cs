using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    class Program
    {
        static int GetIntegerFromUser(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    string input = Console.ReadLine();
                    int x = int.Parse(input);






                    return x;
                }
                catch (Exception e)
                {
                    Console.WriteLine("wrong value.");


                    


                }
            }
        }
        static void Main(string[] args)
        {
            int startingNumber = GetIntegerFromUser("enter a number:");
            int steps = 0;
            int peakNum = 0;
            int peakStep = 0;
            
            while (startingNumber != 1)
            {
                steps++;
                if (startingNumber % 2 == 0)
                {
                    startingNumber = startingNumber / 2;

                    if(startingNumber > peakNum)
                    {
                        peakNum = startingNumber;
                        peakStep = steps;
                    }
                }
                else
                {
                    startingNumber = startingNumber * 3 + 1;

                    if (startingNumber > peakNum)
                    {
                        peakNum = startingNumber;
                        peakStep = steps;
                    }
                }

               
          
            }
            Console.WriteLine("It takes " + steps + " to reach 1 from " + startingNumber);
            Console.WriteLine("The value reaches its peak of " + peakNum + "of step " + peakStep);
            Console.WriteLine(steps);
            Console.ReadLine();

        }
    }
}