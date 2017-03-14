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
            int[] theNumbers = { 4, 7, 3, 8, 6, 1, 2, 9, 5, 0 };

            List<int> sort = new List<int>();
            
            for (int x = 0; x < theNumbers.Length; x++)
            {
                if (sort.Count == 0)
                {
                    sort.Add(theNumbers[x]);
                    Console.WriteLine("inside zero");
                    foreach(int item in sort)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    for (int a = sort.Count; a > 0; a--)
                    {

                        if (sort[a - 1] < theNumbers[x])
                        {
                            sort.Add(theNumbers[x]);
                        }
                        else
                        {
                            sort.Add(sort[a - 1]);
                            sort[a - 1] = theNumbers[x];
                        }
                    }
                }

            }

            foreach(int item in sort)
            {
                Console.Write(item + ",");
            }
            Console.ReadKey();
        }
    }
}
