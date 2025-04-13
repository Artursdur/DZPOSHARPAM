using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZPOSHARPAM
{
    internal class Game
    {
        private string _title;
        private int _avgPlayers;
        private int _maxPlayers;
        private double _rating;


        public double Rating { get; set; }
        public int AveragePlayers { get; set; }
        public int MaxPlayers { get; set; }

        public static Game operator ++(Game g)
        {
            if (g._rating < 10)
                g._rating += 0.1;
            return g;
        }

        public static Game operator --(Game g)
        {
            if (g._rating > 0)
                g._rating -= 0.1;
            return g;
        }
    }

    
}
