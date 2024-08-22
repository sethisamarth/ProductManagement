using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Domain.Entities
{
    public class Product
    {
            public int Id { get; set; }
            [MaxLength(50)]
            [Required]
            public string Title { get; set; }
            [MaxLength(250)]
            public string? Description { get; set; }
            public int Quantity { get; set; }
            [Display(Name = "Price per product")]
            [Range(10, 10000)]
        public double Price { get; set; }
            public DateTime? Date { get; set; }
            [Display(Name = "Image Url")]
            public string? ImagePath { get; set; }
        }
    }

