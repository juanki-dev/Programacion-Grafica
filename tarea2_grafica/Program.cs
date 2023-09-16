using System;

class Program
{
    static void Main(string[] args)
    {
        using (var game = new Game(800, 600))
        {
            game.Run(60.0);
        }
    }
}
