using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Model;
using BookStore.Reposetory;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookReposetory _bookReposetory = null;
        public BookController()
        {
            _bookReposetory = new BookReposetory();
        }
        public ViewResult GetAllBooks()
        {
            //return _bookReposetory.GetAllBooks();
            return View();

        }public BookModel GetBook(int Id)
        {
            return _bookReposetory.GetBookById(Id);
        }
        public List<BookModel> SearchBook(string bookname, string author)
        {
            return _bookReposetory.SearchBook(bookname, author);
        }

    }
}
