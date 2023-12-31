﻿using Carbook.Application.Interfaces.BlogInterfaces;
using Carbook.Persistence.Context;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carbook.Persistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarBookContext _context;
        public BlogRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Blog> GetAllBlogWithAuthors()
        {
            var values = _context.Blogs.Include(x => x.Author).Include(x => x.Category).ToList();
            return values;
        }
        public List<Blog> GetBlogByAuthorId(int id)
        {
            var values=_context.Blogs.Include(x => x.Author).Where(y=>y.AuthorId==id).ToList();
            return values;
        }
        public List<Blog> GetAuthorByBlogId(int id)
        {
            var values = _context.Blogs.Include(x => x.Author).Where(y => y.BlogId == id).ToList();
            return values;
        }

        public List<Blog> GetLast3BlogsWithAuthors()
        {
            var values= _context.Blogs.Include(x=>x.Author).OrderByDescending(x=>x.BlogId).Take(3).ToList();
            return values;
        }
    }
}
