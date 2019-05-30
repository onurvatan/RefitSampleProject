using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RefitSampleProject.Services;

namespace RefitSampleProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postService;
        public HomeController(IPostService postService)
        {
            _postService = postService;
        }
        public async Task<IActionResult> Index()
        {
            var post = await _postService.GetPosts();
            return View(post);
        } 

    }
}
