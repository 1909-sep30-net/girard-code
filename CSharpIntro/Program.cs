using System;
using System.Linq;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // make a bool, string, and int variables (with values)

            bool v = true;
            string name = "Girard";
            int pi = 3;

            // change their values to something else

            v = false;
            name = "Sanford";
            pi = 4;

            // print their values with console

            Console.WriteLine("bool = " + v + ", string = " + name + ", int = " + pi);

            // do something in a for loop

            int[] array = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i <= array.Length; i++)
            {
                Console.WriteLine(i);
            }

            // do something in a while loop
            int d = 0;
            while (array[d] < 3)
            {
                d++;
                Console.WriteLine("ok");
            }
            // do something with a switch statement

            int n = 1;
            switch (n)
            {
                case 0:
                    Console.WriteLine("good");
                    break;
                case 1:
                    Console.WriteLine("bad");
                    break;
            }

            //do something with if, else if, else

            int a = 1;
            int c = 3;

            if (c < a)
            {
                Console.WriteLine(c + " is less than " + a);
            }
            else if (c > a)
            {
                Console.WriteLine(c + " is greater than than " + a);
            }
            else
            {
                Console.WriteLine(c + " is equal to " + a);
            }

            // figure out how to make multi-line comments in C#

            /*somebody
            help */

            // figure out how to format your document in VS Code

            //done

            // extra: make a new static method to do something and call it

            static double divide(int op1, int op2)
            {
                return op1 / op2;

            }
            Console.WriteLine(divide(64, 8));
            // extra: learn what "var" means in C# and try it out.

            // Example #1: var is optional when
            // the select clause specifies a string
            string[] words = { "apple", "strawberry", "grape", "peach", "banana" };
            var wordQuery = from word in words
                            where word[0] == 'g'
                            select word;

            // Because each element in the sequence is a string, 
            // not an anonymous type, var is optional here also.
            foreach (string s in wordQuery)
            {
                Console.WriteLine(s);
            }

        }
    }
}
