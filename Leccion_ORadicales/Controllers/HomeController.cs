using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Leccion_ORadicales.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //generar un ejemplo aleatorio de radicales
            var ejemplo = ObtenerEjemploAleatorio();
            ViewData["Ejemplo"] = ejemplo;

            return View();
        }

        //Funcion que retorna un ejemplo aleatorio

        private string ObtenerEjemploAleatorio()
        {
            Random random = new Random();

            int operacion = random.Next(1, 5); //genera un numero entre 1 y 4
            int numero1 = random.Next(1, 10); //primer numero aleatorio
            int numero2 = random.Next(1, 10);//segundo numero aleatorio

            //genera ejemplos de operaciones con radicales segun el numero aleatorio
            switch (operacion)
            {
                case 1:
                    return $"Simplificar: √{numero1 * numero1}";
                case 2:
                    return $"Suma de radicales : √{numero1} + √{numero2}";
                case 3:
                    return $"Multiplicacion de radicales: √{numero1} * √{numero2}";
                case 4:
                    return $"Racionalizacion: √{numero1} / √{numero2}";
                default:
                    return "Error en la generacion del ejemplo.";

            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}