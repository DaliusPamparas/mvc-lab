﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Lab1_3.Models
{
    public class Photo
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
    }
}