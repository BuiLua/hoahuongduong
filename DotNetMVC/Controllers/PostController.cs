using FirstDatabaseProject.Entities;
using FirstDatabaseProject.Services.Interfaces;
using FirstDatabaseProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstDatabaseProject.Controllers
{
    public class PostController : Controller
    {
        #region khai báo service khi dùng
        private readonly IPostService _postService;
        private readonly IBlogService _blogService;
        public PostController(IPostService postService, IBlogService blogService)
        {
            _postService = postService;
            _blogService = blogService;
        }
        #endregion

        public ActionResult ListPosts(int blogId)
        {
            if (_blogService.Existed(blogId))
            {
                ListPostsViewModel viewModel = new ListPostsViewModel();
                viewModel.ListPosts = _postService.GetList(blogId);
                viewModel.CurrentBlog = _blogService.GetOne(blogId);
                return View(viewModel);
            }
            // không tìm thấy thì trả về not found
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]

        public ActionResult AddNewPost(Post post)
        {
            var result = _postService.AddNew(post);
            return Json(new
            {
                isSuccess = result
            });
        }

        [HttpPost]

        public ActionResult UpdatePost(Post post)
        {
            var result = _postService.Update(post.PostId, post);
            return Json(new
            {
                isSuccess = result
            });
        }


        [HttpPost]

        public ActionResult DeletePost(int postId)
        {
            var result = _postService.Delete(postId);
            return Json(new
            {
                isSuccess = result
            });
        }
    }
}