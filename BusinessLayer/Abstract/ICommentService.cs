using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
   public interface ICommentService
    {
        void AddComment(Comment comment);
        //void DeleteCategory(Comment category);
        //void UpdateCategory(Comment category);
        List<Comment> GetList(int id);
        //Comment GetById(int id);
    }
}
