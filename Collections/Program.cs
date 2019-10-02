using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays();
        }
        static void Arrays()
        {
            // arrays are the most basic way
            // to group many values of the same type together
            int[] intArray = new int[4];
            // array size is fixed at intialization
            intArray[0] = 3;
            intArray[1] = 5;
            //array is {3,5,0,0}

            //software called debugger
            //"breakpoint"

            //this type of syntax is called "collections intializer"
            int[] intArray2 = new int[] { 1, 2, 3, 10, 12 };
        }
        static void Lists()
        {
            ArrayList list = new ArrayList();
            list.Add(3);
            list.Add(3.1);

        }

        static void OtherCollections()
        {
            var set = new HashSet<string> {"a", "b", "c"};
            Console.WriteLine(set.Count);

            var dict = new Dictionary<int, int> {
                [1] = 1,
                [3] = 9,
                [2] = 4,
                [10] = 100
            };
            var hundred = dict[10];
        }
    }
}
