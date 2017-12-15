namespace Carswebapp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_2
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int carnumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Cars { get; set; }

        [Key]
        [StringLength(100)]
        public string NumberPlate { get; set; }

        public int RentalPrice { get; set; }
    }
}
