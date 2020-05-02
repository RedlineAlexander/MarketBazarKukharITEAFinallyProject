using MarketBazarKukharITEAFinallyProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketBazarKukharITEAFinallyProject.Models.Entities
{
    public class Pavilyons : ICommonEntity
    {
        [Key] public int PavilyonsId { get; set; }
        public string PavilyonsName { get; set; }
        public string PavilyonsGoods { get; set; }
        public int Id { get; set; }
        public DateTime? Sale { get; set; }
        public DateTime? LastSale { get; set; }
    }
}
