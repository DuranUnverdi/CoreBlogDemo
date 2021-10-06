using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal
    {
        List<Blog> ListAllBlog();
        void AddBlog(Blog blog);
        void DeleteBlog(Blog blog);
        void UpdateBlog(Blog blog);
        Blog GetById(int id);
    }
}
