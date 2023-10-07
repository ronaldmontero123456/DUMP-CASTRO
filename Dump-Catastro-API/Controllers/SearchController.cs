using Dump_Catastro_CORE.Entities;
using Dump_Catastro_CORE.Interfaces;
using Dump_Catastro_INFRASTRUCTURE.Data;
using Dump_Catastro_INFRASTRUCTURE.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
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
                        vista.Properties,
                        vista.Type,
                        Geometry = geoJsonWriter.Write(vista.Geometry) 
                       });

                    var construcciones1 = _unitOfWork.VistaConstruccioneRepository.Search(c => c.Codigo == query).Select(vista => new
                    {
                        vista.Properties,
                        vista.Type,
                        Geometry = geoJsonWriter.Write(vista.Geometry)
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
                    
                    var terrenos2 = _unitOfWork.VistaCatastroRepository.Search(vista => vista.Nombre.ToUpper().Contains(query.ToUpper()) || vista.Codigo.ToUpper().Contains(query.ToUpper())).Select(vista => new
                    {
                        vista.Properties,
                        vista.Type,
                        Geometry = geoJsonWriter.Write(vista.Geometry),
                        vista.Codigo
                    });

                    codigos = terrenos2.Select(vista => vista.Codigo).ToList();
                    var construcciones2 = _unitOfWork.VistaConstruccioneRepository.Search(c => codigos.Contains(c.Codigo)).Select(vista => new
                    {
                        vista.Properties,
                        vista.Type,
                        Geometry = geoJsonWriter.Write(vista.Geometry)
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

                    var terrenos3 = _unitOfWork.VistaCatastroRepository.Search(vista => vista.Documento == result).Select(vista => new
                    {
                        vista.Properties,
                        vista.Type,
                        Geometry = geoJsonWriter.Write(vista.Geometry),
                        vista.Codigo
                    });

                    codigos = terrenos3.Select(vista => vista.Codigo).ToList();

                    var construcciones3 = _unitOfWork.VistaConstruccioneRepository.Search(c => codigos.Contains(c.Codigo)).Select(vista => new
                    {
                        vista.Properties,
                        vista.Type,
                        Geometry = geoJsonWriter.Write(vista.Geometry)
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

                    var response = new
                    {
                        error = true,
                        found = false,
                        message = "FAVOR ENVIAR UN TIPO VALIDO",
                        data = new { }
                    };
                    return BadRequest(response);

            }
        }

    }
}
