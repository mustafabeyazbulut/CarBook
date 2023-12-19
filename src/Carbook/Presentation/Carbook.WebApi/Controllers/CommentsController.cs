using Carbook.Application.Features.RepositoryPattern;
using CarBook.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _commentRepo;
        public CommentsController(IGenericRepository<Comment> commentRepo)
        {
            _commentRepo = commentRepo;
        }
        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _commentRepo.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            _commentRepo.Create(comment);
            return Ok("Yorum başarıyla eklendi");
        }
        [HttpDelete]
        public IActionResult RemoveComment(int id)
        {
            var value= _commentRepo.GetById(id);
            _commentRepo.Remove(value);
            return Ok("Yorum başarıyla silindi");
        }
        [HttpPut]
        public IActionResult UpdateComment(Comment comment)
        {
            _commentRepo.Update(comment);
            return Ok("Yorum başarıyla güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetComment(int id) {
            var value = _commentRepo.GetById(id);
            return Ok(value);
        }
        [HttpGet("CommentListByBlog")]
        public IActionResult CommentListByBlog(int id)
        {
            var value = _commentRepo.GetCommentsByBlogId(id);
            return Ok(value);
        }
    }
}
