using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC3.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }

        public int GalleryID { get; set; }


        public virtual ICollection<Gallery> Galleries { get; set; }
    }
}