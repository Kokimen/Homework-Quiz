using GameProject.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Services
{
    interface IUserValidationService
    {
        bool CheckUser(Gamer gamer);
    }
           
}
