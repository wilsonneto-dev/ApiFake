using ApiFake.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFake.Repositories
{
    public class CreatorRepository : IRepository<Creator>
    {
        private List<Creator> _creators;
        public CreatorRepository()
        {
            _creators = new List<Creator>();
        }

        public async Task<Creator> Get(Guid id)
        {
            return _creators.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task<IEnumerable<Creator>> GetAll()
        {
            return _creators.ToList();
        }

        public async Task Save(Creator entity)
        {
            _creators.Add(entity);
        }

        public async Task Remove(Guid id)
        {
            var found = _creators.Where(x => x.Id == id).FirstOrDefault();
            if (found == null)
                throw new Exception("Item não encontrado");
            _creators.Remove(found);
        }
        public async Task Update(Creator entity)
        {
            await this.Remove(entity.Id);
            _creators.Add(entity);
        }
    }
}
