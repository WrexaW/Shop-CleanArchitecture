
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
        public VideoGameEntity Create(int price , string name ,string sabak);
        public VideoGameEntity GetAll(int id); 
        public bool Delete(int id);
        public VideoGameEntity GetAllByName(string name);
    }
}
