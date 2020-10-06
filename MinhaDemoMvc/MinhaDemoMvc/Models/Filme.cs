using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaDemoMvc.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título precisa ter de 3 a 60 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "Data no formato incorreto")]
        [Display(Name = "Data de lançamento")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"ˆ[A-Z]+[a-zA-Z\u00C0-\u00FF""\w-]*$", ErrorMessage = "Genero em formato inválido")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres"), Required(ErrorMessage = "Preencha o campo genero")]
        public string Genero { get; set; }

        [Range(1,1000, ErrorMessage = "Valor de 1 a 1000")]
        [Required(ErrorMessage = "Preencher o campo valor")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [RegularExpression(@"ˆ[0-5]*$", ErrorMessage = "Somente números")]
        [Display(Name = "Avaliação")]
        [Required(ErrorMessage = "Preencher o campo Avaliação")]
        public int Avaliacao { get; set; }
    }
}
