using Backend.DTOs;
using Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        IPostsService _postsService;
        public PostsController(IPostsService postsService) => _postsService = postsService;


        [HttpGet("all")]
        public async Task<IEnumerable<PostDto>> Get() => await _postsService.Get();
    }
}
