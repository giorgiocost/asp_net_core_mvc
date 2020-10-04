using System;
namespace MinhaDemoMvc.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Genero { get; set; }
        public Decimal Valor { get; set; }
        public string Avaliacao { get; set; }
    }
}
