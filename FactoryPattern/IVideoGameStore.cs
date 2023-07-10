using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface IVideoGameStore 
    
    {
        public double Total { get; set; }

        public double Preorder { get; set; }

        public void GameOfTheYear();

    }
    
}
