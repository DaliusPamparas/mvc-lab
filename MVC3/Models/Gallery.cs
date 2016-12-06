using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC3.Models


{
    public class Gallery
    {
        public int GalleryID { get; set; }
        public string GalleryName { get; set; }
        public int AlbumID { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }
        public virtual Album Albums { get; set; }
    }
}