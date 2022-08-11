using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aplicacionraiz2022postgress.Models
{
    [Table("t_producto")]
    public class Producto
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        
        public int? Id { get; set; }
        [Column("Name")]
        public string? Name { get; set; }
        [Column("Descripcion")]
        public string? Descripcion { get; set; }
        [Column("Precio")]
        public Decimal? Precio { get; set; }
        [Column("PorcentajeDescuento")]
       public Decimal? PorcentajeDescuento { get; set; }
        [Column("ImageName")]
        public String? ImageName { get; set; }
        [Column("Status")]
        public String? Status { get; set; }
        
    }
}