using System.Security.AccessControl;

namespace практическая_9
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Нажмите Enter,  чтобы начать игру");
            ConsoleKey key = Console.ReadKey().Key;

            if (key == ConsoleKey.Enter)
            {
                draw_border();
                Thread thread = new Thread(snakeK.draw_snake );
                thread.Start();
                Thread two_thread = new Thread(snakeK.eat);
                two_thread.Start();
                tab_key();

            }
        }
        static void tab_key()
        {
            while (true)
            {
                snakeK.key = Console.ReadKey().Key;
            }
        }
        static void draw_border()
        {
            char border = 'X';

             string row = new String(border, (int)bord.right); //ширина
            Console.SetCursorPosition(0, 0);
            Console.Write(row);
            Console.SetCursorPosition(0, (int)bord.down - 2); //высота
            Console.Write(row);
            for (int i = 0; i < (int)bord.down - 2; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(border.ToString());
                Console.SetCursorPosition((int)bord.right - 1, i);
                Console.Write(border.ToString());
            }


        }
    }
}