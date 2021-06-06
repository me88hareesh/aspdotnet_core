using RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPages.Services
{
    public class BookRepo : IBookRepo
    {
        List<Book> lstBook = new List<Book>();
        public List<Book> GetAllBooks()
        {
            lstBook = new List<Book>()
            {
                new Book{BookId=1,BookName="Book1",NoOfPages=100,Price=25,AuthorName="AuthorA",BookCategory=BCategory.Suspense,
                CoverPage="suspense.jpg",Description="Book1 details"},
                new Book{BookId=2,BookName="Book2",NoOfPages=200,Price=50,AuthorName="AuthorB",BookCategory=BCategory.Romance ,
                CoverPage="romance.jpg",Description="Book2 details"},
                new Book{BookId=3,BookName="Book3",NoOfPages=300,Price=80,AuthorName="AuthorC",BookCategory=BCategory.Fiction ,
                CoverPage="fiction.jpg",Description="Book3 details"},
                new Book{BookId=4,BookName="Book4",NoOfPages=400,Price=150,AuthorName="AuthorD",BookCategory=BCategory.Classics ,
                CoverPage="classic.jpg",Description="Book4 details"},
                new Book{BookId=5,BookName="Book5",NoOfPages=500,Price=170,AuthorName="AuthorE",BookCategory=BCategory.Business,
                CoverPage="business.jpg",Description="Book5 details"},
                new Book{BookId=6,BookName="Book6",NoOfPages=350,Price=120,AuthorName="AuthorG",BookCategory=BCategory.Travel,
                CoverPage="travel.jpg",Description="Book6 details"},

            };

            return lstBook;
            
        }
    }


}
