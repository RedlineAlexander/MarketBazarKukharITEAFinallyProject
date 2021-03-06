﻿using MarketBazarKukharITEAFinallyProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketBazarKukharITEAFinallyProject.Models.Entities
{
    public class Buyers : ICommonEntity
    {
        [Key] public int BuyersId { get; set; }
        public string BuyersName { get; set; }
        public string BuyersGoodBuy { get; set; }
        public List<Consumers> Consumers { get; set; }
        public int Id { get; set; }
        public DateTime? Sale { get; set; }
        public DateTime? LastSale { get; set; }


    }
}