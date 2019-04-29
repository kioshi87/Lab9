using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Kim Stevens", "Barry Ball", "Hillary Jones", "Joshua Holt", "Melanie Hall" };
            List<string> hometowns = new List<string> { "Detroit, MI", "Lansing, MI", "Pontiac, MI", "Boston, MA", "Houston,TX" };
            List<string> favoritefoods = new List<string> { "coney dog", "cheeseburger", "funnel cake", "peanuts", "crawfish" };
            List<string> colors = new List<string> { "blue", "orange", "purple", "gray", "black" };
            List<string> studentDataChoices = new List<string> { "hometown", "favorite food", "color" };

            char continueChoice;
            do
            {
                try
                {
                    Console.Write("Which student would you like to learn more about? (Enter a number 0-4): ");
                    string userInput = Console.ReadLine();
                    int studentChoice = int.Parse(userInput);

                    if (studentChoice <= 4)
                    {
                        Console.Write($"Student {userInput} is {names[studentChoice]}. What would you like to know about {names[studentChoice]}? (enter hometown, favorite food or color): ");
                        string dataChoice = Console.ReadLine();

                            if (dataChoice.Equals("color"))
                            {
                                Console.WriteLine($"{names[studentChoice]} likes {colors[studentChoice]}. ");
                            }
                            if (dataChoice.Equals("hometown"))
                            {
                                Console.WriteLine($"{names[studentChoice]} likes {hometowns[studentChoice]}. ");
                            }
                        if (dataChoice.Equals("favorite food"))
                        {
                            Console.WriteLine($"{names[studentChoice]} likes {favoritefoods[studentChoice]}. ");
                        }
                        else
                        {
                      
                            Console.WriteLine("That data does not exist.Please try again.");
                        }
                    }
                    
                    Console.Write("Would you lke to know more? (y/n): ");
                    continueChoice = char.Parse(Console.ReadLine().ToUpper());
                }
                catch (Exception)
                {

                    throw;
                }

            } while (continueChoice.Equals(char.Parse("Y")));

            Console.WriteLine("Thanks");
            Console.ReadKey();
        }
    }
}
