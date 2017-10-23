using System;
using System.Collections.Generic;
using System.Text;

namespace TooService.Entities
{
    public class Comment : Entity
    {
        public string TsUserId { get; set; }

        public string TargetId { get; set; }

        public CommentOn CommentOn { get; set; }

        public string Content { get; set; }
    }


    public enum CommentOn
    {
        TsService = 0,
        Post = 1
    }
}
