using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " added");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " removed");
        }

        public void Sell(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " bought : "+game.GameName+" - Price("+campaign.Name+") : "+CalculatePrice(game.GamePrice, campaign.DiscountRate));
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " updated");
        }
        public double CalculatePrice(int price, int discountRate)
        {
            return price * (100-discountRate) / 100;
        }
    }
}
