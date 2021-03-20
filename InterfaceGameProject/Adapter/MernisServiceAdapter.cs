using InterfaceGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MersisServiceReference;
namespace InterfaceGameProject.Adapter
{
    public class MernisServiceAdapter
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId), gamer.FirstName, gamer.LastName, gamer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
