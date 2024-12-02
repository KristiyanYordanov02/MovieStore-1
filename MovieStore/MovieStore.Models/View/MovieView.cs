namespace MovieStore.Models.DTO
{
    public class MovieView
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public int Year { get; set; }
    }
}