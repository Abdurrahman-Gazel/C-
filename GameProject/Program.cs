using GameProject.Consrete;
using GameProject.Entity;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "engin", LastName = "demirog", IdentityNumber = 123456 });
            
            Gamer gamer2 = new Gamer
            {
                Id =2,
                FirstName="APO",
                LastName="BEIKR",
                IdentityNumber=1234566,
                BirthYear=1998
            };
            Console.WriteLine(gamer2.FirstName + gamer2.LastName);
            gamerManager.Add(gamer2);
            
            Console.WriteLine( "*********" );

            GameManager gameManager = new GameManager();
            Game game1 = new Game { Id = 4, GameName = "zero hour", GamePrice = 200 };
            Game game2 = new Game { Id = 3, GameName = "red alretd", GamePrice = 150 };

            gameManager.Add(game1);
            gameManager.Update(game2);
            Console.WriteLine("---------------");


            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign { Id = 8, CampaignName = "best Campaign ", DiscountRate = 0.60m};
            Campaign campaign2 = new Campaign { Id =9, CampaignName = "freaks Campaign ", DiscountRate = 0.80m };
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign2);
        }
    }
}
