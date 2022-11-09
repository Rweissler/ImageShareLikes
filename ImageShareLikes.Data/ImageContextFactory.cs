using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace ImageShareLikes.Data
{
   public class ImageContextFactory : IDesignTimeDbContextFactory<ImageDataContext>
    {
        public ImageDataContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), $"..{Path.DirectorySeparatorChar}ImageShareLikes.Web"))
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true).Build();

            return new ImageDataContext(config.GetConnectionString("ConStr"));
        }
    }
}
