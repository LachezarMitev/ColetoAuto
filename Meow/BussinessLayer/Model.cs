﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace BussinessLayer
{
    public class Model
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModelId { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("Brand")]
        public int BrandIdF { get; set; }

        public Brand brand { get; set; }

        

        public Model() 
        {
        }

        public Model(string name, Brand brand_)
        {
            Name = name;
            brand = brand_;
        }

    }
}
