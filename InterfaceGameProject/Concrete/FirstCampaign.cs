using InterfaceGameProject.Abstract;
using InterfaceGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceGameProject.Concrete
{
    class FirstCampaign:ICampaignService
    {
        public void Join(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " 1. kampanya ile oyunu satin aldi");
        }
    }
}
