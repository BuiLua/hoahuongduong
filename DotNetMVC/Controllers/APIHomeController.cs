using FirstDatabaseProject.Models;
using FirstDatabaseProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstDatabaseProject.Controllers
{
    public class APIHomeController : ApiController
    {
        private readonly IBlogService _blogService;
        public APIHomeController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [Route("api/home/get-list-blogs")]

        public IHttpActionResult GetListBlogs()
        {
            var listBlogs = _blogService.GetList();
            var result = new BaseResult()
            {
                Data = listBlogs,
                IsSuccess = true
            };
            return Ok(result);
        }
    }
}
