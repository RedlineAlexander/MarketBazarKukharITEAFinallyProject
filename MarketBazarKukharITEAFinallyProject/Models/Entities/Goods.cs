using MarketBazarKukharITEAFinallyProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketBazarKukharITEAFinallyProject.Models.Entities
{
    public class Goods : ICommonEntity
    {
        [Key] public int GoodsId { get; set; }

        public string GoodsCategory { get; set; }
        public string GoodsName { get; set; }
        public string GoodsPavylyons { get; set; }
        public int Id { get; set; }
        public DateTime? Sale { get; set; }
        public DateTime? LastSale { get; set; }
    }
}
