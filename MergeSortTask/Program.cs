using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] data = new int[10];
            var num = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = num.Next(1, 101);
            }
            Console.WriteLine("Unsorted array");
            Printarray(data);
            Console.WriteLine("Sorted array");
            Mergesort(data, 0, data.Length-1);
            Printarray(data);
            Console.ReadLine();
        }
        public static void Mergesort(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = ( p + r )/2;
                
                Mergesort(A, p, q);
                
                Mergesort(A, q+1, r);
                
                Merge(A, p, q, r);
                
            }
        }

        public static void Merge(int[]A, int p, int q, int r)
        {
            

            int n1 =  q - p + 1;
            
            int n2 = r - q;
            
            int[] L = new int[n1];
            
            int[] R = new int[n2];

            int i, j;

            for (i = 0; i < n1; ++i)
            {
                L[i] = A[p + i];
            }

            for (j = 0; j < n2; ++j)
            {
                R[j] = A[q + 1 + j];
            }

            i = j = 0;

            int k = p;

             while (i < n1 && j < n2) {
                if (L[i] <= R[j])
                {
                    A[k] = L[i];
                    i++;
                }
                else
                {
                    A[k] = R[j];
                    j++;
                }
                k++;
             }

            while (i < n1)
            {
                A[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                A[k] = R[j];
                j++;
                k++;
            }

        }

        public static void Printarray(int[] data)
        {
            var text = string.Join(",", data);
            Console.WriteLine(text);
        }

    }
}
