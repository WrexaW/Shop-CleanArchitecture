using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.dbContext
{
    public class dbContextSQL : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<VideoGameEntity> VideoGames { get; set; }
        public DbSet<ShopEntity> Shops { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=130.185.75.54;Database=Project#C14;Encrypt=false;user id = i3center1561; password = 123");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
