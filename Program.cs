using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

        class Program
        {
            public static void Main(string[] args)
            {
                // The array, with values.
                int[] data = { 1, 2, 3, 7, 7, 7, 7, 85, 152 };

                // Method that sort the array.
                Array.Sort(data);

                // Method that loops throught the array for the sort method, and prints it out.
                for (int i = 0; i < data.GetLength(0); i++)
                    Console.WriteLine(i + ": " + data[i]);

                // Console Method that makes a new empty line.
                Console.WriteLine("\n");

                Console.WriteLine("Total Sum of Array: " + SumMethod(data));

                Console.WriteLine("\n");

                Console.WriteLine("The Average of the Array: " + AverageMethod(data));

                Console.WriteLine("\n");

                ReturnOnlySeven(data);

                Console.WriteLine("The Above List of numbers show all the numbers 7 that is in the array");

                Console.WriteLine("\n");

                Console.WriteLine("Returns true if the number 3 is in the Array: " + ReturnTrueIfThree(data));

                Console.ReadLine();
            }

            // Method that adds the total sum of the array.
            public static int SumMethod(int[] data)
            {
                return data.Sum();
            }

            // Method that returns the average of the elements in the array.
            public static decimal AverageMethod(int[] data)
            {
                decimal result = (decimal)SumMethod(data) / data.Length;
                return result;
            }

            // Method that loops through the Array, and write out the number 7 every time it becomes true.
            public static void ReturnOnlySeven(int[] data)
            {
                foreach (int i in data)

                    if (i == 7)
                    {
                        Console.WriteLine(i);
                    }
            }

            // Method that returns true if the Array contains the number 3.
            public static bool ReturnTrueIfThree(int[] data)
            {
                bool found = false;

                foreach (int i in data)
                    if (i == 3)
                    {
                        found = true;
                    }

                return found;
            }
        }
    }
