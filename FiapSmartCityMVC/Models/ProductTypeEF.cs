using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiapSmartCityMVC.Models
{
    // Quando não estamos trabalhando com o oracle e sim diretamente com SQL Server, não se faz necessário usar as anotações [TABLE], [KEY] e [COLUMN]
    // Porque a EF por convenção, associa tabelas e campos pelo nome da classe e atributos
    [Table("PRODUCTTYPEEF")]
    public class ProductTypeEF
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeId { get; set; }

        [Column("TYPEDESCRIPTION")]
        [Required(ErrorMessage = "Descrição obrigatória!")]
            [StringLength(50,
                MinimumLength = 3,
                ErrorMessage = "A descrição deve ter, no mínimo 3 e, no máximo, 50 caracteres.")]
        [Display(Name = "Descrição:")]
        public string TypeDescription { get; set; }

        [Column("MARKETED")]
        [Display(Name = "Comercializado: ")]
        public bool Marketed { get; set; }
    }
}