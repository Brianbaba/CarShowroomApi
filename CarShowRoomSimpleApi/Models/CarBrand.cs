using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarShowRoomSimpleApi.Models
{
    public class CarBrand
    {
        public int BId { get; set; }

        public string BName { get; set; }

        public string BDetails { get; set; }

        public BodyType BodyType { get; set; }
    }
}