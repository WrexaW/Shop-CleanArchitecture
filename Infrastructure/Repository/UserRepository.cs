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
    internal class UserRepository : IUserRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public string Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public UserEntity Register(UserEntity input)
        {
            throw new NotImplementedException();
        }

        public UserEntity ShowProfile(int id)
        {
            throw new NotImplementedException();
        }

        public UserEntity Update(UpdateDto input)
        {
            throw new NotImplementedException();
        }
    }
}
