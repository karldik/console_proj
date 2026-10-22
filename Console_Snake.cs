using System;


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
            Console.Clear;
            
            //старт голова,туловище,хвост
            snake.Add(10,10);
            snake.Add(9,10);
            snake.Add(8,10);

            while (true)
            {
                
            }
        }
    }
}