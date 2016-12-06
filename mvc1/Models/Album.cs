using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvc1.Models
{
    public class Album
    {
     
        public int ID { get; set; }

        [DisplayName("Album Name ")]
      
       
        public string AlbumName { get; set; }

      
      

     
  

        public virtual List<Photo> Photos { get; set; }
    }
}