using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrandNewDayEdificiosMvc.Models
{
    public class Barrio
    {
        [Key]
        public int EdificioId { get; set; }
        [Required]
        [StringLength(60)]
        public string Nombre { get; set; }
        [Range(1, 7)]
        public int Peligro { get; set; }
        public string Vigilante { get; set; }
        public virtual ICollection<Edificio> Edificios { get; set; }
    }
}