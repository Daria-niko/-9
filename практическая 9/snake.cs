using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace практическая_9
{
    internal class snakeK
    {
        public static ConsoleKey key;
        public static List<string> snaKe = new List<string>() { "O" };
        public static int eat_col;
        public static int eat_row;
        public static int rrow;
        public static int col;
        public static int len = 1;
        public static string snake = "O";
        public static void draw_snake()
        {
            col = 38;
            rrow = 15;
            bool Harry = true;
            do
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(col, rrow);
                Console.Write(" ");
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        do
                        {
                            Thread.Sleep(250);
                            --col;
                            exit_bord();
                            Console.SetCursorPosition(col, rrow);
                            eat_snake();
                            foreach (var item in snaKe)
                            {
                                Console.WriteLine(item);
                            }
                            Console.SetCursorPosition(col + len, rrow);
                            Console.WriteLine(" ");
                        } while (key != ConsoleKey.RightArrow && key != ConsoleKey.UpArrow && key != ConsoleKey.DownArrow);
                        break;
                    case ConsoleKey.UpArrow:
                        do
                        {
                            Thread.Sleep(250);
                            --rrow;
                            exit_bord();
                            eat_snake();
                            Console.SetCursorPosition(col, rrow);

                            foreach (var item in snaKe)
                            {
                                Console.WriteLine(item);
                            }
                            Console.SetCursorPosition(col, rrow + len);
                            Console.WriteLine(" ");
                        } while (key != ConsoleKey.RightArrow && key != ConsoleKey.LeftArrow && key != ConsoleKey.DownArrow);
                        break;
                    case ConsoleKey.DownArrow:
                        do
                        {
                            Thread.Sleep(250);
                            ++rrow;
                            exit_bord(); 
                            eat_snake();
                            Console.SetCursorPosition(col, rrow);
                            foreach (var item in snaKe)
                            {
                                Console.WriteLine(item);
                            }
                            Console.SetCursorPosition(col, rrow - len);
                            Console.WriteLine(" ");
                        } while (key != ConsoleKey.RightArrow && key != ConsoleKey.LeftArrow && key != ConsoleKey.UpArrow);
                        break;
                    case ConsoleKey.RightArrow:
                        do
                        {
                            Thread.Sleep(250);
                            ++col;
                            exit_bord();
                            eat_snake();
                            Console.SetCursorPosition(col, rrow);
                            foreach (var item in snaKe)
                            {
                                Console.WriteLine(item);
                            }
                            Console.SetCursorPosition(col - len, rrow);
                            Console.WriteLine(" ");
                        } while (key != ConsoleKey.UpArrow && key != ConsoleKey.LeftArrow && key != ConsoleKey.DownArrow);
                        break;
                }
            } while (Harry == true);

        }
        public static void eat()
        {
            Random rnd = new Random();
            eat_col = rnd.Next(1, (int)bord.down);
            eat_row = rnd.Next(1, (int)bord.right);
            Console.SetCursorPosition(eat_col, eat_row);
            Console.Write("&");
        }

        private static void eat_snake()
        {
            if (eat_col == col && eat_row == rrow)
            {
                len++;
                eat_col = 0;
                eat_row = 0;
                snaKe.Add("O");
                foreach (var item in snaKe)
                {
                    Console.WriteLine(item);
                    eat();
                }
            }
        }

        private static void exit_bord()
        {
            if (col == 0 || col == (int)bord.right)
            {
                Console.Clear();
                Environment.Exit(0);
            }
            if (rrow == 0 || rrow == (int)bord.down)
            {
                Console.Clear();
                Environment.Exit(0);
            }
        }
    }
}

