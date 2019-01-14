using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabJJ2.Models
{
    public class ProductsModel
    {
        [Required(ErrorMessage = "Enter Name")]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Description")]
        [MaxLength(50)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Enter Price")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
                
        [MaxLength(5)]
        public string CustomerRating { get; set; }
    }
}