using FirstDatabaseProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDatabaseProject.Services.Interfaces
{
    public interface IPostService
    {
        /// <summary>
        /// Lấy danh sách post thuộc blog
        /// </summary>
        /// <param name="blogId"></param>
        /// <returns></returns>
        List<Post> GetList(int blogId);

        /// <summary>
        /// Thêm mới post
        /// </summary>
        /// <param name="blogId"></param>
        /// <param name="post"></param>
        /// <returns></returns>
        bool AddNew(Post post);

        /// <summary>
        /// Sửa post
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="newPost"></param>
        /// <returns></returns>
        bool Update(int postId, Post newPost);

        /// <summary>
        /// xoa post
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        bool Delete(int postId);
    }
}
