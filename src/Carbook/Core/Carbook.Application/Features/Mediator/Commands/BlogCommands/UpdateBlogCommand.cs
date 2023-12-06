﻿using MediatR;

namespace Carbook.Application.Features.Mediator.Commands.BlogCommands
{
    public class UpdateBlogCommand:IRequest
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
    }
}
