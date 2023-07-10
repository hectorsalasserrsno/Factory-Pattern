using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class BillyTheVideoGameStore
    {

        public static IVideoGameStore BuySomething(string chose)
        {
            switch (chose)
            {
                case "Silent Hill 2 Remake":

                    return new VideoGames();

                case "Resident Evil X":

                    return new VideoGames();

                case "New Super Mario Odysey Xtreme":

                    return new VideoGames();

                case "Tomb Raider New Figure":

                    return new Collectibles();

                case "Game Of Thrones Chess set":

                    return new Collectibles();

                case "Picachu Plush with sound":

                    return new Collectibles();

                default:

                    return new Collectibles();

            }
        }

    }

}

