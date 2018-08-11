using System;

namespace ValueSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will let you enter two values and display the values in order.");
            Console.WriteLine("Then it will let you swap the two values and display them again, in the swapped order.");
            Console.WriteLine("Please enter a value:");

            string value1 = Console.ReadLine();

            Console.WriteLine("Please enter another value:");

            string value2 = Console.ReadLine();

            Console.WriteLine($"Okay, the first value is {value1} and the second value is {value2}.");
            Console.WriteLine("Now please type press the enter key to view the values in swapped order:");

            Console.ReadLine();

            //pass the values of value1 and value2 into the parameters swap1 and swap2 respectively,
            //then execute the method
            ValueSwap(ref value1, ref value2);

            Console.WriteLine($"Okay, now the first value is {value1} and the second value is {value2}.");

            Console.ReadLine();

        }

        public static void ValueSwap(ref string swap1, ref string swap2)
        {
            //initialize a placeholder variable
            string swapnew;

            //pass the value of swap1 into swapnew
            //this is so that we don't lose the value of swap1 when we assign swap1 a new value
            swapnew = swap1;
            //pass the value of swap2 into swap1
            //this is why we need swapnew
            swap1 = swap2;
            //pass the value of swapnew into swapnew
            //this effectively passes the value of swap1 into swapnew
            swap2 = swapnew;
        }

    }
}
