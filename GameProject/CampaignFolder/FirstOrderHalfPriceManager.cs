using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class FirstOrderHalfPriceManager : ICampaignManager
    {
        public string Name { get => "First Order will be half price"; set => throw new NotImplementedException(); }
        public void DecreasePrice()
        {
            Game game = new Game();
            game.UnitPrice /= 2;
            Console.WriteLine("This order is your first order! Thanks for chose us.");
            Console.WriteLine("Congrulations! You have gained %50 price discount!");
        }

    }
}
