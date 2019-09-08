using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reminiscence.Business.Abstractions;

namespace reminiscence.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGalleryService _galleryService;

        public GenresController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetGenres()
        {
            var response = await _galleryService.GetGenres();
            return Ok(response);
        } 
    }
}