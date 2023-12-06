using CarBook.Domain.Entities;

namespace Carbook.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        List<Blog> GetLast3BlogsWithAuthors();
    }
}
