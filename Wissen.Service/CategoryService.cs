using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Wissen.Data;
using Wissen.Model;

namespace Wissen.Service
{
<<<<<<< HEAD

    public interface ICategoryService
    {
        void Insert(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
        void Delete(int id);
        IEnumerable<Category> GetAll();
        IEnumerable<Category> GetAll(Expression<Func<Category, bool>> where);
        Category Find(int id);
        Category Find(Expression<Func<Category, bool>> where);
    }
    public class CategoryService : ICategoryService
    {
=======
    public interface ICategoryService
    {
        void Insert(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
        void Delete(int id);
        IEnumerable<Category> GetAll();
        IEnumerable<Category> GetAll(Expression<Func<Category, bool>> where);
        Category Find(int id);
        Category Find(Expression<Func<Category, bool>> where);
    }
    public class CategoryService : ICategoryService
    {
>>>>>>> ea864b23c481a57cccfc58da7afa2b708e1a67f6
        private readonly IRepository<Category> categoryRepository;
        public CategoryService(IRepository<Category> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Delete(Category entity)
        {
            categoryRepository.Delete(entity);
            categoryRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = categoryRepository.Find(id);
            if (entity != null)
            {
                categoryRepository.Delete(entity);
                categoryRepository.SaveChanges();
            }
<<<<<<< HEAD
=======

>>>>>>> ea864b23c481a57cccfc58da7afa2b708e1a67f6
        }

        public Category Find(int id)
        {
            return categoryRepository.Find(id);
        }

        public Category Find(Expression<Func<Category, bool>> where)
        {
            return categoryRepository.Find(where);
        }

        public IEnumerable<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }

        public IEnumerable<Category> GetAll(Expression<Func<Category, bool>> where)
        {
            return categoryRepository.GetAll(where);
        }

        public void Insert(Category entity)
        {
            categoryRepository.Insert(entity);
            categoryRepository.SaveChanges();
        }

        public void Update(Category entity)
        {
            categoryRepository.Update(entity);
            categoryRepository.SaveChanges();
        }
    }
}
