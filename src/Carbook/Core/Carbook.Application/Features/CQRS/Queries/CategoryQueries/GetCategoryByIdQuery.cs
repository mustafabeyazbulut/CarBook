
namespace Carbook.Application.Features.CQRS.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery
    {
        public GetCategoryByIdQuery(int categoryId)
        {
            CategoryId = categoryId;
        }
        public int CategoryId { get; set; }
    }
}
