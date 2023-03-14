using teeeest.Models;

namespace teeeest.DAL
{
    public static class BookRepo
    {
        public static List<Book> Books { get; set; } = new List<Book> { 
            new Book
            {
                Id= 1, Name = "Over Mars", Genre = Genre.SciFi, Serial = "sfsdf453"
            },
            new Book
            {
                Id= 2, Name = "Shah Abbas", Genre = Genre.History, Serial = "sdfdsf54534"
            },
        };
        public static void Add(Book book)
        {
            book.Serial.SerialNormalizer();
            Books.Add(book);
            Console.WriteLine("fdf");
        }


        public static Book Get(int id)
        {
            var book = Books.FirstOrDefault(x => x.Id == id);
            return book;
        }


        public static List<Book> List()
        {
            return Books;
        }


        public static string? SerialNormalizer(this string s)
        {
            if (s is not null)
            {
                string[] listed = s.Split("");
                string result = "";
                foreach (var item in listed)
                {
                    if (!item.Equals(typeof(string)))
                    {
                        continue;
                    }
                    result += item;
                }
                return result;
            };
            return null;
        }
    }
}
