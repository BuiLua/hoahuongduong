using FirstDatabaseProject.Database;
using FirstDatabaseProject.Entities;
using FirstDatabaseProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstDatabaseProject.Services.Implements
{
    public class PostService : IPostService
    {
        #region gọi qua service khác, nhưng lần này chưa cần dùng
        private readonly IBlogService _blogService;
        public PostService(IBlogService blogService)
        {
            _blogService = blogService;
        }
        #endregion

        private Post FindByTitle(string postName)
        {
            var context = DatabaseContext.Instance;
            return context.Posts.FirstOrDefault(b => b.Title.Equals(postName));
        }

        private Post FindById(int postId)
        {
            var context = DatabaseContext.Instance;
            return context.Posts.FirstOrDefault(b => b.PostId == postId);
        }


        public bool AddNew(Post post)
        {
            var context = DatabaseContext.Instance;
            try
            {
                var existedPost = FindByTitle(post.Title);
                if (existedPost != null)
                {
                    return false;
                }
                context.Posts.Add(post);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int postId)
        {
            var context = DatabaseContext.Instance;
            try
            {
                var existedPost = FindById(postId);
                if (existedPost == null)
                {
                    return false;
                }
                context.Posts.Remove(existedPost);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Post> GetList(int blogId)
        {
            var context = DatabaseContext.Instance;
            return context.Posts.Where(b => b.BlogId == blogId).ToList();
        }

        public bool Update(int postId, Post newPost)
        {
            var context = DatabaseContext.Instance;
            try
            {
                var existedPost = FindById(postId);
                if (existedPost == null)
                {
                    return false;
                }
                existedPost.Title = newPost.Title;
                existedPost.Content = newPost.Content;
                existedPost.BlogId = newPost.BlogId;
                /*var tempPost = FindByTitle(existedPost.Title);
                if (tempPost != null)
                {
                    return false;
                }*/
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}