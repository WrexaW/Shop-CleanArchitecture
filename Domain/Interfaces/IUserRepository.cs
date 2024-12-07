
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        public UserEntity Register(UserEntity input);
        public UserEntity Update(int age , string name , string passwoed , string mobile );
        public bool Delete(int id);
        public string Login(string username, string password);
        public UserEntity ShowProfile(int id);
    }
}
