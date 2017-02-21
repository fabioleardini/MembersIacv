using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MembersIacv.Models
{
    [Table("EcclesiasticalFunction")]
    public class EcclesiasticalFunction
    {
        [Key]
        public short EcclesiasticalFunctionId { get; set; }

        [MaxLength(20)]
        public string Description { get; set; }
    }
}