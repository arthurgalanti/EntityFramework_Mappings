using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BALTA.IO_FundamentosEF.Models
{
    [Table("Tag")]
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }   
    }
}