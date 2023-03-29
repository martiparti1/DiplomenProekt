using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameWorld.Models.Balance
{
    public class BalanceAddVM
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public decimal UserBalance { get; set; }
        public decimal AddBalance { get; set; }

    }
}
