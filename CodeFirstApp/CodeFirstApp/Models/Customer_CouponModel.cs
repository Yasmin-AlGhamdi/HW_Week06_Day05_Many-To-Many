﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class Customer_CouponModel
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public CustomerModel Customer { get; set; }

        public int CouponId { get; set; }
        public CouponModel Coupon { get; set; }

    }
}