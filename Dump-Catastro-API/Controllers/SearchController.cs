using Dump_Catastro_CORE.Entities;
using Dump_Catastro_CORE.Interfaces;
using Dump_Catastro_INFRASTRUCTURE.Data;
using Dump_Catastro_INFRASTRUCTURE.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dump_Catastro_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbcatastroContext _context;
        public SearchController(IUnitOfWork unitOfWork, DbcatastroContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }


        [HttpGet(Name = nameof(GetSearch))]
        public IActionResult GetSearch(string query, string type)
        {
            List<string> codigos = new List<string>();
            List<VistaTerreno> terrenos = new List<VistaTerreno>();

            switch (type)
            {
                case "1":
                    terrenos = _unitOfWork.VistaTerrenosRepository.Search(vista => vista.Nombre.ToUpper().Contains(query.ToUpper()) || vista.Codigo.ToUpper().Contains(query.ToUpper())).ToList();
                    codigos.Add(query);
                    break;
                case "2":
                    terrenos = _unitOfWork.VistaTerrenosRepository.Search(vista => vista.Nombre.ToUpper().Contains(query.ToUpper()) || vista.Codigo.ToUpper().Contains(query.ToUpper())).ToList();
                    codigos = terrenos.Select(vista => vista.Codigo).ToList();
                    break;
                case "3":

                    bool isvalid = int.TryParse(query, out int result);

                    if(!isvalid)
                    {
                        return BadRequest("Favor de enviar un valor numerico");
                    }

                    terrenos = _unitOfWork.VistaTerrenosRepository.Search(vista => vista.Documento == result).ToList();
                    codigos = terrenos.Select(vista => vista.Codigo).ToList();
                    break;
            }

            var construcciones = _unitOfWork.VistaConstruccioneRepository.Search(c => codigos.Contains(c.Codigo));

            var response = new {
                error = false,
                found = true,
                message = "",
                data = new { terrenos, construcciones}
            };


            return Ok(response);
        }

    }
}
