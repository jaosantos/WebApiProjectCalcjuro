using System;
using System.Net.Http;
using System.Net.Http.Headers;
using ProjetoSoftCalcJuros.models;

namespace ProjetoSoftCalcJuros.business
{
    public class JurosValorBusiness
    {
        private readonly string _enpointJuros;

        public JurosValorBusiness(string enpointJuros)
        {
            this._enpointJuros = enpointJuros;
        }
        
        public double TaxaJuros()
        {
            var retorno = 0.0;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(_enpointJuros);

            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("").Result; 
            if (response.IsSuccessStatusCode)
            {
                var taxaJuros = response.Content.ReadAsAsync<TaxaJuros>().Result;
                retorno = taxaJuros.Juros;
            }
            client.Dispose();

            return retorno;
        }
    }
}