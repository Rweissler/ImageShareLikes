using System;

namespace ImageShareLikes.Data
{
    public class Image
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public DateTime DateUploaded { get; set; }
        public int NumberOfLikes { get; set; }
    }
}
