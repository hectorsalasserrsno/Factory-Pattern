using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Collectibles: IVideoGameStore
    {
        public bool IsCollectible { get; set; }

        public int NewFigure { get; set; } = 100;

        public bool ClearenceToys { get; set; }
        public double Total { get ; set ; }
        public double Preorder { get ; set; }

        public void GameOfTheYear() 
       {
            Console.WriteLine("Now you can preorder the new The Last Of Us figure of Joel.");
        
       }
    }
}
