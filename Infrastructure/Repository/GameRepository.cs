
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.dbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class GameRepository : IGameRepository
    {
        private dbContextSQL _db;
        public GameRepository(dbContextSQL db)
        {
            _db = db;
        }
        public VideoGameEntity GetAllByName(string name)
        {

            return _db.VideoGames.FirstOrDefault(G => G.Name == name)!;
        }
        public VideoGameEntity Create(int price, string name, string sabak)
        {
            VideoGameEntity entity = new VideoGameEntity()
            {
                Price = price,
                Name = name,
                Sabak = sabak

            };
            _db.VideoGames.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {
           return _db.VideoGames.FirstOrDefault(x => x.Id == id) != null;
        }

        public VideoGameEntity GetAll(int id)
        {
            throw new NotImplementedException();
        }
    }
}
