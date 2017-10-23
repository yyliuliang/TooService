using System;
using System.Collections.Generic;
using System.Text;

namespace TooService.Entities
{
    public class Post : Entity
    {
        public string TsServiceId { get; set; }

        public string AuthorId { get; set; }

        public string Title { get; set; }
        
        public string Content { get; set; }

        public int ReadCount { get; set; }

    }
}
