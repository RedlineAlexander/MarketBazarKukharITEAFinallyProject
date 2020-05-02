using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketBazarKukharITEAFinallyProject.Models.Interfaces
{
    public interface ICommonEntity
    {
        int Id { get; set; }

        DateTime? Sale { get; set; }

        DateTime? LastSale { get; set; }


    }
}
