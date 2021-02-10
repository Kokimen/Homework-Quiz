using GameProject.Properties;
using GameProject.Services;

namespace GameProject
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            System.Console.WriteLine("Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            System.Console.WriteLine("Silindi");
        }

        public void Update(Campaign campaign)
        {
            System.Console.WriteLine("Güncellendi");
        }
    }
}