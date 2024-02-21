using System;
using System.Net.Mail;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ///<remove `//` to run the code> 
            ///<replace `?` with the number you want to find the fibonacci of>
            ///Example: Fibonacci(5);
            ///Output: The fibonacci of 5 is 15
            ///Example: Fibonacci(0);
            ///Output: 0
        

            ///<YOU START HERE> // FOLLOW THE INSTRUCTIONS ABOVE
           //int num = ?;
           //Fibonacci(num);
           
        }

        public static void Fibonacci(int num) {
                int sum = 0;
                int i = 0;
            if(num==0){
                Console.WriteLine(num);
            } else if (num<0) {
                Console.WriteLine("Please enter a positive number");
            } else {
                while(i<num) {
                i = i+1;
                sum = sum + i;
            }
            Console.WriteLine($"The fibonacci of {num} is {sum}");
            }
            
        }
    }
}