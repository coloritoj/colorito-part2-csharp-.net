using System;

namespace colorito_deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* GOAL: 
             * Write a program that allows the user to carry on a basic conversation with a chat bat. 
             * The app will ask the user what they wish to say to the bot.
             * The bot will respond appropriately based upon the following table...
             * 
             * hello = Hi good to see you
             * bye = Good bye!
             * sup = I am good
             * hello there = General Kenobi
             * 
             * Once the app has printed the bot's response, ask the user to say something else to the bot.
             * Keep looping until the user says bye.
             * When the user says bye, respond and end the program.
             * 
             * Additionally, add the following features...
             * 
             * Feature 1: So you don't have to check for upper and lower case strings, find a way to make your input string all lower case.
             * For example, BYE, byE, Bye, bye, and bYE should all get the same response.
             * 
             * Feature 2: If the user enters the same input twice in a row, have the bot respond "I'm sorry but you have already said that".
             * 
             * 
             * 
             * GRADING RUBRIC:
             * 1 point: Ask the user what they want to say to the bot. --- COMPLETE
             * 1 point: Getting user input. --- COMPLETE
             * 1 point: Setting the user input to lowercase. --- COMPLETE
             * 1 point: Responding to the "hello" input correctly. --- COMPLETE
             * 1 point: Responding to the "bye" input correctly. --- COMPLETE
             * 1 point: Responding to the "sup" input correctly. --- COMPLETE 
             * 1 point: Responding to the "hello there" input correctly. --- COMPLETE
             * 1 point: Repeating the process of asking for input after printing the bot's response (unless the user said "bye"). --- COMPLETE
             * 1 point: Ending the program when the user says "bye". --- COMPLETE
             * 1 point: Printing "I'm sorry but you have already said that" if the user enters the same input twice in a row. --- COMPLETE
             */

            string userStatement = "";
            string previousStatement = "";


            do
            {
                Console.WriteLine("What would you like to say to the bot?");
                userStatement = (Console.ReadLine().ToLower());

                if (userStatement == "hello")
                {
                    if (userStatement != previousStatement)
                    {
                        Console.WriteLine("Hi good to see you");
                        previousStatement = userStatement;
                    }
                    else if (userStatement == previousStatement)
                    {
                        Console.WriteLine("I'm sorry but you have already said that");
                    }
                }
                else if (userStatement == "bye")
                {
                    if (userStatement != previousStatement)
                    {
                        Console.WriteLine("Good bye!");
                        previousStatement = userStatement;
                    }
                    else if (userStatement == previousStatement)
                    {
                        Console.WriteLine("I'm sorry but you have already said that");
                    }
                }
                else if (userStatement == "sup")
                {
                    if (userStatement != previousStatement)
                    {
                        Console.WriteLine("I am good");
                        previousStatement = userStatement;
                    }
                    else if (userStatement == previousStatement)
                    {
                        Console.WriteLine("I'm sorry but you have already said that");
                    }
                }
                else if (userStatement == "hello there")
                {
                    if (userStatement != previousStatement)
                    {
                        Console.WriteLine("General Kenobi");
                        previousStatement = userStatement;
                    }
                    else if (userStatement == previousStatement)
                    {
                        Console.WriteLine("I'm sorry but you have already said that");
                    }
                }

            } while (userStatement != "bye");

        }
    }
}
