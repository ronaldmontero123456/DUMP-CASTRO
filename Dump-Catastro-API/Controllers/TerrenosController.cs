using Dump_Catastro_CORE.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dump_Catastro_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerrenosController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TerrenosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        [HttpGet(Name = nameof(GetLand))]
        public IActionResult GetLand()
        {
            var building = _unitOfWork.VistaTerrenosRepository.GetAll().Take(50).ToList();

            var response = new
            {
                error = false,
                found = true,
                message = "",
                data = building
            };

            return Ok(response);
        }

    }
}
