using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTesteEntrevista.Models
{

    [Table("Funcionario")]
    public class Funcionario
    {

        [Display(Name ="Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome  { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco  { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }
        public int Idade { get { return DateTime.Now.Year - Nascimento.Year; } }

        [Display(Name = "Salário")]
        public decimal Salario  { get; set; }
    }
}
