using FiapSmartCityMVC.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiapSmartCityMVC.Models
{
    [Table("PRODUCTEF")]
    public class ProductEF
    {
        [Key]
        [Column("PRODUCTID")]
        public int ProductId { get; set; }

        [Column("PRODUCTNAME")]
        public string ProductName { get; set; }

        [Column("FEATURES")]
        public string Features { get; set; } // Características

        [Column("AVERAGEPRIVE")]
        public double AveragePrice { get; set; } // preço médio

        [Column("LOGOTIPO")]
        public string Logotipo { get; set; }

        [Column("ACTIVE")]
        public bool Active { get; set; } // ativos

        // Foreing Key
        [Column("TYPEID")]
        // Referência para classe TipoProduto/ProductType
        public int TypeId { get; set; }

        // Navigation Property
        public ProductType Tipo { get; set; }
    }
}
