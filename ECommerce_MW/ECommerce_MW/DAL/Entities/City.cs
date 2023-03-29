using Microsoft.Build.Construction;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce_MW.DAL.Entities
{
    public class City :Entity
    {

        [Display(Name = "ciudad")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es oblilgatorio.")]
        public string Name { get; set; }

       
        public State State { get; set; }

        
    }
}
