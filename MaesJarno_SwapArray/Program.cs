using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaesJarno_SwapArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[6] { 1, 2, 3, 4, 5, 6 };
            int[] B = new int[6] { 6, 5, 4, 3, 2, 1 };

            Console.WriteLine("Before the swap");
            Console.ReadLine();
            
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }

            Console.ReadLine();

            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine(B[i]);
            }

            for (int i = 0; i < B.Length; i++)
            {
                int temp = A[i];
                A[i] = B[i];
                B[i] = temp;
            }
            Console.ReadLine();
            Console.WriteLine("After the swap");
            Console.ReadLine();

            for (int i = 0; i < A.Length; i++)
            {               
                Console.WriteLine(A[i]);
            }
            
            Console.ReadLine();          
            
            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine(B[i]);
            }
        }   
    }
}
