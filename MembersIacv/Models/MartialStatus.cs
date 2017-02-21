using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MembersIacv.Models
{
    [Table("MartialStatus")]
    public class MartialStatus
    {
        [Key]
        public short MartialStatusId { get; set; }

        [MaxLength(15)]
        public string Description { get; set; }
    }
}