﻿using System;
using System.Collections.Generic;

namespace QuanLiQuanCafe.Models
{
    public partial class FoodCategory
    {
        public FoodCategory()
        {
            Foods = new HashSet<Food>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Food> Foods { get; set; }
    }
}
