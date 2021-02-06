using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager
    {
        public void AddCard(Gamer gamer,Game game)
        {
            Console.WriteLine("Succesfully added to card! " + game.Name);
            game.Player += 1;
            //gamer.gamespl.Add(game);
            //foreach (var gamepl in gamer.gamespl)
            //{
              //  Console.WriteLine(gamepl);
           // }

        }
        public void AddCampaing()
        {

        }

        public void AddPlayer()
        {

        }
    }
}
