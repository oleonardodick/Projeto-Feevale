﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetosAPI.Data.Dtos
{
    public class ProdutoProntoDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int ProjetoId { get; set; }
    }
}
