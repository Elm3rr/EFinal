using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFinal.Modelos
{
    [Table("tbVehiculo")]
    public class Vehiculo
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("placa")]
        public string Placa { get; set; }
        [Column("marca")]
        public string Marca { get; set; }
        [Column("modelo")]
        public string Modelo { get; set; }
        [Column("anio")]
        public int Anio { get; set; }
        [Column("color")]
        public string Color { get; set; }
    }
}
