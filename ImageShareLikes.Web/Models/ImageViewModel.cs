using System;
using System.Collections.Generic;
using System.Linq;
using ImageShareLikes.Web;
using System.Threading.Tasks;

namespace ImageShareLikes.Web.Models
{
    public class ImageViewModel
    {
        public Image images { get; set; }
        public List<int> ImageViewed { get; set; }

    }
}
