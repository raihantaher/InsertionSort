using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insertion Sort: \n");

            int[] theNumbers = { 4, 7, 3, 8, 6, 1, 2, 9, 5, 0 };

            Console.WriteLine("The array before sorting:");

            for(int i = 0; i < theNumbers.Length; i++)
            {
                Console.Write(theNumbers[i]);

                if(i < theNumbers.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            
            for (int item = 1; item <theNumbers.Length; item++)
            {
                int j = item;
                while(j > 0)
                {
                    if(theNumbers[j-1] > theNumbers[j])
                    {
                        int holder = theNumbers[j];
                        theNumbers[j] = theNumbers[j - 1];
                        theNumbers[j - 1] = holder;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("The array after sorting: ");

            for (int i = 0; i < theNumbers.Length; i++)
            {
                Console.Write(theNumbers[i]);

                if (i < theNumbers.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.ReadKey();
            
        }
    }
}
