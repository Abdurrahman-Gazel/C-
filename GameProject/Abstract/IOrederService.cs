using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IOrederService
    {
        void Order(Gamer gamer, Game game);

        void CampaignOrder(Game game, Gamer gamer, Campaign campaign);
    }
}
