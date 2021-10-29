using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Shared;

namespace WebApplication1.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenreControllers : ControllerBase
    {
        private readonly ApplicationDBcontext context;
        public GenreControllers(ApplicationDBcontext context)
        {
            this.context = context;
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(Class1 genre)
        {
            context.Add(genre);
            await context.SaveChangesAsync();
            return genre.ID;
        }
    }
}
