using FirstDatabaseProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDatabaseProject.Services.Interfaces
{
    public interface IBlogService
    {
        /// <summary>
        /// Lấy danh sách blog
        /// </summary>
        /// <returns></returns>
        List<Blog> GetList();

        /// <summary>
        /// Thêm mới blog
        /// </summary>
        /// <param name="blog"></param>
        /// <returns></returns>
        bool AddNew(Blog blog);

        /// <summary>
        /// Lưu thay đổi blog
        /// </summary>
        /// <param name="blogId"></param>
        /// <param name="newBlog"></param>
        /// <returns></returns>
        bool Update(int blogId, Blog newBlog);

        /// <summary>
        /// xóa blog
        /// </summary>
        /// <param name="blogId"></param>
        /// <returns></returns>
        bool Delete(int blogId);

        /// <summary>
        /// kiểm tra sự tồn tại của blog
        /// </summary>
        /// <param name="blogId"></param>
        /// <returns></returns>
        bool Existed(int blogId);

        /// <summary>
        /// Lấy thông tin của blg dựa vào Id
        /// </summary>
        /// <param name="blogId"></param>
        /// <returns></returns>
        Blog GetOne(int blogId);
    }
}
