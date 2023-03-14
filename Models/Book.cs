namespace teeeest.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public string Serial { get; set; }

    }
    public enum Genre
    {
        SciFi = 1,
        History = 2,
        Horrot = 3,
    };
}
