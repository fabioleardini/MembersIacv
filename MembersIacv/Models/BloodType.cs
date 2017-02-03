using System.ComponentModel.DataAnnotations;

namespace MembersIacv.Models
{
    public class BloodType
    {
        [Key]
        public short BloodTypeId { get; set; }

        [MaxLength(3)]
        public string Description { get; set; }
    }
}