using Application.Dto;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class GameRepository : IGameRepository
    {
        public VideoGameEntity Create(CreateGameDto input)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public VideoGameEntity GetAll(int id)
        {
            throw new NotImplementedException();
        }
    }
}
