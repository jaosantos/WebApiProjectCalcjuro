using Microsoft.AspNetCore.Mvc;
using ProjetoSoftCalcJuros.models;

namespace ProjetoSoftCalcJuros.Controllers
{
    [Route("api/[controller]")]
    public class SourceCodeController : Controller
    {
        public SourceCodeController()
        {
        }

         [HttpGet,Route("showmethecode")]
         public Fonte ShowMeTheCode()
         {
             var fonte = new Fonte{
                 UrlCode = "https://github.com/jaosantos/WebApiProjectCalcjuro"
             };
            
             return fonte;
        }
    }
}