using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleEF.Models
{
    public partial class Post
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
