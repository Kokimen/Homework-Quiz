using GameProject.Properties;
using GameProject.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool CheckUser(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="Burak" && gamer.LastName=="Koktay" && gamer.BirthYear==1994 && gamer.IdentityNumber==101010)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
