using System;
using Microsoft.AspNetCore.Mvc;
using marcatel_api.Services;
using marcatel_api.Utilities;
using Microsoft.AspNetCore.Authorization;
using marcatel_api.Models;
using Microsoft.Extensions.Logging;
using System.Net;
using marcatel_api.Helpers;

namespace marcatel_api.Controllers
{

    [Route("api/[controller]")]
    public class ContactosController : ControllerBase
    {
        private readonly ContactosService _ContactosService;

        public ContactosController(ContactosService contactosService)
        {
            _ContactosService = contactosService;
        }





        [HttpPost("Insert")]
        public JsonResult InsertContacto([FromBody] InsertContactoModel contacto)
        {
            var objectResponse = Helper.GetStructResponse();
            try
            {
                var CatClienteResponse = _ContactosService.InsertContacto(contacto);

                objectResponse.StatusCode = (int)HttpStatusCode.OK;
                objectResponse.success = true;
                objectResponse.message = "Registro insertado con exito";

                objectResponse.response = new
                {
                    data = CatClienteResponse
                };
            }
            catch (System.Exception ex)
            {
                Console.Write(ex.Message);
                throw;
            }


            return new JsonResult(objectResponse);

        }



        //[Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet("Get")]
        public IActionResult GetContacto()
        {
            var personas = _ContactosService.GetContacto();
            return Ok(personas);
        }


        [HttpPut("Update")]
        public JsonResult UpdateContacto([FromBody] UpdateContactoModel contacto)
        {
            var objectResponse = Helper.GetStructResponse();
            try
            {
                var CatClienteResponse = _ContactosService.UpdateContacto(contacto);

                objectResponse.StatusCode = (int)HttpStatusCode.OK;
                objectResponse.success = true;
                objectResponse.message = "Información actualizada con éxito";

                objectResponse.response = new
                {
                    data = CatClienteResponse
                };
            }
            catch (System.Exception ex)
            {
                Console.Write(ex.Message);
                throw;
            }


            return new JsonResult(objectResponse);

        }

        [HttpPut("Delete")]
        public JsonResult DeleteContacto([FromBody] DeleteContactoModel contacto)
        {
            var objectResponse = Helper.GetStructResponse();
            try
            {
                var CatClienteResponse = _ContactosService.DeleteContacto(contacto);

                objectResponse.StatusCode = (int)HttpStatusCode.OK;
                objectResponse.success = true;
                objectResponse.message = "Información eliminada con éxito";

                objectResponse.response = new
                {
                    data = CatClienteResponse
                };
            }
            catch (System.Exception ex)
            {
                Console.Write(ex.Message);
                throw;
            }


            return new JsonResult(objectResponse);

        }







    }
}