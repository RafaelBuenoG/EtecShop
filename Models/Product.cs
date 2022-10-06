using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtecShop.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [StringLength(200, ErrorMessage = "O nome deve possuir até 200 caracteres")]
        [Required(ErrorMessage = "Por favor, informe o Nome")]
        public string Name { get; set; }

        [Display(Name = "Descrição")]
        [StringLength(200, ErrorMessage = "O nome deve possuir até 8000 caracteres")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        [Column(TypeName = "deciaml(10,2)")]
        [Required(ErrorMessage = "Por favor, informe o Preço")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }

        [Display(Name = "Imagem")]
        [StringLength(200)]
        public string Image { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Por favor, informe a Categoria")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Display(Name = "Marca")]
        [Required(ErrorMessage = "Por favor, informe a Marca")]
        public int BrandId { get; set; }

        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
    }
}