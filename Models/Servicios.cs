using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Schebeautyshop.Models
{
    public class Servicios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServicioID { get; set; }

        [Display (Name ="Nombre Servicio")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        [Display(Name = "Precio")]
        public double? Precio_S { get; set; }
        public string Duracion { get; set; }

        public int Sesiones { get; set; }

        [Display(Name = "Fecha y Hora Disponible")]
        public string FechayHoraDisponible { get; set; }


        [ForeignKey("CategoriasSID")]
        public virtual CategoriasS CategoriasS { get; set; }

    }



 
}
