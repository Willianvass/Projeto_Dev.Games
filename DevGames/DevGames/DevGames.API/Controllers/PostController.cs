using Microsoft.AspNetCore.Mvc;

namespace DevGames.API.Controllers
{
    [Route("api/boards/{id}/post")]
    [ApiController]
    public class PostController : ControllerBase
    {
        // api/boards/1/post

        [HttpGet]
        public IActionResult GetAll(int id)
        {
            return Ok();
        }
        [HttpGet("{postId}")]// Caso queria ver todas respsotas do Post, mais detalhes
        public IActionResult GetById(int id, int postId)
        {
            return Ok();
        }
    }
    [HttpPost]
    public IActionResult Post(AddPostInputModel model)
    {
        return CreatedAtAction()
    }
}
