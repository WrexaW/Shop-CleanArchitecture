using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IShopService
    {
        public ShopEntity Bay(int userId , int videoGameId ,int orderCode);
    }
}
