using System;
namespace RussianRoulette
{
    class PlayRussianRoulette
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Russian Roulette! ");
            Console.WriteLine("First player pulls the trigger:");
            Console.ReadLine();
            Random rnd = new Random();
            byte min = 1;
            byte max = 6;
            int randombyte = rnd.Next(min, max);
            if (randombyte == 1)
            {
                Console.WriteLine("Bang!");
                Console.WriteLine("First Player is dead.");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Miss!");
                Console.WriteLine("Second player pulls the trigger:");
                Console.ReadLine();
                randombyte = rnd.Next(1,5);
                if (randombyte == 1)
                {
                    Console.WriteLine("Bang!");
                    Console.WriteLine("Second Player is dead.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Miss!");
                    Console.WriteLine("First Player pulls the trigger:");
                    Console.ReadLine();

                    randombyte = rnd.Next(1, 4);
                    if (randombyte == 1)
                    {
                        Console.WriteLine("Bang!");
                        Console.WriteLine("First Player is dead.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Miss!");
                        Console.WriteLine("Second player pulls the trigger:");
                        Console.ReadLine();
                        randombyte = rnd.Next(1, 3);
                        if (randombyte == 1)
                        {
                            Console.WriteLine("Bang!");
                            Console.WriteLine("Second player is dead.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Miss!");
                            Console.WriteLine("First player pulls the trigger for %50 chance!!!");
                            Console.ReadLine();
                            randombyte = rnd.Next(1, 2);
                            if (randombyte == 1)
                            {
                                Console.WriteLine("Bang!");
                                Console.WriteLine("First player is dead.");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Miss?!?!?");
                                Console.WriteLine("5 Miss, Game is Over. First Player WINS! Now second player will suicide:");
                                Console.ReadLine();
                                Console.WriteLine("Bang!");

                            }
                        }
                    }
                }
            }
        }
    }
}
