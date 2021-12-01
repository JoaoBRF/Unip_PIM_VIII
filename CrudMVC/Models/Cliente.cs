using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMVC.Models
{
    [Table("Clientes")]
    public class Cliente              
    {   
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "CPF")]
        public int Cpf { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name ="Endereço")]
        public string Endereco { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}