using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace TravelAgencyServer.Models
{
    public class TourCategoryContext: DbContext
    {
        public DbSet<TourCategory> categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;UserId=root;Password=root;database=travelagency;");
        }
    }
}
