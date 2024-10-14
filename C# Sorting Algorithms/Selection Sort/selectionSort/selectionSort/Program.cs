using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace selectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 21, 35, 12, 41, 13, 72, 52, 61, 11, 48 };

            int temp;
            int minIndex;
            
            Console.WriteLine("** Before the sorting starts **\n");

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n----------------------------------------\n");

            //Sorting algorithms
            for(int i = 0; i < array.Length - 1; i++) 
            {
                minIndex = i;

                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                        
                    }
                }
                temp = array[i];
                array[i] =array[minIndex];
                array[minIndex] = temp;

                
                foreach (int k in array)
                {

                    Console.Write(k + " ");
                }
                Console.WriteLine($" | Step {i+1}");

            }

            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("** After the sorting is over** \n");

            foreach (int k in array)
            {
                Console.Write(k + " ");
            }

            Console.Read();
        }
    }
}
