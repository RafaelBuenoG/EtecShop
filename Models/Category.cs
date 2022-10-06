using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtecShop.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Nome da Categoria")]
        [StringLength(30, ErrorMessage = "O nome deve possuir até 30 caracteres")]
        [Required(ErrorMessage = "Por favor, informe o Nome da Categoria")]
        public string Name { get; set; }
    }
}