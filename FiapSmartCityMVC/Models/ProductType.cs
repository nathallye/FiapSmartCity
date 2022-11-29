﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FiapSmartCityMVC.Models
{
    public class ProductType
    {
        public int TypeId { get; set; }

        [Required(ErrorMessage = "Descrição obrigatória!")]
            [StringLength(50,
                MinimumLength = 3,
                ErrorMessage = "A descrição deve ter, no mínimo, 3 e, no máximo, 50 caracteres.")]
            [Display(Name="Descrição:")]
        public string TypeDescription { get; set; }
        public bool Marketed { get; set; }
    }
}