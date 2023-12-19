using Carbook.Application.Features.RepositoryPattern;
using Carbook.Persistence.Context;
using CarBook.Domain.Entities;

namespace Carbook.Persistence.Repositories.CommentRepositories
{
    public class CommentRepository<T> : IGenericRepository<Comment>
    {
        private readonly CarBookContext _context;

        public CommentRepository(CarBookContext context)
        {
            _context = context;
        }

        public void Create(Comment item)
        {
            _context.Comments.Add(item);
            _context.SaveChanges();
        }

        public List<Comment> GetAll()
        {
            return _context.Comments.Select(x => new Comment
            {
                BlogId = x.BlogId,
                CommentId = x.CommentId,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                Name = x.Name
            }).ToList();
        }

        public Comment GetById(int id)
        {
            return _context.Comments.Find(id);
        }

        public List<Comment> GetCommentsByBlogId(int id)
        {
            return _context.Set<Comment>().Where(x=>x.BlogId==id).ToList();
        }

        public void Remove(Comment item)
        {
            var value= _context.Comments.Find(item.CommentId);
            _context.Comments.Remove(value);
            _context.SaveChanges();
        }

        public void Update(Comment item)
        {
           _context.Comments.Update(item);
            _context.SaveChanges();
        }
    }
}
