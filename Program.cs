using System;
using System.Net.Mail;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           int num = 7;
           Fibonacci(num);
           
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