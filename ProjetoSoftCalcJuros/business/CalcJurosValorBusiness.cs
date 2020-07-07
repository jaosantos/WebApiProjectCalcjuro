using System;
using ProjetoSoftCalcJuros.models;

namespace ProjetoSoftCalcJuros.business
{
    public class CalcJurosValorBusiness
    {
        private readonly JurosValorBusiness _jurosValorBusiness;
        public CalcJurosValorBusiness(string enpointJuros)
        {
            _jurosValorBusiness = new JurosValorBusiness(enpointJuros);
        }
        public ResultadoJuros CalcJurosValor(long valorinicial, long meses)
        {
            var juros = _jurosValorBusiness.TaxaJuros();
            var resultParcial = Math.Pow((1 + juros), meses) * valorinicial;

            var resultadoJuros = new ResultadoJuros
            {
                Resultado = resultParcial.ToString("F")
            };

            return resultadoJuros;
        }
    }
}