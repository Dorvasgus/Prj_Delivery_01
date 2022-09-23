using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Delivery.Data;
using Delivery.DTOs;
using Delivery.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ClientesController : ControllerBase
    {
        private readonly deliveryContext context;
        private readonly IMapper mapper;

        public ClientesController(deliveryContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<ClienteDTO>>> Get()
        {
            var autores = await context.Cliente
               .Include(x => x.Persona)
                .ToListAsync();
            var autoresDTO = mapper.Map<List<ClienteDTO>>(autores);


            return Ok(autoresDTO);
        }
        /*
        [HttpGet("{id:int}", Name = "getAutor")]
        public async Task<ActionResult<ClienteDTO>> Get(int id)
        {
            var autores = await context.Cliente
               .Include(x => x.Persona)
                .FirstOrDefaultAsync(a => a.IdCliente == id);


            var autoresDTO = mapper.Map<ClienteDTO>(autores);


            return Ok(autoresDTO);
        }
        [HttpPost]
        [Authorize(Roles = "ADM")]
        public async Task<ActionResult> Post([FromBody] AutorInsertarDTO insertarDTO)
        {
            try
            {
                var autor = mapper.Map<Autor>(insertarDTO);
                autor.Estado = true;

                context.Autors.Add(autor);
                await context.SaveChangesAsync();

                /////
                var dtoLectura = mapper.Map<AutorDTO>(autor);
                return new CreatedAtRouteResult("getAutor", new { id = autor.Id }, dtoLectura);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }




        }

        [HttpPut("{id:int}")]
        [Authorize(Roles = "ADM")]
        public async Task<ActionResult> Put(int id, [FromBody] AutorActualizarDTO actualizarDTO)
        {
            try
            {
                var autor = await context.Autors.FindAsync(id);

                if (autor == null)
                    return NotFound("El recurso no existe");



                autor = mapper.Map(actualizarDTO, autor);
                autor.Estado = actualizarDTO.Estado;

                // context.Entry(autor).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return NoContent();





            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }*/
        [HttpDelete("{id:int}")]
        [Authorize(Roles = "ADM")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {

                context.Cliente.Remove(new Cliente() { IdCliente = id });
                await context.SaveChangesAsync();
                return NoContent();


            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
