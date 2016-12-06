using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvc1.Models
{
    public class Photo
    {
        
        public int ID { get; set; }

      
        public string Title { get; set; }

       
        public string ImageName { get; set; }
        [NotMapped]
        public HttpPostedFileBase File { get; set; }
        
        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
    }
}