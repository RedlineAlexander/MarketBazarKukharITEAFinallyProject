using MarketBazarKukharITEAFinallyProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketBazarKukharITEAFinallyProject.Models.Entities
{
    public class Deliveries : ICommonEntity
    {
        [Key] public int DeliveryId { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryGoods { get; set; }
        public int Id { get; set; }
        public DateTime? Sale { get; set; }
        public DateTime? LastSale { get; set; }
    }
}
