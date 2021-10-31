using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Consrete
{
     class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi :  " + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi :  " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya guncellendi :  " + campaign.CampaignName);
        }
    }

}
