using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random RN = new Random();
            bool isRunning = true;
            int GuessCount = 0;
            while (isRunning)
            {
                PrintMenu();
                if (int.TryParse(Console.ReadLine(), out int MenuChoice))
                {
                    switch (MenuChoice)
                    {
                        case 1:
                            int EasyMode = RN.Next(1, 21);
                            Console.WriteLine("Easy mode, du får gissa 10 gånger");
                            do
                            {
                                TheNumbersGame(EasyMode);
                                GuessCount++;
                            } while (GuessCount < 10);
                            if(GuessCount == 10)
                            {
                                Console.WriteLine("Ouch, du klarade inte det, bättre lycka nästa gång\nSvaret var {0}",EasyMode);
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                            int MediumMode = RN.Next(1, 51);
                            Console.WriteLine("Du har valt medium svårighetsgrad, du får 5 försök:");
                            do
                            {
                                TheNumbersGame(MediumMode);
                                GuessCount++;
                            } while (GuessCount < 5);
                            if(GuessCount == 5)
                            {
                                Console.WriteLine("Synd! Svaret var {0}, du kan klara detta!",MediumMode);
                                Console.ReadKey();
                            }
                            break;
                        case 3:

                            int HardMode = RN.Next(1, 101);
                            Console.WriteLine("Modigt! Du får 3 chanser, vi får se om du klarar detta, lycka till!");
                            do
                            {
                            TheNumbersGame(HardMode);
                                GuessCount++;
                            } while (GuessCount <= 3);
                            if(GuessCount == 3)
                            {
                            Console.WriteLine("Ajajaj, jag tänkte på {0}, kom du nära?", HardMode);
                            Console.ReadKey();
                            }
                            break;
                        case 4:
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("Du har valt ett nummer utanför menyn, välj 1, 2 eller 3 för att spela eller 4 för att avlsuta");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                    Console.WriteLine("Du måste välja ett giltigt nummer {0} är inte giltigt i menu", MenuChoice);
            }

        }
        private static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till gissa nummret");
            Console.WriteLine("[1]Lätt:\t1-20\n[2]Medium:\t1-50\n[3]Omöjlig?:\t1-100\n[4]Avsluta");
        }

        public static void TheNumbersGame(int RN)
        {
            int userGuess = Convert.ToInt32(Console.ReadLine());
            if(userGuess == RN)
            {
                Console.WriteLine("Grattis! Du klarade det!");
            }
            else if(userGuess > RN)
                Console.WriteLine("Jag tänkte på ett tal som är lägre");
            else if(userGuess < RN)
                Console.WriteLine("Jag tänkte på ett tal som är högre");
        }

    }
}
