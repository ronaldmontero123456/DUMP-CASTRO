using Dump_Catastro_CORE.Entities;
using Dump_Catastro_CORE.Interfaces;
using Dump_Catastro_INFRASTRUCTURE.Data;
using Dump_Catastro_INFRASTRUCTURE.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using Newtonsoft.Json;
using Npgsql;
using NpgsqlTypes;
using System.Data;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dump_Catastro_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SearchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet(Name = nameof(GetSearch))]
        public IActionResult GetSearch(string query, string type)
        {
            List<string> codigos = new ();

            var geoJsonWriter = new GeoJsonWriter();

            switch (type)
            {
                case "1":
                    var terrenos1 = _unitOfWork.VistaCatastroRepository.Search(vista => vista.Nombre.ToUpper().Contains(query.ToUpper()) || vista.Codigo.ToUpper().Contains(query.ToUpper())).Select(vista => new
                    {
                        Properties = JsonConvert.DeserializeObject<VistaTerreno>(vista.Properties),
                        vista.Type,
                        Geometry = JsonConvert.DeserializeObject<GeoJsonPolygon>(geoJsonWriter.Write(vista.Geometry))
                    });

                    var construcciones1 = _unitOfWork.VistaConstruccioneRepository.Search(c => c.Codigo == query).Select(vista => new
                    {
                        Properties = JsonConvert.DeserializeObject<VistaConstruccione>(vista.Properties),
                        vista.Type,
                        Geometry = JsonConvert.DeserializeObject<GeoJsonPolygon>(geoJsonWriter.Write(vista.Geometry))
                    });

                    var response1 = new
                    {
                        error = false,
                        found = true,
                        message = "",
                        data = new { terrenos = terrenos1, construcciones = construcciones1 }
                    };

                    return Ok(response1);
                case "2":

                    IQueryable<VistaCatastro> resulttoselect = _unitOfWork.VistaCatastroRepository.Search(vista => vista.Nombre.ToUpper().Contains(query.ToUpper()) || vista.Codigo.ToUpper().Contains(query.ToUpper()));

                    var terrenos2 = resulttoselect.Select(vista => new
                    {
                        Properties = JsonConvert.DeserializeObject<VistaTerreno>(vista.Properties),
                        vista.Type,
                        Geometry = JsonConvert.DeserializeObject<GeoJsonPolygon>(geoJsonWriter.Write(vista.Geometry))
                    });

                    codigos = resulttoselect.Select(vista => vista.Codigo).ToList();
                    var construcciones2 = _unitOfWork.VistaConstruccioneRepository.Search(c => codigos.Contains(c.Codigo)).Select(vista => new
                    {
                        Properties = JsonConvert.DeserializeObject<VistaConstruccione>(vista.Properties),
                        vista.Type,
                        Geometry = JsonConvert.DeserializeObject<GeoJsonPolygon>(geoJsonWriter.Write(vista.Geometry))
                    });

                    var response2 = new
                    {
                        error = false,
                        found = true,
                        message = "",
                        data = new { terrenos = terrenos2, construcciones = construcciones2 }
                    };


                    return Ok(response2);
                case "3":

                    bool isvalid = int.TryParse(query, out int result);

                    if (!isvalid)
                    {
                        return BadRequest("Favor de enviar un valor numerico");
                    }

                    List<VistaCatastro> resulttoselect1 = _unitOfWork.VistaCatastroRepository.Search(vista => vista.Documento == result).ToList();

                    var terrenos3 = resulttoselect1.Select(vista => new
                    {
                        Properties = JsonConvert.DeserializeObject<VistaTerreno>(vista.Properties),
                        vista.Type,
                        Geometry = JsonConvert.DeserializeObject<GeoJsonPolygon>(geoJsonWriter.Write(vista.Geometry))
                    });

                    codigos = resulttoselect1.Select(vista => vista.Codigo).ToList();


                    var construcciones3 = _unitOfWork.VistaConstruccioneRepository.Search(c => codigos.Contains(c.Codigo)).Select(vista => new
                    {
                        Properties = JsonConvert.DeserializeObject<VistaConstruccione>(vista.Properties),
                        vista.Type,
                        Geometry = JsonConvert.DeserializeObject<GeoJsonPolygon>(geoJsonWriter.Write(vista.Geometry))
                    });

                    var response3 = new
                    {
                        error = false,
                        found = true,
                        message = "",
                        data = new { terrenos = terrenos3, construcciones = construcciones3 }
                    };

                    return Ok(response3);
                default:

                    var building = _unitOfWork.VistaTerrenosRepository.GetAll().Select(t => t.Codigo).ToList();

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
}
