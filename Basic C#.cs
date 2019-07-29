// Basic C# Dev Skill

// null value check...
            string name = null;
            name = name ?? "Hello";
            Console.WriteLine(name);

          

            int firstvalue = 100;
            bool result = firstvalue > 50 ? true : false;
            Console.WriteLine(result);

            /*Post Increment , Pre Increment */
            int x = 5;
            int z = x++ * 5;
            z = ++x * 5;
            Console.WriteLine(z);
          
            /*Implicit variable, Explicit variable*/
            int b = 0; int y = 0;

            var fullName = "anower ullah";
            var CGPA = 3.27;
            var age = 30;
            Console.WriteLine("My FullName is : {0} and age is:{1}", fullName, age);
            // Note: Implicit variable must assign default value. 

            /* Anonymous Type*/
            var person = new
            {
                firstname = "anower",
                lastname = "ullah",
                age = 30
            };
            Console.WriteLine("My FirstName is : {0} and Second Name is:{1}", person.firstname, person.lastname);

            dynamic testdata = 100;
            testdata = 10.23;
            testdata = "anower";

            /* If else use*/

            int firstNumber = 5;
            int secondNumber = 20;
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("firstnumber {0} is greater than secondnumber{1}:", firstNumber, secondNumber);
            }
            else if (firstNumber == secondNumber)
            {
                Console.WriteLine("firstnumber {0} and secondnumber{1} is equal:", firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("firstnumber {0} is smaller than secondnumber{1}:", firstNumber, secondNumber);
            }

            /*Switch use*/

            double cgpa = 5.00;

            switch (cgpa)
            {
                case 5.00:
                    Console.WriteLine("Excellent");
                    break;
                case 4.50:
                    Console.WriteLine("very good");
                    break;
                case 3.50:
                    Console.WriteLine("Satisfactory");
                    break;
                default:
                    Console.WriteLine("Need to Improve");
                    break;
            }
            /* For use */

            for (int i = 0; i < fullName.Length; i++)
            {
                if (i == 0)
                    Console.WriteLine("Your name firstletter  is :{0} and Name length is {1}" + fullName[i], fullName.Length);




            }
            /* foreach use */
            foreach (var data in fullName)
            {
                Console.WriteLine(data);

            }

// abstract example 

using System;
namespace Abstract
{
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string PhoneNumber { get; set; }

        public abstract void PrintDetails();
    }
    class Student : Person
    {
        public string RollNo { get; set; }
        public float Fees { get; set; }

        public override void PrintDetails()
        {
            Console.WriteLine("Student Name is {0} {1}", FirstName, LastName);
            Console.WriteLine("Student Age is {0} ",  Age);
            Console.WriteLine("Student Phone is {0} ",  PhoneNumber);
            Console.WriteLine("Student Fees is {0}", Fees);
        }
    }
    class Teacher : Person
    {
        public string qualification { get; set; }
        public float salary { get; set; }

        public override void PrintDetails()
        {
            Console.WriteLine("Student Name is {0} {1}", FirstName, LastName);
            Console.WriteLine("Student Age is {0} ", Age);
            Console.WriteLine("Student Phone is {0} ", PhoneNumber);
            Console.WriteLine("Student Fees is {0}", qualification);
            Console.WriteLine("Student Fees is {0}", salary);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Student s = new Student();
            s.FirstName = "Anower";
            s.LastName = "Ullah";
            s.Age = "31";
            s.PhoneNumber = "01822339363";
            s.Fees = 5000;
            s.PrintDetails();
            Console.ReadKey();
        }
    }
}






// Interface example 

using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IAccount
    {
        int getSum(int a, int b);

        void getResult();

        void welcomemsg();

    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Account : IAccount
    {
        public void getResult()
        {
            throw new NotImplementedException();
        }

        public int getSum(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void welcomemsg()
        {
            Console.WriteLine("Hello Welcome");
        }
        public string message()
        {
            return "Hello";
        }

    }
}











//Enum example

using System;
using System.Drawing;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {



            int Day1 = (int)Days.Monday;
            int Day2 = (int)Days.Friday;


            Console.WriteLine("Monday = {0}", Day1);
            Console.WriteLine("Friday = {0}", Day2);
        }
    }
    enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Staurday, Sunday }
}
