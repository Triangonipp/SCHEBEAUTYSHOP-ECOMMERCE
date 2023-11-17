using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Schebeautyshop.Models
{
    public class Servicios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServicioID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Precio_S { get; set; }
        public string Duracion { get; set; }
        public int Sesiones { get; set; }
        public string FechayHoraDisponible { get; set; }


        [ForeignKey("CategoriasSID")]
        public virtual CategoriasS CategoriasS { get; set; }

    }
}
