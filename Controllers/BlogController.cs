using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2_1_DailyBlogger.Models;

namespace Project2_1_DailyBlogger.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext _context;
        public BlogController(BlogContext context)
        {
            _context = context;
        }
        public IActionResult List()
        {
            IEnumerable<BlogPost> posts = _context.blogPost.Tolist<BlogPost>();
            return View(posts);
        }

        public IActionResult New()
        {
            BlogPost blogPost = new BlogPost();
            return View(blogPost);


        }
    }
}
