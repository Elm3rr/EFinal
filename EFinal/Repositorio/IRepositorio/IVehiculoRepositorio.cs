using EFinal.Modelos;

namespace EFinal.Repositorio.IRepositorio
{
    public interface IVehiculoRepositorio
    {
        ICollection<Vehiculo> GetVehiculos();
        Vehiculo GetVehiculo(int vehiculoId);
        bool VehiculoExistente(int vehiculoId);
        bool CrearVehiculo(Vehiculo vehiculo);
        bool ActualizarVehiculo(Vehiculo vehiculo);
        bool BorrarVehiculo(Vehiculo vehiculo);
        bool Save();
    }
}
