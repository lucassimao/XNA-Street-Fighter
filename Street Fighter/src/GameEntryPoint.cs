using System;

namespace Street_Fighter
{
    static class GameEntryPoint
    {
        static void Main(string[] args)
        {
            using (StreetFighterGame game = new StreetFighterGame())
            {
                game.Run();
            }
        }
    }
}

