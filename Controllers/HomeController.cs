using _PersonalWebsite.Models;
using _PersonalWebsite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _db;

        public HomeController(DataContext db)
        {
            _db = db;
        }

		public async Task<IActionResult> Index()
		{
			var viewModel = new IndexVM
			{
				HomePage = await _db.HomePage.FirstOrDefaultAsync(),
				Intro = await _db.Intro.FirstOrDefaultAsync(),
				Work = await _db.Work.FirstOrDefaultAsync(),
				About = await _db.About.FirstOrDefaultAsync(),
				SocialMedia = await _db.SocialMedia.FirstOrDefaultAsync()
			};

			return View(viewModel);
		}

	}
}
