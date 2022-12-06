using System;
using System.Collections.Generic;
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
            int PlayerOption = 0;
            int AiOption = 0;
            Console.WriteLine("Pick a option");
            string Option = Console.ReadLine(); // Player picks
            if (Option == "Rock" || Option == "R" || Option == "r")
            {
                PlayerOption = 0;
            }
            else if (Option == "Paper" || Option == "P" || Option == "p")
            {
                PlayerOption = 1;
            }
            else if (Option == "Scisors" || Option == "S" || Option == "s")
            {
                PlayerOption = 2;
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }

            //Ai picks
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
                }else
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
            Console.ReadKey();

        }
    }
}
