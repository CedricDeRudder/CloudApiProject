using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MountainController : Controller
    {
        MountainContext context;
        public MountainController(MountainContext ctxt)
        {
            context = ctxt;
        }

        [HttpGet]
        public List<Mountain> GetMountains(int PageNumber = 0, int PageSize = 5)
        {
            IQueryable<Mountain> query = context.Mountains;

            if (PageSize > 5) PageSize = 5;
            query = query.Skip(PageNumber * PageSize);
            query = query.Take(PageSize);

            return query.ToList();
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetMountain(int id)
        {
            var Mountain = context.Mountains.Find(id);
            if (Mountain == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Mountain);
            }
        }

        [HttpPost]
        public IActionResult AddMountain([FromBody] Mountain newMountain)
        {
            context.Mountains.Add(newMountain);
            context.SaveChanges();
            return Created("", newMountain);
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult DeleteMountain(int id)
        {
            var originalMountain = context.Mountains.Find(id);
            if (originalMountain == null)
            {
                return NotFound();
            }
            context.Mountains.Remove(originalMountain);
            context.SaveChanges();
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateMountain([FromBody] Mountain updateMountain)
        {
            var originalMountain = context.Mountains.Find(updateMountain.Id);
            if (originalMountain == null)
            {
                return NotFound();
            }
            originalMountain.Name = updateMountain.Name;
            originalMountain.Location = updateMountain.Location;
            originalMountain.Height = updateMountain.Height;

            context.SaveChanges();
            return Ok(originalMountain);
        }
    }
}