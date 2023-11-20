using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Security.Principal;

namespace Schebeautyshop.Models
{
    public class Productos
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int? ProductID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        [Display(Name = "Precio")]
        [Column(TypeName = "decimal(18, 2)")]
        public int Precio_p { get; set; }
        public string Stock { get; set; }


        [ForeignKey("CategoriasPID")]
        public virtual CategoriasP Categoriasp { get; set; }
    }
}
