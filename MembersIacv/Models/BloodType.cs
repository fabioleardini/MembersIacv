using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MembersIacv.Models
{
    [Table("BloodType")]
    public class BloodType
    {
        [Key]
        public short BloodTypeId { get; set; }

        [MaxLength(3)]
        public string Description { get; set; }
    }
}