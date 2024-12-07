using Application.Dto;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    internal class GameService 
    {
        private IGameRepository _gadb;
        public GameService(IGameRepository gameRepository)
        {
            _gadb = gameRepository;
        }
    
        public VideoGameEntity Create(CreateGameDto input)
        {
            try
            {
                var NameAll = _gadb.GetAllByName(input.Name);
                if (NameAll != null)
                {
                   throw new Exception("این بازی دا از قبلا وجود داره با این اسم");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            return _gadb.Create(input.Price , input.Name , input.Sabak);
        }
        public VideoGameEntity Delete(int id)
        {
            return _gadb.GetAll(id);
        }
    }
}
