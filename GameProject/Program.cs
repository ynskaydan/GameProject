using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.TcNO = "22222222222";
            gamer1.Name = "Yunus";
            gamer1.LastName = "Kaydan";
            gamer1.Birthday = "22/11/2001";

            Gamer gamer2 = new Gamer();
            gamer2.TcNO = "33333333333";
            gamer2.Name = "Berkay";
            gamer2.LastName = "Guldegirmenci";
            gamer2.Birthday = "03/12/2001";
            ////////////////////////////////
            ///Game
            Game game1 = new Game();
            game1.Name = "GTA 5";
            game1.Description = " Openworld Action game ";
            game1.Player = 0;
            game1.UnitPrice = 80;
            Game game2 = new Game();
            game2.Name = "Battlefield";
            game2.Description = " Battlefront war game ";
            game2.Player = 0;
            game2.UnitPrice = 55;

            GameManager gameManager = new GameManager();
            List<Game> games = new List<Game>() { game1, game2 };


            List<ICampaignManager> campaings = new List<ICampaignManager> { new FirstOrderHalfPriceManager(), new SecondItemFree() };
            CampaignManager campaignManager = new CampaignManager();



            Console.WriteLine("XGame!");
            Console.WriteLine("Welcome! Please write your process number");
            Console.WriteLine("...");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. LogIn");
            Console.WriteLine("3. Update Your User Informations");
            Console.WriteLine("4. Remove user");
            GamerManager gamerManager = new GamerManager();
            List<Gamer> gamers = new List<Gamer>();
            gamers.Add(gamer1);
            gamers.Add(gamer2);
            /////////////////////////////////////////////////////
         
            string pn = Console.ReadLine();
            if (pn == "1")
            {
                gamerManager.Add(gamers);
                gamerManager.ListG(gamers);
            }
            else if (pn == "2")
            {
                gamerManager.LogIn(gamers);
                gamerManager.ListG(gamers);

            }
            else if (pn == "3")
            {
                gamerManager.RemoveGamer(gamers);
                gamerManager.ListG(gamers);
            }
            else
            {
                Console.WriteLine("Please write a valid value");
            }

            Console.WriteLine("Our Games is listed below: ");
            foreach (var game in games)
            {
                Console.WriteLine("Name: " + game.Name + " Game Description: " + game.Description + " Player in game: " + game.Player);
            }


            Console.WriteLine("Which game do you want to purchase? Please write game name: ");
            string input1 = Console.ReadLine();
            for (int i = 0; i < games.Count; i++)
            {
                if (input1 == games[i].Name)
                {

                    gameManager.AddCard(gamer1, games[i]);
                    // games.
                }
                else
                {
                    Console.WriteLine("please write a valid game name!");
                }

                foreach (var game in games)
                {
                    Console.WriteLine("Name: " + game.Name + "Player online: " + game.Player);
                }



                Console.WriteLine("Our campaings are: ");
                foreach (var campaign in campaings)
                {
                    Console.WriteLine(campaign.Name);
                }
               
                Console.WriteLine("Have you any campaing? ");

                string abc = Console.ReadLine();

                for (int a = 0; a < campaings.Count; a++)
                {
                    if (abc == campaings[a].Name)
                    {
                        campaignManager.Decrease(campaings[a]);
                        foreach (var game in games)
                        {
                            Console.WriteLine("Name: " + game.Name + " Price: " + game.UnitPrice);
                        }

                    }
                }




                // Giris yapan oyuncu adina o oyunu yazmak 






            }
        }
    }
}
