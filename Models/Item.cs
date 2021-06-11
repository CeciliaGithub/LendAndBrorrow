﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Item
    {
        [Key]
        public int id { get; set; }
        public string  Borrower { get; set; }
        public string Lender { get; set; }
        public string ItemName { get; set; }
    }
}
