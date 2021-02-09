using GameProject.Properties;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Services
{
    class MernisUserValidationManager : IUserValidationService
    {
        public bool CheckUser(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(gamer.FirstName, gamer.LastName, gamer.BirthYear, gamer.IdentityNumber);

            throw new NotImplementedException();
        }
    }
}
