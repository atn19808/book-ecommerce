using Dotnet_Ecom_Razor_1.Data;
using Dotnet_Ecom_Razor_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dotnet_Ecom_Razor_1.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Category Category { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            //CategoryList = _db.Categories.ToList();
        }

        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);    
            _db.SaveChanges();
            TempData["success"] = "Category Created Successfully.";
            return RedirectToPage("Index");
        }
    }
}
