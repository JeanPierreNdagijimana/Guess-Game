using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int WinNumber, UserNumber;
            string decision1, decision2;
        Rand:
            for (int i = 0; i < 3; i++)
            { 
            Random rand = new Random(DateTime.Now.Millisecond);
            WinNumber = Convert.ToInt32(rand.Next(1, 11));

            Console.WriteLine("Guess a number from 1-10: ");
            UserNumber = int.Parse(Console.ReadLine());

            if (UserNumber == WinNumber)
            {
               // Console.Clear();
                Console.WriteLine("\n\t\t\t\t\t\t Conglatulations, You have won!!!! \n Would you like to play again? y - yes: ");
                    decision1 = Console.ReadLine();
                    if (decision1 == "y")
                    {
                        goto Rand;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\t\t\t\t Thank you for playing");
                        System.Threading.Thread.Sleep(3000);
                    }
                }
            else
            {
                Console.WriteLine("\t\t\t You lost");
            }
            }
            Console.WriteLine(" Your attempts are over. \n Do you want to play again? y - yes: ");
            decision2 = Console.ReadLine();
            if (decision2 == "y")
            {
                goto Rand;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t\t\t\t\t Thank you for playing");
                System.Threading.Thread.Sleep(3000);
            }
        }
    
    }
}
