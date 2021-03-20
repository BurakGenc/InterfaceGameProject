using InterfaceGameProject.Abstract;
using InterfaceGameProject.Adapter;
using InterfaceGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MersisServiceReference;

namespace InterfaceGameProject.Concrete
{
    class GamerManager
    {
        private MernisServiceAdapter mernis;

       public    GamerManager(MernisServiceAdapter mernis)
        {
            this.mernis = mernis;
        }


        public void SaveGamer(Gamer gamer) {
            if (mernis.CheckIfRealGamer(gamer))
            {
                Console.WriteLine(gamer.FirstName+  "   Saved");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
        void Update(Gamer gamer)
        {
            if (mernis.CheckIfRealGamer(gamer))
            {
                Console.WriteLine(gamer.FirstName + "   Updated");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
        void DeleteGamer(Gamer gamer) 
        {
            if (mernis.CheckIfRealGamer(gamer))
            {
                Console.WriteLine(gamer.FirstName + "   Deleted");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
