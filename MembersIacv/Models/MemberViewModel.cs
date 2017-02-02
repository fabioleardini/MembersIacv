using System;
using System.ComponentModel.DataAnnotations;

namespace MembersIacv.Models
{
    public class MemberViewModel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(80)]
        public string Name { get; set; }

        public char Sex { get; set; }

        public DateTime BirthDay { get; set; }

        [MaxLength(40)]
        public string NaturalOf { get; set; }

        public short MartialStatusId { get; set; }

        [MaxLength(80)]
        public string Spouse { get; set; }

        public DateTime MarriageDate { get; set; }

        [MaxLength(80)]
        public string Father { get; set; }

        [MaxLength(80)]
        public string Mother { get; set; }

        [MaxLength(10)]
        public string HomePhone { get; set; }

        [MaxLength(11)]
        public string Mobile { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(80)]
        public string Address { get; set; }

        [MaxLength(40)]
        public string District { get; set; }

        [MaxLength(40)]
        public string Ciy { get; set; }

        public short StateId { get; set; }

        public int Zip { get; set; }

        [MaxLength(30)]
        public string Profession { get; set; }

        [MaxLength(40)]
        public string Education { get; set; }

        [MaxLength(80)]
        public string Workplace { get; set; }

        [MaxLength(10)]
        public string WorkPhone { get; set; }

        public long Cpf { get; set; }

        public long Rg { get; set; }

        [MaxLength(20)]
        public string Nationality { get; set; }

        [MaxLength(3)]
        public string BloodType { get; set; }

        public DateTime BaptismDate { get; set; }

        public short EcclesiasticalFunctionId { get; set; }

        public virtual MartialStatus MartialStatus { get; set; }

        public virtual State State { get; set; }

        public virtual EcclesiasticalFunction EcclesiasticalFunction { get; set; }
    }
}