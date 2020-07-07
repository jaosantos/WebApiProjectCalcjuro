using ProjetoSoftCalcJuros.business;
using System;
using Xunit;

namespace ProjetoSoftCalcJurosTest.testes
{
    public class ProjetoSoftCalcJurosTeste
    {
        private readonly string _enpointJuros = "https://projetosoft.azurewebsites.net/api/juros/taxajuros";
        [Fact]
        public void CalcularJuros()
        {
            var teste = new CalcJurosValorBusiness(_enpointJuros);
            var retorno = teste.CalcJurosValor(100, 5);
            Assert.Equal("105,10", retorno.Resultado);
        }

        [Fact]
        public void CalcularJurosNoOk()
        {
            var teste = new CalcJurosValorBusiness(_enpointJuros);
            var retorno = teste.CalcJurosValor(100, 5);
            Assert.NotEqual("105,50", retorno.Resultado);
        }
    }
}
