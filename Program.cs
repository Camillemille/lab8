using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static int promptUserAndReadInteger()
        {
            while(true)
            {


                try
                {
                    Console.WriteLine("Enter a number 1-19");

                    int num = int.Parse(Console.ReadLine());
                    if (num > 0 && num <= 19)
                    {
                        return num;
                    }

                    else

                        throw new IndexOutOfRangeException();
                }

                catch (FormatException)
                {
                    Console.WriteLine("That student does not exist");


                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That is invalid data. (enter a number 1-19)");
                    
                }

            }

        }
        static void Main(string[] args)
        {
            Console.Write("Welcome to our C# class" + (" "));

            string[] students = new string[] { "Andrea", "Anthony", "Brian", "Camille", "Clayton", "Damacious", "David","Evan", "Heather",
                "Jacky", "Johnathan", "Katie", "Levi", "Mauricio", "Nicholas", "Rudy", "SeanO", "Steve", "Ty" };
            string[] favColor = new string[] { "Pink", "Yellow", "Orange", "Blue", "Indigo", "Lilac", "Plum", "Grey", "Rose",
                "Black", "White", "Brown", "Green", "Red", "Turqiose", "Light blue", "Neon yellow", "Neon pink", "Neon green", "Light pink" };
            string[] favFruits = new string[] { "apples", "apples", "pinapples", "oranges", "oranges", "strawberries", "strawberries", "Mangos",
                "bananas", "Mangos", "apples", "pears", "apples", "pinapples", "oranges", "oranges", "apples", "apples" };
            string doAgain;
            bool cont = true;
            while (cont)
            {




                int userInput = promptUserAndReadInteger(); //Stores the number that the user inputs.
                string numericalStudent = students[userInput - 1];
                Console.WriteLine("Student " + userInput + " is " + numericalStudent);
                Console.Write("What would you like to know about " + numericalStudent + "?");
                Console.WriteLine((" ") + "(enter a fruit or color.)");
                string choices = Console.ReadLine().ToLower();

                bool repeat = true;
                while (repeat)
                {

                    if (choices == "color")
                    {
                        Console.WriteLine(numericalStudent + (" ") + "loves" + (" ") + favColor[userInput - 1]);
                        repeat = false;
                    }
                    else if (choices == "fruit" || choices == "fruits")
                    {
                        Console.WriteLine(numericalStudent + (" ") + "loves" + (" ") + favFruits[userInput - 1]);
                        repeat = false;
                    }   
                    else
                    {
                        Console.Write("That data does not exist. Please try again.");
                        Console.WriteLine("(enter a fruit or color)");
                        choices = Console.ReadLine();
                    }
                }
                bool cont2 = true;
                while (cont2)
                {
                    Console.WriteLine("Continue? (y/n)");
                    doAgain = Console.ReadLine().ToLower();

                    if (doAgain == "y")
                    {
                        cont2 = false;
                        

                    }
                    else if (doAgain == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        cont2 = false;
                        cont = false;
                        
                    }else
                    {
                        Console.WriteLine("Invalid input. Try again.");
                    }

                }
                

            }
            Console.ReadLine();




            
        }

    }
}
