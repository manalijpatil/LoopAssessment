using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LoopAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r\n1.  Display numbers from 1 to 100.");
            for(int i = 1; i <= 100; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("\r\n2.  Display all even numbers from 1 to 100.");
            for(int e=1; e<=100; e++)
            {
                if (e % 2 == 0)
                {
                    Console.Write(e+" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("\r\n3.  Display all odd numbers from 200 to 300. ");
            for(int o = 200; o <= 300; o++)
            {
                if (o %2!= 0)
                {
                    Console.Write(o + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("\r\n4.Display the seventh element between 400 to 500(both numbers excluded)");
            int display = 0;
            for (int d = 401; d < 500; d++)
            {
                display++;
                if (display == 7)
                {
                    Console.WriteLine("The seventh element between 400 and 500 (both excluded) is: "+d);
                }
            }
            Console.WriteLine("\r\n5.  Find the first 10 even numbers");
            for(int f = 1; f <= 10; f++)
            {
                if (f % 2 == 0)
                {
                    Console.Write(f + " ");
                }
            }

            Console.WriteLine();
            
            Console.WriteLine("\r\n6.  Find all prime numbers < 100");
            //int no = 45;
            //for(int n = 1; n < 100; n++)
            //{

            //}
            Console.WriteLine("\r\n7.  Calculate factorial of a number. ");
            int fact = 1;
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                fact = fact * i;
            }
                Console.WriteLine("factorial of " +n+ "="+fact);

            Console.WriteLine("\r\n8.  Count the number of digits in any number.");
            Console.WriteLine("Enter the number");
            int numDigi = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (numDigi != 0)
            {
                numDigi = numDigi / 10;
                ++count;
            }
            Console.WriteLine("Number of digit=" + count);

            Console.WriteLine("\r\n11.  Generate Fibonacci series. 0,1, 1, 2, 3, 5,8 ..... k. where k < n . n is entered by user ");
            Console.WriteLine("Enter the number");
            int k = Convert.ToInt32(Console.ReadLine());
            int s1 = 0, s2 = 1;

            Console.WriteLine("Fibonacci series less than " + k + ": ");
            if (k > 0)
            {
                Console.Write(s1 + " ");
            }

            while (s2 < n)
            {
                Console.Write(s2 + " ");
                int next = s1 + s2;  
                s1 = s2;  
                s2 = next;  
            }



            Console.WriteLine("\r\n12.  Find the sum of all digits of a number.");
            int digit = 435;
            Console.WriteLine("Digit="+digit);
            int sum = 0;
            while (digit > 0)
            {
                int rem = digit % 10;
                sum = sum + rem;
                digit = digit / 10;
            }

            Console.WriteLine("Sum of digit =" +sum);

            Console.WriteLine();
            Console.WriteLine("\r\n13.  Find out if the given number is palindrome or not.");
            int num = 12012;
            int rev = 0;
            int temp = num;
            while (num > 0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            if (num == rev)
            {
                Console.WriteLine(num+" is palindrome");
            }
            else
            {
                Console.WriteLine(num+" is not palindrome");
            }

            Console.WriteLine("\r\n14.   check no is automorphic or not input n=25  output Automorphic as 25*25=625");
            Console.WriteLine("Enter the number:");
            int input = Convert.ToInt32(Console.ReadLine());
            int square = input * input;
            
                if (input % 10==square % 10){
                    
                    Console.WriteLine("the number is automorphic");
                }
                else
                {
                    Console.WriteLine("the number is not automorphic");
                }
            

        }


    }
}
