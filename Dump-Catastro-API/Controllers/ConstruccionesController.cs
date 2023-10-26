using Dump_Catastro_CORE.Entities;
using Dump_Catastro_CORE.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetTopologySuite.IO;
using Newtonsoft.Json;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
            var geoJsonWriter = new GeoJsonWriter();

            var construcciones = _unitOfWork.VistaConstruccioneRepository.GetAll().Select(vista => new
            {
                Properties = JsonConvert.DeserializeObject<VistaConstruccione>(vista.Properties),
                vista.Type,
                Geometry = JsonConvert.DeserializeObject<GeoJsonPolygon>(geoJsonWriter.Write(vista.Geometry))
            });

            var response = new
            {
                error = false,
                found = true,
                message = "",
                data = construcciones
            };

            return Ok(response);
        }

    }
}
