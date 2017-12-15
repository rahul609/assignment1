namespace Carswebapp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_1
    {
        [Key]
        public int Carnumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Cars { get; set; }

        [Required]
        [StringLength(100)]
        public string Models { get; set; }

        public int Price { get; set; }
    }
}
