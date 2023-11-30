﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class CarDetailsDto
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ?CarName { get; set; }
        public string ?BrandName { get; set; }
        public string ?ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
