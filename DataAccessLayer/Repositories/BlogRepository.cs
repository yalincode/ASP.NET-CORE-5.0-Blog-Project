using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {

        public void AddBlog(Blog category)
        {
            using var c = new Context();
            c.Add(category);
            c.SaveChanges();
        }

        public void DeleteBlog(Blog category)
        {
            using var c = new Context();
            c.Remove(category);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            using var c = new Context();
            return c.Blogs.ToList();
        }

        public void UpdateBlog(Blog category)
        {
            using var c = new Context();
            c.Update(category);
            c.SaveChanges();
        }
    }
}
