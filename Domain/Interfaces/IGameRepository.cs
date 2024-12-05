using Application.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IGameRepository
    {
        public VideoGameEntity Create(CreateGameDto input);
        public VideoGameEntity GetAll(int id); 
        public bool Delete(int id);
    }
}
