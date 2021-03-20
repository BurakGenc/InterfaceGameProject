using InterfaceGameProject.Abstract;
using InterfaceGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceGameProject.Abstract
{
    abstract class  CampaignManager : ICampaignService
    {
        public void Join(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" Kampanya ile oyunu satin aldi");
        }
    }
}
