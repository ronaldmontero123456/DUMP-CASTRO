using Dump_Catastro_CORE.Entities;
using Dump_Catastro_CORE.Interfaces;
using Dump_Catastro_INFRASTRUCTURE.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Dump_Catastro_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormulariocatastralController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormulariocatastralController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = nameof(GetByCode))]
        public IActionResult GetByCode(string code) 
        {
            try
            {
                var result = _unitOfWork.FormularioCatastralRepository.Search(c => c.Codigo.ToLower() == code.ToLower().Trim()).FirstOrDefault();

                if(result == null)
                {
                    var notfound = new
                    {
                        error = true,
                        found = false,
                        message = "Not Found",
                    };

                    return NotFound(notfound);
                }

                var response = new
                {
                    error = false,
                    found = true,
                    message = "Succes",
                    data = JsonConvert.DeserializeObject<object>(result.FormJson),
                };

                return Ok(response);
            }
            catch(Exception ex) 
            {
                var response = new
                {
                    error = true,
                    found = false,
                    message = ex.Message,
                };

                return BadRequest(response);
            }
        }

        [HttpPost(Name = nameof(SaveForm))]
        public IActionResult SaveForm([FromBody] Catastral[] formularioCatastralRequest)
        {

            try
            {
                foreach (var form in formularioCatastralRequest)
                {

                    var result = _unitOfWork.FormularioCatastralRepository.Search(c => c.Codigo.ToLower() == form.codigo.ToLower()).FirstOrDefault();

                    if(result == null)
                    {
                        Formulariocatastral formulariocatastral = new Formulariocatastral()
                        {
                            Codigo = form.codigo,
                            FormJson = JsonConvert.SerializeObject(form),
                        };

                        _unitOfWork.FormularioCatastralRepository.Add(formulariocatastral);
                        continue;
                    }

                    result.FormJson = JsonConvert.SerializeObject(form);

                    _unitOfWork.FormularioCatastralRepository.Update(result);

                }

                _unitOfWork.SaveChangesAsync();

                var response = new
                {
                    error = false,
                    found = true,
                    message = "Succes"
                };

                return Ok(response);
            }
            catch(Exception ex) 
            {
                var response = new
                {
                    error = true,
                    found = false,
                    message = ex.Message,
                };

                return BadRequest(response);
            }
        }

    }
}
