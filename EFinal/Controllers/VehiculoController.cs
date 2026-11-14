using Microsoft.AspNetCore.Mvc;
using EFinal.Mapper;
using EFinal.Modelos.DTOS;
using EFinal.Repositorio.IRepositorio;

namespace EFinal.Controllers
{
    [Route("api/vehiculos")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly IVehiculoRepositorio _repo;

        public VehiculoController(IVehiculoRepositorio vehiculoRepositorio)
        {
            _repo = vehiculoRepositorio;
        }

        // Obtener el listado de todos los vehiculos
        [HttpGet(Name = "GetVehiculos")]
        [ProducesResponseType(403)]
        [ProducesResponseType(200)]
        public IActionResult GetVehiculos()
        {
            var listVehiculos = _repo.GetVehiculos();
            return Ok(listVehiculos);
        }

        // Crear un nuevo registro
        [HttpPost(Name = "CrearVehiculo")]
        [ProducesResponseType(400)]
        [ProducesResponseType(201)]
        public IActionResult CrearVehiculo([FromBody] CrearVehiculoDTO dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }

            var vehiculo = VehiculoMapper.ToVehiculo(dto);
            if (!_repo.CrearVehiculo(vehiculo))
            {
                return BadRequest();
            }
            return Ok(vehiculo);
        }

        // Actualizar un registro existente
        [HttpPatch("{vehiculoId:int}", Name = "ActualizarVehiculo")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public IActionResult ActualizarVehiculo(int vehiculoId, [FromBody] VehiculoDTO dto)
        {
            if (dto == null || !_repo.VehiculoExistente(vehiculoId))
            {
                return NotFound();
            }

            var vehiculo = VehiculoMapper.ToVehiculo(dto);
            vehiculo.Id = vehiculoId;
            if (!_repo.ActualizarVehiculo(vehiculo))
            {
                return BadRequest();
            }

            return Ok(vehiculo);
        }

        // Eliminar un registro
        [HttpDelete("{vehiculoId:int}", Name = "BorrarVehiculo")]
        [ProducesResponseType(404)]
        [ProducesResponseType(204)]
        public IActionResult BorrarVehiculo(int vehiculoId)
        {
            if (!_repo.VehiculoExistente(vehiculoId))
            {
                return NotFound();
            }

            var vehiculo = _repo.GetVehiculo(vehiculoId);
            if (!_repo.BorrarVehiculo(vehiculo))
            {
                return BadRequest();
            }

            return NoContent();
        }
    }
}
