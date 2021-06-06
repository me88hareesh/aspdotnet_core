using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using RazorPages.Services;

namespace RazorPagesMovie.Pages.BookLibrary
{
    public class IndexModel : PageModel
    {
        IBookRepo _iBookrepo;
        public List<Book> lstBooks { get; set; }

        public IndexModel(IBookRepo ibookRepo)
        {
            _iBookrepo = ibookRepo;
        }
        public void OnGet()
        {

            lstBooks = _iBookrepo.GetAllBooks();


        }
    }
}
