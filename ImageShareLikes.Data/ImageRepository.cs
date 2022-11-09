using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageShareLikes.Data
{
    public class ImageRepository
    {
            private string _connectionString;
            public ImageRepository(string connectionString)
            {
                _connectionString = connectionString;
            }

        public void Add(Image image)
        {
            using var context = new ImageDataContext(_connectionString);
            context.images.Add(image);
            context.SaveChanges();

        }

        public List<Image> GetAll()
        {
            using var context = new ImageDataContext(_connectionString);
            return context.images.OrderByDescending(i => i.DateUploaded).ToList();
        }

        public Image GetImageForId(int Id)
        {
            using var context = new ImageDataContext(_connectionString);
            return context.images.FirstOrDefault(i => i.Id == Id);
        }

        public int GetLikes(int id)
        {
            using var context = new ImageDataContext(_connectionString);
            var image = context.images.FirstOrDefault(i => i.Id == id);
            return image.NumberOfLikes;
        }

        public void Like(int id)
        {
            using var context = new ImageDataContext(_connectionString);
            var image = context.images.FirstOrDefault(i => i.Id == id);
            image.NumberOfLikes++;
            context.SaveChanges();
        }
    }

