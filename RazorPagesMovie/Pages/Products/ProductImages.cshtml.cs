using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Products
{
    public class ProductImagesModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;
        private IHostingEnvironment _ihostingEnvironment;

        public  ProductImagesModel(RazorPagesMovie.Data.RazorPagesMovieContext context, IHostingEnvironment ihostingEnvironment)
        {
            _context = context;
            _ihostingEnvironment = ihostingEnvironment;
        }


        public IEnumerable<RazorPagesMovie.Models.Product> productList { get; set; }
        //List<RazorPagesMovie.Models.Product> productList = new List<Models.Product>();//if we use this ,dropdown won't work
        public async Task OnGet()
        {
 
            productList = await _context.Product.ToListAsync();
            //ViewBag.ListOfProducts = 
        }

        ProductImages prodImgs;
        public async Task<IActionResult> OnPostAsync(IFormFile []photos)
        {
            prodImgs = new ProductImages();
            if (!ModelState.IsValid)
            {
                return Page();
            }

            foreach(var photo in photos)
            {
                var path = Path.Combine(_ihostingEnvironment.WebRootPath, "images", photo.FileName);
                var stream = new FileStream(path, FileMode.Create);
                await photo.CopyToAsync(stream);
                prodImgs = new ProductImages();
                prodImgs.ImagePath = "images/"+photo.FileName;
                prodImgs.ProductID = 1;
                //_context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.ProductImages ON");
                _context.ProductImages.Add(prodImgs);

          

            }

            await _context.SaveChangesAsync();
            return RedirectToPage("/Products/ProductImages");

        }


        [BindProperty]
        public RazorPagesMovie.Models.ProductImages ProductImages { get; set; }
    }
}