using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ECommerce_MW.DAL.Entities
{
    public class Country : Entity
    {
        [Display(Name = "Nombre")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es oblilgatorio.")]
        public string Name { get; set; }
    }
}
