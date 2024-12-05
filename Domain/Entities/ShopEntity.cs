using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ShopEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }
        public int VideoGameId { get; set; }
        public VideoGameEntity VideoGame { get; set; }
        public long Price { get; set; }
        public int OrderCode { get; set; }
    }
}
