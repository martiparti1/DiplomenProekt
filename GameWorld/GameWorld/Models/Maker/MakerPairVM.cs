using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameWorld.Models.Maker
{
    public class MakerPairVM
    {
        public int Id { get; set; }
        [Display(Name="Maker")]
        public string Name { get; set; }
    }
}
