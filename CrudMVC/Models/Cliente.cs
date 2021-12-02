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
        public bool Ativo { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Required]
        [Display(Name = "Numero")]
        public int Numero { get; set; }

        [Required]
        [Display(Name = "CEP")]
        public int Cep { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "DDD")]
        public string DDD { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

    }
}