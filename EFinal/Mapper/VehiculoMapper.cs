using EFinal.Modelos;
using EFinal.Modelos.DTOS;

namespace EFinal.Mapper
{
    public static class VehiculoMapper
    {
        public static Vehiculo ToVehiculo(CrearVehiculoDTO dto)
        {
            return new Vehiculo
            {
                Placa = dto.Placa,
                Marca = dto.Marca,
                Modelo = dto.Modelo,
                Anio = dto.Anio,
                Color = dto.Color
            };
        }
        public static Vehiculo ToVehiculo(VehiculoDTO dto)
        {
            return new Vehiculo
            {
                Placa = dto.Placa,
                Marca = dto.Marca,
                Modelo = dto.Modelo,
                Anio = dto.Anio,
                Color = dto.Color
            };
        }
    }
}
