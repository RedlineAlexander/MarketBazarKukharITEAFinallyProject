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
    public class ConsumersService : IService<Consumers>
    {
        public BaseRepository<Consumers> Repository { get ; set; }


        public ConsumersService(IteaDbContext dbContext)
        {
            Repository = new BaseRepository<Consumers>(dbContext);
        }
        public void Create(Consumers item)
        {
            Repository.Create(item);
            
           // throw new NotImplementedException();
        }

        public void Delete(int item)
        {
            Repository.Remove(item);
           // throw new NotImplementedException();
        }

        public Consumers FindById(int id)
        {
            return Repository.FindById(id);
            //throw new NotImplementedException();
        }

        public List<Consumers> GetAll()
        {
            return Repository.GetAll().ToList();
           // throw new NotImplementedException();
        }

        public IQueryable<Consumers> GetQuery()
        {
            return Repository.GetAll();
           // throw new NotImplementedException();
        }

        public Consumers Update(int id, Consumers updatedItem)
        {
            Repository.Update(updatedItem);
            return updatedItem;
            //throw new NotImplementedException();
        }
    }
}
