using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rock == 0;
            //Paper == 1;
            //Scisors == 2;
            int Exit = 0;
            int PlayerOption = 0;
            int AiOption = 0;
            string SOption = "";
            int loop = 1;
            while (Exit == 0)
            {
                while (loop == 1)
                {
                    Console.WriteLine("Pick a option");
                    string Option = Console.ReadLine(); // Player picks
                    if (Option == "Rock" || Option == "R" || Option == "r")
                    {
                        PlayerOption = 0;
                        loop = 0;
                    }
                    else if (Option == "Paper" || Option == "P" || Option == "p")
                    {
                        PlayerOption = 1;
                        loop = 0;
                    }
                    else if (Option == "Scisors" || Option == "S" || Option == "s")
                    {
                        PlayerOption = 2;
                        loop = 0;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option");
                        Console.WriteLine("");
                    }
                }
                loop = 1;
                //Ai picks
                Console.WriteLine("");
                Random rnd = new Random();
                AiOption = rnd.Next(0, 3);
                //check and past the option the ai chosed
                if (AiOption == 0)
                {
                    Console.WriteLine("Rock");
                }
                else if (AiOption == 1)
                {
                    Console.WriteLine("Paper");
                }
                else if (AiOption == 2)
                {
                    Console.WriteLine("Scisors");
                }
                Console.WriteLine("");
                //Wins desicion
                if (AiOption == PlayerOption)
                {

                    Console.WriteLine("Draw");
                }
                else if (AiOption == 0)
                {
                    if (PlayerOption == 1)
                    {
                        Console.WriteLine("You Win");
                    }
                    else
                    {
                        Console.WriteLine("You lose");
                    }
                }
                else if (AiOption == 1)
                {
                    if (PlayerOption == 2)
                    {
                        Console.WriteLine("You Win");
                    }
                    else
                    {
                        Console.WriteLine("You lose");
                    }
                }
                else if (AiOption == 2)
                {
                    if (PlayerOption == 0)
                    {
                        Console.WriteLine("You Win");
                    }
                    else
                    {
                        Console.WriteLine("You lose");
                    }
                }
                Console.WriteLine("");
                while (loop == 1)
                {
                    Console.WriteLine("Exit?");
                    Console.WriteLine("Y/N");
                    SOption = Console.ReadLine(); // Player picks
                    if (SOption == "Y" || SOption == "yes" || SOption == "Yes" || SOption == "y")
                    {
                        loop = 0;
                        Exit = 1;
                        
                    }
                    else if (SOption == "N" || SOption == "n" || SOption == "No" || SOption == "no")
                    {
                        loop = 0;
                        Console.WriteLine("------------------");
                    }
                    else
                    {
                        loop = 1;
                        Console.WriteLine("Error in input");
                        Console.WriteLine("");
                    }
                }
                loop = 1;
            }
            Console.ReadKey();
        }
    }
}
