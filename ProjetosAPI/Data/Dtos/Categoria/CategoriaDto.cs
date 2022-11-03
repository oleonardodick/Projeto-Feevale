﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetosAPI.Data.Dtos
{
    public class CategoriaDto
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cor { get; set; }
    }
}
