using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvc2.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }
        public string Comment { get; set; }
        [NotMapped]
        public HttpPostedFileBase File { get; set; }

        public int AlbumID { get; set; }
        public virtual Album album { get; set; }

    }
}