using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Domain.Entities.User

{
    public class Product
    {
        [Key]
        [MaxLength(6)]

        public string Code { get; set; }

        [MaxLength(75)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [MaxLength(15)]
        public string Category { get; set; }

        [Range(5, 1000)]
        public float Cost { get; set; }

        [Range(5, 3000)]
        public float Price { get; set; }

        [MaxLength(500)]

        public string ImageUrl { get; set; }

    }
}