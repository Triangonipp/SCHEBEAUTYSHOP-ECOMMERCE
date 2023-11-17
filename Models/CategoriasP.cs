using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Schebeautyshop.Models
{
    public class CategoriasP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoriasPID { get; set; }

        [Display(Name = "NombreCategoriasP")]
        public string Nombre { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }


    }
}
