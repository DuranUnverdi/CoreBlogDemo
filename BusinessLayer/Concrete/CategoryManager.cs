using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepo;
        public CategoryManager()
        {
            efCategoryRepo = new EfCategoryRepository();
        }
        public void AddCategory(Category category)
        {
            efCategoryRepo.Insert(category);

        }

        public void DeleteCategory(Category category)
        {
            efCategoryRepo.Delete(category);
        }

        public Category GetById(int id)
        {
            return efCategoryRepo.GetById(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepo.GetListAll();
        }

        public void UpdateCategory(Category category)
        {
            efCategoryRepo.Update(category);
        }
    }
}
