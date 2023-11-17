using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Schebeautyshop.Models
{
    public class CategoriasS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoriasSID { get; set; }

        [Display(Name = "NombreCategoriasS")]
        public string Nombre { get; set; }

        public virtual ICollection<Servicios> Servicios { get; set; }

    }
}
