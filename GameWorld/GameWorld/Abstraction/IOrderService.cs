using GameWorld.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameWorld.Abstraction
{
    public interface IOrderService
    {
        bool Create(int productId, int quantity);
        bool Create(OrderConfirmVM bindnigModel);
    }
}
