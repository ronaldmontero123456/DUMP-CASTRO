using Dump_Catastro_CORE.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dump_Catastro_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConstruccionesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ConstruccionesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = nameof(GetBuilding))]
        public IActionResult GetBuilding()
        {
            var building = _unitOfWork.VistaConstruccioneRepository.GetAll().Take(50).ToList();

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
