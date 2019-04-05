using FirstDatabaseProject.Database;
using FirstDatabaseProject.Entities;
using FirstDatabaseProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstDatabaseProject.Services.Implements
{
    public class BlogService : IBlogService
    {
        private Blog FindByName(string blogName)
        {
            var context = DatabaseContext.Instance;
            return context.Blogs.FirstOrDefault(b => b.Name.Equals(blogName));
        }

        private Blog FindById(int blogId)
        {
            var context = DatabaseContext.Instance;
            return context.Blogs.FirstOrDefault(b => b.BlogId == blogId);
        }

        public bool AddNew(Blog blog)
        {
            var context = DatabaseContext.Instance;
            try
            {
                var existedBlog = FindByName(blog.Name);
                if(existedBlog != null)
                {
                    return false;
                }
                context.Blogs.Add(blog);
                context.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool Delete(int blogId)
        {
            var context = DatabaseContext.Instance;
            try
            {
                var existedBlog = FindById(blogId);
                if (existedBlog == null)
                {
                    return false;
                }
                context.Blogs.Remove(existedBlog);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public List<Blog> GetList()
        {
            var context = DatabaseContext.Instance;
            return context.Blogs.ToList();
        }

        public bool Update(int blogId, Blog newBlog)
        {
            var context = DatabaseContext.Instance;
            try
            {
                var existedBlog = FindById(blogId);
                if (existedBlog == null)
                {
                    return false;
                }
                existedBlog.Name = newBlog.Name;
                var tempBlog = FindByName(existedBlog.Name);
                if (tempBlog != null)
                {
                    return false;
                }
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Existed(int blogId)
        {
            return FindById(blogId) != null;
        }

        public Blog GetOne(int blogId)
        {
            return FindById(blogId);
        }
    }
}