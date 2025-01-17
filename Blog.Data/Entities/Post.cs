﻿namespace Blog.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        public User Autor { get; set; }

        public int AutorId { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
