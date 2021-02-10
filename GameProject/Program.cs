using GameProject.Concrete;
using GameProject.Properties;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "Burak", LastName = "Koktay", BirthYear = 1994, IdentityNumber = 101010 });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { Id = 1, Name = "Yaz İndirimi", Detail = "20 Ağustosa Kadar %50 İndirim" });

            GameOrderManager gameOrderManager = new GameOrderManager();
            gameOrderManager.OrderSale(new GameOrder { OrderId = 1, OrderName = "GTA V" });


        }

       
    }
}
