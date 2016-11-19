using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Lab1_1.Models
{
    public class photo
    {
       public Guid ID { get; set; }
       public string Name { get; set; }
       public string Description { get; set; }
       public string Url { get; set; }
    }
}