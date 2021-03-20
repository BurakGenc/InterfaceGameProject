using InterfaceGameProject.Abstract;
using InterfaceGameProject.Adapter;
using InterfaceGameProject.Concrete;
using InterfaceGameProject.Entities;
using System;

namespace InterfaceGameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // Kampanyalı Oyun Satın al
            SellGame sellGame = new SellGame(new FirstCampaign());
           sellGame.ChooseCampaign(new Gamer() { DateOfBirth = new DateTime(1998, 1, 24), FirstName = "Burak", Id = 1, LastName = "Genç", NationalityId = "23104176916" });


            //Sisteme oyuncu ekle 
            GamerManager gamer = new GamerManager(new MernisServiceAdapter());
            gamer.SaveGamer(new Gamer() { DateOfBirth = new DateTime(1999, 1, 24), FirstName = "Ahmet Okay", Id = 1, LastName = "Akyıldız", NationalityId = "26717398838" });

        }
    }
}
