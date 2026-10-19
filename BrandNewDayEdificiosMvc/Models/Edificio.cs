using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BrandNewDayEdificiosMvc.Models
{
    public class Edificio
    {
        [Key]
        public int BarrioId {  get; set; }
        [Required]
        [StringLength(60)]
        public string Nombre { get; set; }
        public string Descripcion {  get; set; }
        [ForeignKey("BarrioId")]
        public virtual Barrio Barrio { get; set; }
    }
}