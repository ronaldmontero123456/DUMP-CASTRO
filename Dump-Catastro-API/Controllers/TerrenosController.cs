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

            var geoJsonWriter = new GeoJsonWriter();

            IQueryable<VistaCatastro> resulttoselect = _unitOfWork.VistaCatastroRepository.GetAll();

            var terrenos = resulttoselect.Select(vista => new
            {
                Properties = JsonConvert.DeserializeObject<VistaTerreno>(vista.Properties),
                vista.Type,
                Geometry = JsonConvert.DeserializeObject<GeoJsonPolygon>(geoJsonWriter.Write(vista.Geometry))
            });

            var response = new
            {
                error = false,
                found = true,
                message = "",
                data = terrenos
            };

            return Ok(response);
        }

    }
}
