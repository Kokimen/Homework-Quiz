using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Properties;
using GameProject.Services;

namespace GameProject.Concrete

{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " isimli kampanya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " isimli kampanya güncellendi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " isimli kampanya silindi");
        }
    }
}
