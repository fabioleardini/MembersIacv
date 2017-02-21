using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MembersIacv.Models
{
    [Table("State")]
    public class State
    {
        [Key]
        public short StateId { get; set; }

        [MaxLength(20)]
        public string Description { get; set; }
    }
}