using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models.Request
{
    public class InformacoesFreteRequest
    {

        public int Distancia { get; set; }
        public int PesoCarga { get; set; }
        public int Largura { get; set; }
        public int Altura { get; set; }
        public int Cumprimento { get; set; }
    }
}
