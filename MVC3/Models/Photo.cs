using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC3.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }
        public string Comment { get; set; }
        [NotMapped]
        public HttpPostedFileBase File { get; set; }

        public int GalleryID { get; set; }
        public virtual Gallery Gallery { get; set; }

    }
}