using MarketBazarKukharITEAFinallyProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarketBazarKukharITEAFinallyProject.Models.Entities
{
    public class Consumers : ICommonEntity
    {
        [Key] public int ConsumersId { get; set; }

        public string ConsumerName { get; set; }
        public string ConsumerGood { get; set; }
        public string ConsumerPavilyon { get; set; }
        public int Id { get; set; }
        [ForeignKey("BuyersId")] public Buyers Buyers { get; set; }
        public DateTime? Sale { get; set; }
        public DateTime? LastSale { get; set; }
    }
}
