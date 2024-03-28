using System.ComponentModel.DataAnnotations;

namespace FrontEnd.Models.Request
{
    public class InformacoesFreteRequest
    {
        [Required(ErrorMessage = "Distancia é obrigatório")]
        public int Distancia { get; set; }

        [Required(ErrorMessage = "PesoCarga é obrigatório")]
        public int PesoCarga { get; set; }

        [Required(ErrorMessage = "Largura é obrigatório")]
        public int Largura { get; set; }

        [Required(ErrorMessage = "Altura é obrigatório")]
        public int Altura { get; set; }

        [Required(ErrorMessage = "Cumprimento é obrigatório")]
        public int Cumprimento { get; set; }
    }
}
