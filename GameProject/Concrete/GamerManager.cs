using GameProject.Concrete;
using GameProject.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        private UserValidationManager userValidationManager;

        public GamerManager(UserValidationManager userValidationManager)
        {
            this.userValidationManager = userValidationManager;
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu eklendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu güncellendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu silindi");
        }
    }
}
