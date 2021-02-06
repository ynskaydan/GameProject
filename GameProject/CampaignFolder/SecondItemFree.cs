using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SecondItemFree : ICampaignManager
    {
        public string Name { get => "Second item is free!"; set => throw new NotImplementedException(); }

        public void DecreasePrice()
        {
            Game game = new Game();
            Console.WriteLine("You are lucky person! You were selected by system randomly and you have gained second item for free!");
            game.UnitPrice /= 2;
        }
    }
}
