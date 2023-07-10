using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class VideoGames: IVideoGameStore 
    {
        public int NewReleases { get; set; } = 60;
        public int BestSellers { get; set; } = 20;

        public int Clearence { get; set; } = 10;
        public double Total { get ; set ; }
        public double Preorder { get ; set ; }

        public void GameOfTheYear()
        {
            Console.WriteLine("This year, the best game will be zelda Tears Of the Kingdom.");
        }
    }
}
