using Altkom.ABC.IServices;
using Altkom.ABC.Models;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Altkom.ABC.FakeServices
{
    public class FakeEntitiesService<TEntity> : IEntitiesService<TEntity>
        where TEntity : Base
    {
        private Faker<TEntity> entityFaker;

        private readonly ICollection<TEntity> entities;

        public FakeEntitiesService(Faker<TEntity> entityFaker)
        {
            this.entityFaker = entityFaker;

            entities = entityFaker.Generate(100);
        }

        public void Add(TEntity entity)
        {
            entities.Add(entity);
        }

        public IEnumerable<TEntity> Get()
        {
            return entities;
        }

        public TEntity Get(int id)
        {
            return entities.SingleOrDefault(p => p.Id == id);
        }

        public void Remove(int id)
        {
            entities.Remove(Get(id));
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
