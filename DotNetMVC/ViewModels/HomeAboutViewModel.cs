using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstDatabaseProject.Entities;

namespace FirstDatabaseProject.ViewModels
{
    public class HomeAboutViewModel
    {
        public string NameAuthor { get; set; }
        public int Money { get; set; }
        public List<Blog> ListBlogs { get; set; }
    }
}

//day chinh la cai gio ( gio nay co 2 ngan)