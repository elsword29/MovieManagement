namespace MovieManagement.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Country { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
