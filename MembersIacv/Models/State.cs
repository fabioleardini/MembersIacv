using System.ComponentModel.DataAnnotations;

namespace MembersIacv.Models
{
    public class State
    {
        [Key]
        public short StateId { get; set; }

        [MaxLength(20)]
        public string Description { get; set; }
    }
}