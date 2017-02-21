using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MembersIacv.Models
{
    [Table("Member")]
    public class MemberViewModel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(80), Display(Name="Nome")]
        public string Name { get; set; }

        [MaxLength(1), Display(Name = "Sexo")]
        public string Sex { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime BirthDay { get; set; }

        [MaxLength(40), Display(Name = "Natural de")]
        public string NaturalOf { get; set; }

        [Display(Name = "Estado Civil")]
        public short MartialStatusId { get; set; }

        [MaxLength(80), Display(Name = "Cônjuge")]
        public string Spouse { get; set; }

        [Display(Name = "Data de Matrimônio")]
        public DateTime MarriageDate { get; set; }

        [MaxLength(80), Display(Name = "Nome do Pai")]
        public string Father { get; set; }

        [MaxLength(80), Display(Name = "Nome da Mãe")]
        public string Mother { get; set; }

        [MaxLength(10), Display(Name = "Telefone Residencial")]
        public string HomePhone { get; set; }

        [MaxLength(11), Display(Name = "Celular")]
        public string Mobile { get; set; }

        [MaxLength(80), EmailAddress, Display(Name = "Email")]
        public string Email { get; set; }

        [MaxLength(80), Display(Name = "Endereço")]
        public string Address { get; set; }

        [MaxLength(40), Display(Name = "Bairro")]
        public string District { get; set; }

        [MaxLength(40), Display(Name = "Cidade")]
        public string Ciy { get; set; }

        [Display(Name = "Estado")]
        public short StateId { get; set; }

        [Display(Name = "CEP")]
        public int Zip { get; set; }

        [MaxLength(30), Display(Name = "Profissão")]
        public string Profession { get; set; }

        [MaxLength(40), Display(Name = "Formação Acadêmica")]
        public string Education { get; set; }

        [MaxLength(80), Display(Name = "Local de Trabalho")]
        public string Workplace { get; set; }

        [MaxLength(10), Display(Name = "Telefone Comercial")]
        public string WorkPhone { get; set; }

        [Display(Name= "CPF")]
        public long Cpf { get; set; }

        [Display(Name= "RG")]
        public long Rg { get; set; }

        [MaxLength(20), Display(Name = "Nacionalidade")]
        public string Nationality { get; set; }

        [Display(Name = "Tipo Sanguíneo")]
        public short BloodTypeId { get; set; }

        [Display(Name = "Data de Batismo")]
        public DateTime BaptismDate { get; set; }

        [Display(Name = "Função Eclesiástica")]
        public short EcclesiasticalFunctionId { get; set; }

        public virtual MartialStatus MartialStatus { get; set; }

        public virtual State State { get; set; }

        public virtual BloodType BloodType { get; set; }

        public virtual EcclesiasticalFunction EcclesiasticalFunction { get; set; }
    }
}