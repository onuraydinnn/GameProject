using GameProject.Abstract;
using GameProject.Adaptors;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Gamer> gamers = new List<Gamer>();
            List<Campaign> campaigns = new List<Campaign>();
            List<Game> games = new List<Game>();

            gamers.Add(new Gamer { FirstName = "Onur", LastName = "Aydın", DateOfBirth = new DateTime(2001, 8, 20), TcNo = "12345678910", Id = 1 });

            IGamerService gamerManager = new GamerManager(new EdevletServiceAdaptor());
            foreach (var item in gamers)
            {
                gamerManager.Add(item);
            }

            games.Add(new Game { GameName = "The Witcher 3", GamePrice = 300, Id = 1 });

            IGameService gameManager = new GameManager();
            foreach (var item in games)
            {
                gameManager.Add(item);
            }

            campaigns.Add(new Campaign { Id = 1, Name = "Winter Sale", Deadline = new DateTime(2023, 3, 1), DiscountRate = 30 });

            ICampaignService campaignManager = new CampaignManager();
            foreach(var item in campaigns)
            {
                campaignManager.Add(item);
            }


            campaignManager.Sell(gamers[0], games[0], campaigns[0]);

            Console.ReadKey();
        }
    }
}
