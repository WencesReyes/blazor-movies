namespace BlazorPeliculas.Shared.Entities
{
    public class MovieEntity
    {
        public string Title { get; set; }
        public DateTime LaunchDate { get; set; }
        public string Poster { get; set; }
        public string ShortTitle { 
            get {
                return Title?.Length > 60 ? $"{Title?[..60]}..." : Title;
            } 
        }
    }
}
