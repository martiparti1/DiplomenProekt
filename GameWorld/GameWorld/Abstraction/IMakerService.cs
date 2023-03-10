using GameWorld.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameWorld.Abstraction
{
    public interface IMakerService
    {
        List<Maker> GetMakers();
        Maker GetMakersById(int makerId);
        List<Product> GetProductsByMaker(int makerId);
    }
}
