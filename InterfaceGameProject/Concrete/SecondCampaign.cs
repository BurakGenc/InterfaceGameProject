using InterfaceGameProject.Abstract;
using InterfaceGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceGameProject.Concrete
{
    class SecondCampaign:ICampaignService
    {
        public void Join(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " 2. kampanya ile oyunu satin aldi");
        }
    }
}
