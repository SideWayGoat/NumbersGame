using System;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Random = new Random();
            bool IsRunning = true;

            do
            {
                PrintMenu();
                if (int.TryParse(Console.ReadLine(), out int MenuChoice))
                {
                    int GuessCount = 0;
                    switch (MenuChoice)
                    {
                        case 1:
                            int EasyMode = Random.Next(1, 21);
                            Console.WriteLine("Easy mode, du får gissa 10 gånger");
                            do
                            {
                                if (GuessCount == 10)
                                {
                                    Console.WriteLine("Ouch, du klarade inte det, bättre lycka nästa gång\nSvaret var {0}", EasyMode);
                                    Console.ReadKey();
                                }
                                TheNumbersGame(EasyMode);
                                GuessCount++;
                            } while (GuessCount <= 10);
                            break;
                        case 2:
                            int MediumMode = Random.Next(1, 51);
                            Console.WriteLine("Du har valt medium svårighetsgrad, du får 5 försök:");
                            do
                            {
                                if (GuessCount == 5)
                                {
                                    Console.WriteLine("Synd! Svaret var {0}, bättre lycka nästa gång!", MediumMode);
                                    Console.ReadKey();
                                }
                                TheNumbersGame(MediumMode);
                                GuessCount++;
                            } while (GuessCount <= 5);
                            break;
                        case 3:
                            int HardMode = Random.Next(1, 101);
                            Console.WriteLine("Modigt! Du får 3 chanser, vi får se om du klarar detta, lycka till!");
                            do
                            {
                                if (GuessCount == 3)
                                {
                                    Console.WriteLine("jag tänkte på {0}, kom du nära?", HardMode);
                                }
                                TheNumbersGame(HardMode);
                                GuessCount++;
                            } while (GuessCount <= 3);
                            break;
                        case 4:
                            Console.WriteLine("Avslutar programmet");
                            IsRunning = false;
                            break;
                        default:
                            Console.WriteLine("Du har valt ett nummer utanför menyn, välj 1, 2 eller 3 för att spela eller 4 för att avlsuta");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                    Console.WriteLine("Du måste välja ett giltigt nummer {0} är inte giltigt i menu", MenuChoice);
            } while (IsRunning);

        }
        public static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till gissa nummret");
            Console.WriteLine("[1]Lätt:\t1-20\n[2]Medium:\t1-50\n[3]Omöjlig?:\t1-100\n[4]Avsluta");
        }

        public static void TheNumbersGame(int RN)
        {
            string UserChoice = Console.ReadLine();
            if (UserChoice.Equals(String.Empty))
                return;
            int userGuess = Convert.ToInt32(UserChoice);
            if (userGuess == RN)
                Console.WriteLine("Grattis! Du klarade det!");
            else if (userGuess > RN)
                Console.WriteLine("Jag tänkte på ett tal som är lägre");
            else if (userGuess < RN)
                Console.WriteLine("Jag tänkte på ett tal som är högre");
        }
    }
}
