﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.Models
{
    public class Post : BaseModel
    {
     

        public string Title { get; set; }

        public string Content { get; set; }

        public virtual ApplicationUser Autor { get; set; }

        public string AuthorId { get; set; }

    }
}
