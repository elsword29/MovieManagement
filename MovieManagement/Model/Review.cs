﻿namespace MovieManagement.Model
{
    public class Review
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public string Content { get; set; }
    }
}
