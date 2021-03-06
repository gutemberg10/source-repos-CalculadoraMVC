using CalculadoraMVC.Models;
using System.Web.Mvc;

namespace CalculadoraMVC.Controllers
{
    public class CalculadoraController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CalculadoraViewModel calculadoraViewModel)
        {
            ModelState.Clear();
            if (calculadoraViewModel.Operador.Equals("+"))
            {
                calculadoraViewModel.Resultado = calculadoraViewModel.Num1 + calculadoraViewModel.Num2;
            }
            else
            if (calculadoraViewModel.Operador.Equals("-"))
            {
                calculadoraViewModel.Resultado = calculadoraViewModel.Num1 - calculadoraViewModel.Num2;
            }
            else
            if (calculadoraViewModel.Operador.Equals("*"))
            {
                calculadoraViewModel.Resultado = calculadoraViewModel.Num1 * calculadoraViewModel.Num2;
            }
            else
            if (calculadoraViewModel.Operador.Equals("/"))
            {
                calculadoraViewModel.Resultado = calculadoraViewModel.Num1 / calculadoraViewModel.Num2;
            }
           
            return View(calculadoraViewModel);
        }
    }
}
