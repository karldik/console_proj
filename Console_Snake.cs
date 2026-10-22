using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


namespace Console_Snake
{
    class Program
    {
        const int wigth = 20;
        const int height = 20;

        static List<(int x, int y)> snake = new List<(int,int)>();

        static int dx = 1;
        static int dy = 0;

        static void Main()
        {
            Console.CursorVisible = false;
            Console.Clear();
            
            //старт голова,туловище,хвост
            snake.Add((10,10));
            snake.Add((9,10));
            snake.Add((8,10));

            Draw();
        }

        static void Draw()
        {
            for (int i = 0;i < wigth;i++)
            {
                Console.SetCursorPosition(i,0); Console.Write("#");
                Console.SetCursorPosition(i, height - 1); Console.Write("#");
            }

            for (int j = 0;j < height;j++)
            {
                Console.SetCursorPosition(0,j); Console.Write("#");
                Console.SetCursorPosition(wigth-1,j); Console.Write("#");
            }
        }
    }
}