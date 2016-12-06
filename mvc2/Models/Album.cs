using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc2.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }


        public virtual ICollection<> { get; set; }
    }
}