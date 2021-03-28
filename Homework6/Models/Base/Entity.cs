﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Models.Base
{
    public class Entity
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        //public Shop shop { get; set; }

        public int ShopId { get; set; }

    }
}
