using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod
{
    class Program
    {
        static void Main(string[] args)
        {


            string firstName;
            string lastName;
            int age;
            string color = "color";
            int siblings;
            string transportation = "transportation";
            string house = "house";
            double value;
            int birthMonth;

            //use enters first name
            Console.WriteLine("Enter your First name.");
            firstName = Console.ReadLine().ToUpper();


            //user enters last name
            Console.WriteLine("Enter your last name.");
            lastName = Console.ReadLine().ToUpper();

            Greetings(firstName, lastName);

            //Console.WriteLine("Greetings " + firstName + " " + lastName + " I will tell you your future. ");
            //Console.WriteLine("");

            ////user enters current age
            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());
            if (age % 2 == 0)
            {
                value = (age * 3);
            }
            else
            {
                value = (age * 2);
            }
            Console.WriteLine("");

            ////user enters 2 digit birth month
            Console.WriteLine("What is your Two digit Birth month?");
            birthMonth = int.Parse(Console.ReadLine());


            if ((birthMonth < 1) || (birthMonth > 12))
            {
                value = 0.00;
            }
            else if ((birthMonth >= 1) && (birthMonth <= 4))
            {
                value = 500000.00;
            }
            else if ((birthMonth >= 5) && (birthMonth <= 8))
            {
                value = 777777.77;
            }
            else if ((birthMonth >= 9) && (birthMonth <= 12))
            {
                value = 1000000000000.00;
            }

            Console.WriteLine("Please choose your favorite ROYGBIV color by typing letter or type help for assiastance ");

            color = Console.ReadLine().ToLower();

            switch (color)
            {

                case "r":
                    Console.WriteLine(" you chose red");
                    transportation = ("a 1967 Shelby GT 500");
                    break;

                case "o":
                    Console.WriteLine("you chose orange");
                    transportation = ("a Zebra");
                    break;

                case "y":
                    Console.WriteLine("you chose yellow");
                    transportation = ("a bike");
                    break;

                case "g":
                    Console.WriteLine(" you chose green");
                    transportation = ("a skateboard");
                    break;

                case "b":
                    Console.WriteLine("you chose blue");
                    transportation = ("a exercise ball");
                    break;

                case "i":
                    Console.WriteLine("you chose indigo");
                    transportation = ("a buggy");
                    break;

                case "v":
                    Console.WriteLine("you chose violet");
                    transportation = ("a pair of skates");
                    break;

                case "help":
                    Console.WriteLine("r=red,o=orange,y=yellow,g=green,b=blue,i=indigo,v=violet please select your favorite ROYGBIV color");
                    color = Console.ReadLine().ToLower();
                    break;


                default:
                    Console.WriteLine("Not a pleasing response");
                    transportation = ("a squeaky shopping cart");
                    break;
            }
            switch (color)
            {

                case "r":
                    Console.WriteLine(" ");
                    transportation = ("a 1967 Shelby GT 500");
                    break;

                case "o":
                    Console.WriteLine("");
                    transportation = ("a Zebra");
                    break;

                case "y":
                    Console.WriteLine("");
                    transportation = ("a bike");
                    break;

                case "g":
                    Console.WriteLine("");
                    transportation = ("a skateboard");
                    break;

                case "b":
                    Console.WriteLine("");
                    transportation = ("a exercise ball");
                    break;

                case "i":
                    Console.WriteLine("");
                    transportation = ("a buggy");
                    break;

                case "v":
                    Console.WriteLine("");
                    transportation = ("a pair of skates");
                    break;


            }
            Console.WriteLine("");

            Console.WriteLine("How many siblings do you have?");
            siblings = int.Parse(Console.ReadLine());
            if (siblings < 0)
            {
                Console.WriteLine("you chose less than 0");
                house = ("in a van down by the river");
            }
            else if (siblings == 0)
            {
                Console.WriteLine("you chose 0");
                house = ("a tent in Alaska");
            }

            else if (siblings == 1)
            {
                Console.WriteLine("you chose 1");
                house = ("a mansion somewhere warm");
            }
            else if (siblings == 2)
            {
                Console.WriteLine("you chose 2");
                house = ("a yellow submarine");
            }
            else if (siblings == 3)
            {
                Console.WriteLine("you chose 3");
                house = ("a log cabin on the moon");
            }
            else if (siblings > 3)
            {
                Console.WriteLine("you chose more than 3");
                house = ("the garage of your parents");
            }

        }
        static void Greetings(string firstName, string lastName)
        {
            Console.WriteLine("Greetings " + firstName + " " + lastName + " I will tell you your fortune.");
        }
        



    }

}











