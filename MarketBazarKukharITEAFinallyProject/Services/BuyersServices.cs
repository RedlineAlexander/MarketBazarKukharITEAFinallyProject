using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MarketBazarKukharITEAFinallyProject.Models.Abstract;
using MarketBazarKukharITEAFinallyProject.Models.Database;
using MarketBazarKukharITEAFinallyProject.Models.Entities;
using MarketBazarKukharITEAFinallyProject.Models.Interfaces;
using MarketBazarKukharITEAFinallyProject.Services.Interfaces;

namespace MarketBazarKukharITEAFinallyProject.Services
{
    public class BuyersServices : IService<Buyers>
    {
        public BaseRepository<Buyers> Repository { get; set; }

        public BuyersServices(IteaDbContext dbContext)
        {
            Repository = new BaseRepository<Buyers>(dbContext);
        }

        public void Create(Buyers item)
        {
            Repository.Create(item);
            //throw new NotImplementedException();
        }

        public void Delete(int item)
        {
            Repository.Remove(item);
            //throw new NotImplementedException();
        }

        public Buyers FindById(int id)
        {
            return Repository.FindById(id);
            //throw new NotImplementedException();
        }

        public List<Buyers> GetAll()
        {
            return Repository.GetAll().ToList();
           // throw new NotImplementedException();
        }

        public IQueryable<Buyers> GetQuery()
        {
            return Repository.GetAll();
           // throw new NotImplementedException();
        }

        public Buyers Update(int id, Buyers updatedItem)
        {
            Repository.Update(updatedItem);
            return updatedItem;
            //throw new NotImplementedException();
        }
    }
}
