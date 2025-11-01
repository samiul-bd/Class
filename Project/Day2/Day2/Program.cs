using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    public class Student
    {
        int studentID;
        string firstName;
        string lastName;
        string address;
        DateTime dateOfBirth;
        public string getFullName(int studentID)
        {
            string fullName;
            fullName = firstName + " " + lastName;
            return fullName;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoTask();
            }
            catch (Exception ExpObj)
            {
                Console.WriteLine(ExpObj.Message);

            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void DoTask()
        {
            //QuestionNoC();
            //QuestionNoA();
            //CascadingIfElse();
            //ShortCircit();



        }

        private static void ShortCircit()
        {
            int mark = 40;
            if (mark >= 60 && mark <= 100)
            {
                Console.WriteLine("You are Passed");
            }
            else
            {
                Console.WriteLine("You are Failed");
            }

            if (mark >= 60 || mark <= 100)
            {
                Console.WriteLine("You are Passed");
            }
            else
            {
                Console.WriteLine("You are Failed");
            }
        }

        private static void CascadingIfElse()
        {
            Console.WriteLine("Enter your Number");

            int Mark = Convert.ToInt16(Console.ReadLine());

            if (Mark >= 0 && Mark <= 100)
            {
                if (Mark >= 80)
                {
                    Console.WriteLine("A+");
                }
                else if (Mark >= 70 && Mark <= 80)
                {
                    Console.WriteLine("A");
                }
                else if (Mark >= 60 && Mark <= 70)
                {
                    Console.WriteLine("B");
                }
                else if (Mark >= 50 && Mark <= 60)
                {
                    Console.WriteLine("C");
                }
                else if (Mark >= 40 && Mark <= 50)
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
                Console.WriteLine("Invalid Mark");
            }

        }

        private static void QuestionNoA()
        {
            Console.WriteLine("Decision Statements");

            Console.WriteLine("If statement");
            Console.WriteLine("Enter you number");

            int mark = Convert.ToInt16(Console.ReadLine());



            bool isEven = false;
            isEven = (mark % 2 == 0);

            if (isEven)
            {
                Console.WriteLine($"{mark} is an even number");
            }
            else
            {
                Console.WriteLine($"{mark} is odd number");
            }

        }

        private static void QuestionNoC()
        {

            Console.WriteLine("Operator Prefix/Postfix");
            int a = 10;
            int b = 5;
            int c = 0;
            c = a + b;
            Console.WriteLine("{0}+{1}={2}", a, b, c);

            Console.WriteLine($"{a}+{b}={c}");

            c = a - b;
            Console.WriteLine("{0}-{1}={2}", a, b, c);
            c = a * b;
            Console.WriteLine("{0}*{1}={2}", a, b, c);
            c = a / b;
            Console.WriteLine("{0}/{1}={2}", a, b, c);

            int x = 5;
            int y = x++;
            Console.WriteLine("post increment of x ={0}", y);

            x = 5;
            y = ++x;
            Console.WriteLine("pre increment of x ={0}", y);


            x = 5;
            y = x--;
            Console.WriteLine("post decrement of x ={0}", y);

            x = 5;
            y = --x;
            Console.WriteLine("pre decrement of x ={0}", y);


        }
    }
}
