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
    public interface IPostService
    {
        void Insert(Post entity);
        void Update(Post entity);
        void Delete(Post entity);
        void Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAll(Expression<Func<Post, bool>> where);
        Post Find(int id);
        Post Find(Expression<Func<Post, bool>> where);
    }
    public class PostService : IPostService
    {
        private readonly IRepository<Post> postRepository;
        public PostService(IRepository<Post> postRepository)
        {
            this.postRepository = postRepository;
        }
        public void Delete(Post entity)
        {
            postRepository.Delete(entity);
            postRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = postRepository.Find(id);
            if (entity!=null)
            {
                postRepository.Delete(entity);
                postRepository.SaveChanges();
            }
        }

        public Post Find(int id)
        {
            return postRepository.Find(id);
        }

        public Post Find(Expression<Func<Post, bool>> where)
        {
            return postRepository.Find(where);
        }

        public IEnumerable<Post> GetAll()
        {
            return postRepository.GetAll();
        }

        public IEnumerable<Post> GetAll(Expression<Func<Post, bool>> where)
        {
            return postRepository.GetAll(where);
        }

        public void Insert(Post entity)
        {
            postRepository.Insert(entity);
            postRepository.SaveChanges();
        }       

        public void Update(Post entity)
        {
            postRepository.Update(entity);
            postRepository.SaveChanges();
        }
    }
}
