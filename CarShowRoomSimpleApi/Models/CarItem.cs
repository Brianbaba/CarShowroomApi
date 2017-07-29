using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarShowRoomSimpleApi.Models
{
    public class CarItem
    {
            public int Id { get; set; }

            public float Price { get; set; }

            public CarBrand CarBrand { get; set; }
        }
}
