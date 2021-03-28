﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Models
{
    public class Shop
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
    }
}
