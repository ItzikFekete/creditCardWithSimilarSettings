using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creditCardWithSimilarSettings
{
    public class Cc
    {
       

        class FirstSet
        {
            static void Main(string[] args)
            {
                int firstNum = 0;
                int secondNum = 0;
                int thirdNum = 0;
                int fourthNum = 0;
                Console.WriteLine("All numbers are 0 to 9, excpet the first and last digit, which cannot be a 0");
                Console.WriteLine("Please enter your first number");
                // firstNum = int.Parse(Console.ReadKey(true).KeyChar); didn't work
                firstNum = int.Parse(Console.ReadLine());
                if (firstNum %2 == 0)
                {
                    Console.WriteLine("Please choose again");
                    firstNum = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("You choose" + firstNum);
                    
                }
                Console.WriteLine("Please chose your second number");
                    secondNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your next SINGULAR number");
                    thirdNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your next SINGULAR number");
                    fourthNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your first 4 numbers are" + firstNum + secondNum + thirdNum + fourthNum);
                    int x = 0;
                    x = (firstNum + secondNum + thirdNum + fourthNum);
                    Console.WriteLine(x);
                
                

           
            }
           /* class SecondSet
            {
                static void Main(string[] args)
                {
                    int firstNum = 0;
                    int secondNum = 0;
                    int thirdNum = 0;
                    int fourthNum = 0;
                    Console.WriteLine("Please enter your next SINGULAR number");
                    firstNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your next SINGULAR number");
                    secondNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your next SINGULAR number");
                    thirdNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your next SINGULAR number");
                    fourthNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your second 4 numbers are" + firstNum + secondNum + thirdNum + fourthNum);
                   
                }
                
            }*/
            
            
        }
    }
}
