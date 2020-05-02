using MarketBazarKukharITEAFinallyProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketBazarKukharITEAFinallyProject.Models.Entities
{
    public class Departments : ICommonEntity
    {
        [Key] public int DepartmentsId { get; set; }

        public string DepartmentName { get; set; }
        public int Id { get; set; }
        public DateTime? Sale { get; set; }
        public DateTime? LastSale { get; set; }
    }
}
