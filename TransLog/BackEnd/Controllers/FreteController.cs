using BackEnd.Models.Enums;
using BackEnd.Models.Response;
using FrontEnd.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FreteController : ControllerBase
    {
        [HttpGet]
        [Route("obter")]
        public IActionResult ObterValorFrete([FromQuery] InformacoesFreteRequest request)
        {
            var response = new InformacoesFreteResponse();
            response.Distancia = request.Distancia;
            response.PesoCarga = request.PesoCarga;
            response.Altura = request.Altura;
            response.Largura = request.Largura;



            response.ValorFrete = (response.Distancia / BaseCalculos.ValorKm) + (response.PesoCarga * BaseCalculos.AdcionalKm) + (response.Largura * response.Altura * BaseCalculos.AdcionalMetroCubico);


            return Ok(response);
        }

    }
}

