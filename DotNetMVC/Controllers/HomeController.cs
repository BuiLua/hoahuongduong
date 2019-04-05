using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstDatabaseProject.Database;
using FirstDatabaseProject.Entities;
using FirstDatabaseProject.Services.Interfaces;
using FirstDatabaseProject.ViewModels;

namespace FirstDatabaseProject.Controllers
{
    public class HomeController : Controller
    {
        #region Khai báo Services khi dùng
        private readonly IBlogService _blogService;
        public HomeController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        #endregion


        public ActionResult Index()
        {
            HomeIndexViewModel viewModel = new HomeIndexViewModel();
            viewModel.ListBlogs = _blogService.GetList();
            return View(viewModel);
        }

        [HttpPost]

        public ActionResult AddNewBlog(Blog blog)
        {
            var result = _blogService.AddNew(blog);
            return Json(new
            {
                isSuccess = result
            });
        }

        [HttpPost]

        public ActionResult UpdateBlog(Blog blog)
        {
            var result = _blogService.Update(blog.BlogId, blog);
            return Json(new
            {
                isSuccess = result
            });
        }


        [HttpPost]

        public ActionResult DeleteBlog(int blogId)
        {
            var result = _blogService.Delete(blogId);
            return Json(new
            {
                isSuccess = result
            });
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            HomeAboutViewModel viewModel = new HomeAboutViewModel()
            {
                NameAuthor = "aaaa",
                Money = 100
            };

            return View(viewModel);
        }
        //day la truyen du lieu vao cac ngan trong gio

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}