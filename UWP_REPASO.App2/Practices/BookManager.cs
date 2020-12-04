using System.Collections.Generic;
using UWP_REPASO.App2.Models;

namespace UWP_REPASO.App2.Practices
{
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>
            {
                new Book { BookId = 1, Title = "Vulpate", Author = "Futurum", CoverImage = "/Assets/1.png" },
                new Book { BookId = 2, Title = "Mazim", Author = "Sequiter Que", CoverImage = "/Assets/2.png" },
                new Book { BookId = 3, Title = "Elit", Author = "Tempor", CoverImage = "/Assets/3.png" },
                new Book { BookId = 4, Title = "Mazim", Author = "Sequiter", CoverImage = "/Assets/4.png" },
                new Book { BookId = 5, Title = "Elit", Author = "Que", CoverImage = "/Assets/5.png" }
            };

            return books;
        }                
    }
}
