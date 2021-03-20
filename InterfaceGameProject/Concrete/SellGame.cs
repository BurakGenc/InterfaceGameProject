using InterfaceGameProject.Abstract;
using InterfaceGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceGameProject.Concrete
{
    public class SellGame
    { 
       private ICampaignService campaignService;
        public SellGame(ICampaignService campaignService)
        {
            this.campaignService = campaignService;
        }
        public void ChooseCampaign(Gamer gamer)
        {
            campaignService.Join(gamer);
        }
    }
}
