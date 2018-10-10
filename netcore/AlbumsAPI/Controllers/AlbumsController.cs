using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlbumsAPI.Repositories;

namespace AlbumsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private readonly IAlbumRepository _albumRepository;

        public AlbumsController(IAlbumRepository albumRepository){
            _albumRepository = albumRepository;

        }

        // GET api/albums
        [HttpGet]
        public ActionResult<IEnumerable<Album>> Get()
        {
            return _albumRepository.GetAll();
        }

        [HttpGet("vowels")]
        public ActionResult<IEnumerable<Album>> GetStartingWithVowel()
        {
            return _albumRepository.GetStartingWithVowel();
        }

        [HttpGet("sortByTitle")]
        public ActionResult<IEnumerable<Album>> GetSortedByTitle()
        {
            return _albumRepository.GetAll().OrderBy((Album arg) => arg.Title).ToList();
        }


        // GET api/albums/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/albums
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/albums/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/albums/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
