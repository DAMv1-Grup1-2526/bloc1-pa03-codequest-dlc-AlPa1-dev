using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    static void Main()
    {
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Check the dungeon";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 3.";
        const string NameMessage = "Enter a name for your wizard";
        const string NameErrorMessage = "Invalid name, please enter a real one.";

        int op = 0;
        string? wizardName;
        bool validInput;
        Random rnd = new Random();
        int Day;
        long trained;
        string title;

        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);

            validInput = true;
            Day = 1;
            trained = 0;

            try
            {
                op = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }

            if (validInput)
            {
                Console.WriteLine(op);
            }
            else
            {
                Console.WriteLine(InputErrorMessage);
            }
            if (op == 1 && validInput == true)
            {
                validInput = true;
                try
                {
                    Console.WriteLine(NameMessage);
                    wizardName = Console.ReadLine();
                    if (validInput)
                    {
                        Console.WriteLine("Your Name: " + wizardName);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(NameErrorMessage);
                    validInput = false;
                }
                while (Day <= 5)
                {
                    long NumHours = rnd.NextInt64(1, 25);
                    long Power = rnd.NextInt64(1, 11);
                    Console.WriteLine("today you have meditated: " + NumHours + "hours");
                    Console.WriteLine("you won: " + Power + " points today");
                    trained = trained + Power;
                    Console.WriteLine("In total you have: " + trained + " points");

                    Day++;
                }
                if (trained < 20)
                {
                    Console.WriteLine("You have to repeat de second call");
                    title = "Raoden el Elantrí";
                    Console.WriteLine("Your title is: " + title);
                }
                else if (trained >= 20 && trained <= 29)
                {
                    Console.WriteLine("you confuse a wand with a spoon");
                    title = "Zyn el buguejat";
                    Console.WriteLine("Your title is: " + title);
                }
                else if (trained >= 30 && trained < 35)
                {
                    Console.WriteLine("Magic wind caster");
                    title = "Arka nullpointer";
                    Console.WriteLine("Your title is: " + title);
                }
                else if (trained >= 35 && trained < 40)
                {
                    Console.WriteLine("You can cast dragons without set the lab on fire");
                    title = "Elarion de les brases";
                    Console.WriteLine("Your title is: " + title);
                }
                else if (trained >= 40)
                {
                    Console.WriteLine("you are now an Arcane Master");
                    title = "ITB-Wizard el Gris";
                    Console.WriteLine("Your title is: " + title);
                }
            }
            else if (op == 2 && validInput == true)
            {

            }

        } while (op != 0);

    }

}