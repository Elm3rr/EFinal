using EFinal.Data;
using EFinal.Modelos;
using EFinal.Repositorio.IRepositorio;

namespace EFinal.Repositorio
{
    public class VehiculoRepositorio : IVehiculoRepositorio
    {
        private readonly AplicationDbContext _db;

        public VehiculoRepositorio(AplicationDbContext db)
        {
            _db = db;
        }

        public ICollection<Vehiculo> GetVehiculos()
        {
            return _db.Vehiculos.OrderBy(v => v.Id).ToList();
        }

        public Vehiculo GetVehiculo(int vehiculoId)
        {
            return _db.Vehiculos.FirstOrDefault(v => v.Id == vehiculoId);
        }

        public bool VehiculoExistente(int vehiculoId)
        {
            return _db.Vehiculos.Any(v => v.Id == vehiculoId);
        }

        public bool CrearVehiculo(Vehiculo vehiculo)
        {
            _db.Vehiculos.Add(vehiculo);
            return Save();
        }

        public bool ActualizarVehiculo(Vehiculo vehiculo)
        {
            _db.Vehiculos.Update(vehiculo);
            return Save();
        }

        public bool BorrarVehiculo(Vehiculo vehiculo)
        {
            _db.Vehiculos.Remove(vehiculo);
            return Save();
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0;
        }
    }
}
