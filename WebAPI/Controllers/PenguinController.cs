using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/penguins")]
    [ApiController]
    public class PenguinController : Controller
    {
        private readonly IPenguinRepository _penguinList;
        public PenguinController(IPenguinRepository penguinRepository)
        {
            _penguinList = penguinRepository ??
                throw new ArgumentNullException(nameof(penguinRepository));
        }

        [HttpGet()]
        public IActionResult GetPenguins()
        {
            var penguinsFromMock = _penguinList.GetPenguins();
            return Ok(penguinsFromMock);
        }

        [HttpGet("{penguinId}")]
        public IActionResult GetPenguin(Guid penguinId)
        {
            var penguinsFromMock = _penguinList.GetPenguin(penguinId);
            if (penguinsFromMock == null)
            {
                return NotFound();
            }

            return Ok(penguinsFromMock);
        }
    }
}
