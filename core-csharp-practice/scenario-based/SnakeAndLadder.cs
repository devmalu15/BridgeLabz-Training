using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Game
{
    public class SnakeAndLadder
    {
        static int[,] board = new int[10, 10];
        static int player1 = 0;
        static int player2 = 0;
        static int temp = 0;

        static int[] snakeMouths = { 2, 0, 11, 5, 19, 1, 25, 17, 33, 26, 45, 30, 60, 20, 75, 3, 89, 50, 99, 32 };

        public static void Main(String[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("   SNAKE AND LADDER GAME MENU    ");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Play Game");
                Console.WriteLine("2. View Rules");
                Console.WriteLine("3. Exit");
                Console.WriteLine("=================================");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        restartGame(); 
                        play();        
                        break;
                    case "2":
                        Console.WriteLine("\nRules:");
                        Console.WriteLine("- First player to reach 100 wins.");
                        Console.WriteLine("- If you land on a Snake head, you go down to the tail.");
                        Console.WriteLine("\nPress any key to return to menu...");
                        Console.ReadKey();
                        break;
                    case "3":
                        exit = true;
                        Console.WriteLine("Exiting game...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static int rollDice()
        {
            Random random = new Random();
            int number = random.Next(1, 7);
            return number;
        }

        public static void checkSnake()
        {
            for (int i = 0; i < snakeMouths.Length; i = i + 2)
            {
                
                if (player1 == snakeMouths[i])
                {
                    Console.WriteLine($"Oh no! Player 1 bit by snake at {player1}. Sliding down to {snakeMouths[i + 1]}");
                    player1 = snakeMouths[i + 1];
                }

                if (player2 == snakeMouths[i])
                {
                    Console.WriteLine($"Oh no! Player 2 bit by snake at {player2}. Sliding down to {snakeMouths[i + 1]}");
                    player2 = snakeMouths[i + 1];
                }
            }
        }

        public static void movePlayer1()
        {
            int num = rollDice();
            temp = num; 
            Console.WriteLine($"Player 1 rolled a {num}");

            if ((player1 + num) > 100)
            {
                Console.WriteLine("Player 1 needs exact number to win. Turn skipped.");
            }
            else
            {
                player1 = player1 + num;
                checkSnake();
            }
        }

        public static void movePlayer2()
        {
            int num = rollDice();
            temp = num; 
            Console.WriteLine($"Player 2 rolled a {num}");

            if ((player2 + num) > 100)
            {
                Console.WriteLine("Player 2 needs exact number to win. Turn skipped.");
            }
            else
            {
                player2 = player2 + num;
                checkSnake();
            }
        }

        public static void restartGame()
        {
            player1 = 0;
            player2 = 0;
            temp = 0;
            Console.WriteLine("Game has been reset.");
        }

        public static void displayStats()
        {
            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"Current Position -> Player 1: {player1} | Player 2: {player2}");
            Console.WriteLine($"--------------------------------");
        }

        public static void play()
        {
            Console.WriteLine("\n--- Game Started! First to 100 Wins ---");

            bool gameOver = false;

            while (!gameOver)
            {
                
                Console.WriteLine("\nPlayer 1's Turn (Press Enter to Roll)");
                Console.ReadKey();
                movePlayer1();
                displayStats();

                if (player1 == 100)
                {
                    Console.WriteLine("\n**************************");
                    Console.WriteLine("CONGRATULATIONS! Player 1 Wins!");
                    Console.WriteLine("**************************");
                    gameOver = true;
                    break;
                }

               
                Console.WriteLine("\nPlayer 2's Turn (Press Enter to Roll)");
                Console.ReadKey();
                movePlayer2();
                displayStats();

                if (player2 == 100)
                {
                    Console.WriteLine("\n**************************");
                    Console.WriteLine("CONGRATULATIONS! Player 2 Wins!");
                    Console.WriteLine("**************************");
                    gameOver = true;
                }
            }

            Console.WriteLine("\nPress any key to return to the Main Menu...");
            Console.ReadKey();
        }
    }
}