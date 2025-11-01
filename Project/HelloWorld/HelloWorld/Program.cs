using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CSharpEvidence();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void CSharpEvidence()
        {
            //AnsToQuestionNoA();
            //AnsToQuestionNoB();
            //AnsToQuestionNoC();
            //AnsToQuestionNoD();
            //AnsToQuestionNoE();
            //AnsToQuestionNoF();


        }

        private static void AnsToQuestionNoA()
        {
            DecisionStatement();
        }

        private static void DecisionStatement()
        {

            Convert.ToInt32(Console.ReadLine());
            int age = 17;
            if (age >= 18)
            {
                Console.WriteLine("You can vote.");
            }
            else
            {
                Console.WriteLine("You can not vote.");
            }
            Console.WriteLine("____________");

            int mark = Convert.ToInt32(Console.ReadLine());

            if (mark >= 00 && mark <= 100)
            {
                if (mark >= 80)
                {
                    Console.WriteLine("A+");
                }
                else if (mark >= 70)
                {
                    Console.WriteLine("A");
                }
                else if (mark >= 60)
                {
                    Console.WriteLine("A-");
                }
                else if (mark >= 50)
                {
                    Console.WriteLine("B");
                }
                else if (mark >= 40)
                {
                    Console.WriteLine("C");
                }
                else if (mark >= 33)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("F");
                }
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }



        }

        private static void AnsToQuestionNoC()
        {

            int a = 9;
            int b = 3;
            int c = 0;
            c = a + b;
            Console.WriteLine("{0}+{1}={2}", a, b, c);

            c = a - b;
            Console.WriteLine("{0}-{1}={2}", a, b, c);

            c = a * b;
            Console.WriteLine("{0}*{1}={2}", a, b, c);

            c = a / b;
            Console.WriteLine("{0}/{1}={2}", a, b, c);

            int x = 6;
            int y = 0;
            y = ++x;
            Console.WriteLine("pre-increment of {0}", y);

            x = 6;
            y = 0;
            y = --x;
            Console.WriteLine("pre-decrement of {0}", y);

            x = 6;
            y = 0;
            y = x++;
            Console.WriteLine("post-increment of {0}", y);
            x = 6;
            y = 0;
            y = x--;
            Console.WriteLine("post-decrement of {0}", y);


        }

    }
}
