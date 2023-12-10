using CarBook.Domain.Entities;

namespace Carbook.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        List<Blog> GetLast3BlogsWithAuthors();
        List<Blog> GetAllBlogWithAuthors();
        List<Blog> GetBlogByAuthorId(int id);
        List<Blog> GetAuthorByBlogId(int id); 
    }
}
