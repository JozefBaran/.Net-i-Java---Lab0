using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class FizzBuzz
    {
        private int upperLim;

        public FizzBuzz(int upperLim)
        {
            this.upperLim = upperLim;
        }

        public void PrintFizzBuzz()
        {
            for (int i = 1; i <= upperLim; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj górny zakres liczb dla FizzBuzz:");
            int upperLim = Convert.ToInt32(Console.ReadLine());

            FizzBuzz fizzBuzz = new FizzBuzz(upperLim);
            fizzBuzz.PrintFizzBuzz();
        }
    }
}