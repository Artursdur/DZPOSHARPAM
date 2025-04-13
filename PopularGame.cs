using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    static internal class PopularGame
    {
     
        public static double rating = 8.5;
        public static int avgPlayers = 1000;
        public static int maxPlayers = 10000;

        public static bool CheckPopularity(Game game)
        {
           return game.Rating >= rating && game.AveragePlayers>= avgPlayers && game.MaxPlayers >= maxPlayers;
        }
        
    }
}
