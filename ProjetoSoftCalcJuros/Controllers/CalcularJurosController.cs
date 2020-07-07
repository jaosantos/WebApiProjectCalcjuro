using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjetoSoftCalcJuros.business;
using ProjetoSoftCalcJuros.models;

namespace ProjetoSoftCalcJuros.Controllers
{
    [Route("api/[controller]")]
    public class CalcularJurosController : Controller
    {
        private readonly CalcJurosValorBusiness _juros;
        private readonly string enpointJuros;

        public CalcularJurosController(IConfiguration configuration)
        {
            enpointJuros = configuration.GetValue<string>("MySettings:EnpointJuros");
            _juros = new CalcJurosValorBusiness(enpointJuros);
        }

         [HttpGet,Route("calculajuros")]
         public ResultadoJuros CalculaJuros(long valorinicial,long meses)
         {
             var retorno = _juros.CalcJurosValor(valorinicial, meses);
            
             return retorno;
         }
    }
}