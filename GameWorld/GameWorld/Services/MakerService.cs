using GameWorld.Abstraction;
using GameWorld.Data;
using GameWorld.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameWorld.Services
{
    public class MakerService : IMakerService
    {
        private readonly ApplicationDbContext _context;

        public MakerService(ApplicationDbContext context)
        { _context = context; }
        public Maker GetMakersById(int makerId)
        {
            return _context.Makers.Find(makerId);
        }
        public List<Maker> GetMakers()
        {
            List<Maker> makers = _context.Makers.ToList();
            return makers;
        }

        public List<Product> GetProductsByMaker(int makerId)
        {
            return _context.Products
                .Where(x => x.MakerId == makerId).ToList();
        }
    }
}
