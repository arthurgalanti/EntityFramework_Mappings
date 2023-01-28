using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BALTA.IO_FundamentosEF.Models

{
    [Table("Category")]  //USANDO DATA NOTATIONS
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Name", TypeName = "NVARCHAR")]
        public string Name { get; set; }

        [Column("Slug", TypeName = "VARCHAR")]
        public string Slug { get; set; }
    }
}