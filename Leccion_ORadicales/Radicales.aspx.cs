using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Leccion_ORadicales
{
    public partial class Radicales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GenerarNuevoEjemplo();
            }

        }
        protected void btnNuevoEjemplo_Click(object sender, EventArgs e)
        {
            // Cuando el botón es presionado, genera un nuevo ejemplo y lo muestra
            Random random = new Random();
            GenerarEjemploMultiplicacion(random);
        }


        protected void btnSumaRadicales_Click(object sender, EventArgs e)
        {
            // Cuando el botón de suma de radicales es presionado, genera un nuevo ejemplo de suma
            Random random = new Random();
            GenerarEjemploSuma(random);
        }



        private void GenerarNuevoEjemplo()
        {
            // Genera un ejemplo aleatorio de operación con radicales (multiplicación o suma)
            Random random = new Random();
            int operacion = random.Next(1, 3); // 1 para multiplicación, 2 para suma

            if (operacion == 1)
            {
                GenerarEjemploMultiplicacion(random);
            }
            else
            {
                GenerarEjemploSuma(random);
            }
        }



        private void GenerarEjemploMultiplicacion(Random random)
        {
            // Genera un ejemplo de multiplicación de radicales
           
            int numero1 = random.Next(1, 50);
            int numero2 = random.Next(1, 50);

            string ejemplo = $"Ejemplo: √{numero1} * √{numero2} = √({numero1 * numero2}) = {Math.Sqrt(numero1 * numero2):0.##}";

            // Asignar el ejemplo al control Literal correspondiente para la multiplicación
            LiteralMultiplicacion.Text = ejemplo;
        }


        private void GenerarEjemploSuma(Random random)
        {
            // Genera un ejemplo de suma de radicales con el mismo radicando
            
            int coef1 = random.Next(1, 10);
            int coef2 = random.Next(1, 10);
            int radicando = random.Next(1, 50);
            int resultado = coef1 + coef2;

            // Ejemplo: √a + √a = 2√a
            string ejemplo = $"Ejemplo: {coef1}√{radicando} + {coef2}√{radicando} = {resultado}√{radicando}";

            // Asignamos el ejemplo generado al control Literal
            LiteralSumaRadicales.Text = ejemplo;
        }
    }
}