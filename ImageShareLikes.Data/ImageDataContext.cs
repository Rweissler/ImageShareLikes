using Microsoft.EntityFrameworkCore;

namespace ImageShareLikes.Data
{
    public class ImageDataContext:DbContext
    {
        private string _connectionString;

        public ImageDataContext(string connectionString)
        {
            connectionString = _connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<Image> images { get; set; }
        public object Image { get; internal set; }
    }
}