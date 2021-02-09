using GameProject.Properties;
using GameProject.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameOrderManager : IGameOrderService
    {
        public void OrderSale(GameOrder gameOrder)
        {
            Console.WriteLine(gameOrder.OrderId + " numaralı sipariş oluşturuldu ve " + gameOrder.OrderName + " isimli oyun satın alındı");
        }
    }
}
