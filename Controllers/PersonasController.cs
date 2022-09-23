using AutoMapper;
using Delivery.Data;
using Delivery.DTOs;
using Delivery.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Delivery.Models;
using PRJ_Delivery.Helpers;

namespace PRJ_Delivery.Controladores
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly deliveryContext context;
        private readonly IMapper mapper;
        public PersonasController(deliveryContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet]

        public async Task<ActionResult> Get([FromQuery] PaginacionDTO paginacion)
        {
            try
            {
                var query = context.Persona
                .Include(x => x.Pedido)
                .AsQueryable();

                var datosPaginacion = await query.datosPaginacion(paginacion.CantidadRegistroPorPagina);
                var entidades = await query.Paginar(paginacion).ToListAsync();
                var list = mapper.Map<List<PersonaDTO>>(entidades);

                return Ok(new ResponseListDTO<PersonaDTO>
                {
                    cantidad = int.Parse(datosPaginacion["CantidadPaginas"]),
                    pagina = paginacion.Pagina,
                    total = int.Parse(datosPaginacion["TotalRegistros"]),
                    valores = list
                });
            }
            catch (Exception ex)
            {

                return new ResponseError(StatusCodes.Status400BadRequest, ex.Message).GetObjectResult();
            }
        }
        [HttpPost]
        
        public async Task<ActionResult> Post([FromBody] PersonaInsertarDTO personaInsertarDTO)
        {
            try
            {
                var persona = mapper.Map<Persona>(personaInsertarDTO);
                await context.Persona.AddAsync(persona);
                await context.SaveChangesAsync();
                return Ok(persona);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
