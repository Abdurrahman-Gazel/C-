using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Consrete
{
    class OrderManager : IOrederService
    {
        public void CampaignOrder(Game game, Gamer gamer, Campaign campaign)
        {
            decimal indirimOranı = game.GamePrice - (game.GamePrice * campaign.DiscountRate);

            Console.WriteLine(" Sayın " + gamer.FirstName + " " + gamer.LastName + " " + campaign.CampaignName + " " + game.GameName + " : Oyununu  " +
               indirimOranı + " TL' ye Satın Aldınız");
        }

        public void Order(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Satın Aldı : " + game.GameName + "  " + game.GamePrice + " TL ");
        }
    }
}
