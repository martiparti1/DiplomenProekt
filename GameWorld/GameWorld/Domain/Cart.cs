using System.Collections.Generic;

namespace GameWorld.Domain
{
    public class Cart
    {
        public int Id { get; set; }
        public virtual List<CartItem> Items { get; set; }
        public string UserId { get; set; }
    }
}
