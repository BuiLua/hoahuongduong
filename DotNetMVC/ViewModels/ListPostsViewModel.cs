using FirstDatabaseProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstDatabaseProject.ViewModels
{
    public class ListPostsViewModel
    {
        public Blog CurrentBlog { get; set; }
        public List<Post> ListPosts { get; set; }
    }
}