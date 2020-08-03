using BookStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Reposetory
{
    public class BookReposetory
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int Id)
        {
            return DataSource().Where(x => x.Id == Id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string author)
        {
            //return DataSource().Where(x => x.Title == title && x.Author == author).ToList();
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }

    private List<BookModel> DataSource()
    {
        return new List<BookModel>()
        {
            new BookModel(){Id=1, Title="C#", Author="Nilesh" },
            new BookModel(){Id=2, Title="ASP", Author="Nilesh" },
            new BookModel(){Id=3, Title=".netCore", Author="Kumar" },
            new BookModel(){Id=4, Title="SQL", Author="Nilesh" },
            new BookModel(){Id=5, Title="Python", Author="Lohhani" }
        };
    }
    }
}
