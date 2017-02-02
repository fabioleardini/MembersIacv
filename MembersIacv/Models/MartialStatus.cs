using System.ComponentModel.DataAnnotations;

namespace MembersIacv.Models
{
    public class MartialStatus
    {
        [Key]
        public short MartialStatusId { get; set; }

        [MaxLength(15)]
        public string Description { get; set; }
    }
}