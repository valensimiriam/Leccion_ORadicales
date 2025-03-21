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
        private Random random = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GenerarNuevoEjemplo();
                GenerarEjercicioSuma();
                GenerarEjercicioResta();
                GenerarEjercicioMultiplicacion();
                GenerarEjercicioDivision();
                GenerarEjercicioRacionalizacion();
                
            }

        }
        protected void btnNuevoEjemplo_Click(object sender, EventArgs e)
        {
            // Cuando el botón es presionado, genera un nuevo ejemplo y lo muestra
            Random random = new Random();
            GenerarEjemploMultiplicacion(random);
        }

        protected void btnRestaRadicales_Click(object sender, EventArgs e)
        {
            // Cuando el botón es presionado, genera un nuevo ejemplo y lo muestra
            Random random = new Random();
            GenerarEjemploResta(random);
        }


        protected void btnSumaRadicales_Click(object sender, EventArgs e)
        {
            // Cuando el botón de suma de radicales es presionado, genera un nuevo ejemplo de suma
            Random random = new Random();
            GenerarEjemploSuma(random);
        }

        protected void btnDivisionRadicales_Click(object sender, EventArgs e)
        {
            // Cuando el botón de suma de radicales es presionado, genera un nuevo ejemplo de suma
            Random random = new Random();
            GenerarEjemploDivision(random);
        }


        protected void btnRacionalizar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            GenerarEjemploRacionalizacion(random);
        }

        protected void btnRadicalFraccion_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            GenerarEjemploRadicalFraccion(random);
        }


        protected void btnRaizPotencia_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            GenerarEjemploRaizPotencia(random);
        }
        protected void btnRaizFraccion_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            GenerarEjemploRaizFraccion(random);
        }

        protected void btnOperacionRadicales_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            GenerarEjemploOperacionRadicales(random);
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
            else if (operacion == 2)
            {
                GenerarEjemploResta(random);
            }
            else if (operacion == 3)
            {
                GenerarEjemploDivision(random);
            }
        }



        private void GenerarEjemploMultiplicacion(Random random)
        {
            // Generación de dos números aleatorios
            int numero1 = random.Next(1, 50);
            int numero2 = random.Next(1, 50);

            // Construcción del problema
            string ejemplo = $"<p><b>Ejemplo:</b> √{numero1} * √{numero2}</p>";

            // Paso 1: Multiplicamos los radicales
            string paso1 = $"<p><b>Paso 1:</b> Multiplicamos los dos radicales: √{numero1} * √{numero2} = √({numero1 * numero2}).</p>";

            // Paso 2: Calculamos la raíz del producto
            double resultadoProducto = Math.Sqrt(numero1 * numero2);
            string paso2 = $"<p><b>Paso 2:</b> La raíz del producto es: √({numero1 * numero2}) = {resultadoProducto:0.##}.</p>";

            // Mostrar todo en el Literal (agregar los pasos en formato HTML)
            LiteralMultiplicacion.Text = ejemplo + paso1 + paso2;
        }


        private void GenerarEjemploSuma(Random random)
        {
            // Generación de dos coeficientes aleatorios y un radicando aleatorio
            int coef1 = random.Next(1, 10);  // Coeficiente para el primer radical
            int coef2 = random.Next(1, 10);  // Coeficiente para el segundo radical
            int radicando = random.Next(1, 50);  // Radicando aleatorio
            int resultado = coef1 + coef2;  // Suma de los coeficientes

            // Construcción del ejemplo
            string ejemplo = $"<p><b>Ejemplo:</b> {coef1}√{radicando} + {coef2}√{radicando}</p>";

            // Paso 1: Explicación de la suma de los radicales con el mismo radicando
            string paso1 = $"<p><b>Paso 1:</b> Como ambos radicales tienen el mismo radicando (√{radicando}), podemos sumar solo los coeficientes.</p>";

            // Paso 2: Resultado de la suma de radicales
            string paso2 = $"<p><b>Paso 2:</b> La suma de los coeficientes {coef1} + {coef2} da como resultado {resultado}, por lo que el resultado es: {resultado}√{radicando}.</p>";

            // Mostrar todo el proceso en el Literal (mostrar cada paso)
            LiteralSumaRadicales.Text = ejemplo + paso1 + paso2;
        }

        private void GenerarEjemploResta(Random random)
        {
            // Generación de dos coeficientes aleatorios y un radicando aleatorio
            int coef1 = random.Next(1, 10);  // Coeficiente para el primer radical
            int coef2 = random.Next(1, 10);  // Coeficiente para el segundo radical
            int radicando = random.Next(1, 50);  // Radicando aleatorio

            // Calculamos la resta de los coeficientes (si los radicales tienen el mismo radicando)
            int resultado = coef1 - coef2;  // Resultado de la resta de coeficientes

            // Paso 1: Explicación de la resta de radicales con el mismo radicando
            string paso1 = $"<p><b>Paso 1:</b> Como ambos radicales tienen el mismo radicando (√{radicando}), podemos restar solo los coeficientes.</p>";

            // Paso 2: Realización de la resta y simplificación
            string paso2 = $"<p><b>Paso 2:</b> La resta de los coeficientes {coef1} - {coef2} da como resultado {resultado}, " +
                           $"por lo que el resultado final es: {resultado}√{radicando}.</p>";

            // Paso 3: Mostrar el resultado numérico si es necesario (opcional)
            double resultadoNumerico = resultado * Math.Sqrt(radicando);
            string paso3 = $"<p><b>Paso 3:</b> El valor numérico aproximado de {resultado}√{radicando} es: {resultadoNumerico:F2}.</p>";

            // Construcción del ejemplo completo y asignación al Literal
            string ejemplo = $"<p><b>Ejemplo:</b> {coef1}√{radicando} - {coef2}√{radicando}</p>";

            // Asignamos el ejemplo con los pasos al control LiteralRestaRadicales
            LiteralRestaRadicales.Text = ejemplo + paso1 + paso2 + paso3;

        }


        private void GenerarEjemploDivision(Random random)
        {

            // Generación de coeficiente para el numerador
            int coef1 = random.Next(1, 10);  // Numerador coeficiente

            // Generación de coeficiente para el denominador
            int coef2;
            // Asegurarnos de que coef2 no sea 0
            do
            {
                coef2 = random.Next(1, 10);
            } while (coef2 == 0);

            // Generación de radicando aleatorio
            int radicando = random.Next(1, 50);  // Radicando aleatorio dentro del radical

            // Paso 1: Explicación de la división de radicales con el mismo radicando
            string paso1 = $"<p><b>Paso 1:</b> Como ambos radicales tienen el mismo radicando (√{radicando}), podemos dividir solo los coeficientes y dejar el radicando igual.</p>";

            // Realización de la división de los coeficientes
            double resultado = (double)coef1 / coef2;

            // Paso 2: Mostramos la fracción de la división
            string paso2 = $"<p><b>Paso 2:</b> La división de los coeficientes {coef1} ÷ {coef2} da como resultado {resultado:F2}, " +
                           $"por lo que el resultado final es: {resultado:F2}√{radicando}.</p>";

            // Paso 3: Calcular el valor numérico de la fracción
            double resultadoNumerico = resultado * Math.Sqrt(radicando);
            string paso3 = $"<p><b>Paso 3:</b> El valor numérico aproximado de {resultado:F2}√{radicando} es: {resultadoNumerico:F2}.</p>";

            // Construcción del ejemplo completo
            string ejemplo = $"<p><b>Ejemplo:</b> ({coef1}√{radicando}) ÷ ({coef2}√{radicando})</p>";

            // Asignamos el ejemplo generado al control LiteralDivisionRadicales
            LiteralDivisionRadicales.Text = ejemplo + paso1 + paso2 + paso3;
        }


        private void GenerarEjemploRacionalizacion(Random random)
        {

            // Generación aleatoria de numerador y radicando
            int numerador = random.Next(1, 10);  // Numerador aleatorio
            int radicando = random.Next(2, 20);  // Radicando aleatorio

            // Construcción del problema
            string ejemplo = $"<p><b>Ejemplo:</b> {numerador} / √{radicando}</p>";

            // Paso 1: Racionalización - Multiplicamos por (√radicando / √radicando)
            string paso1 = $"<p><b>Paso 1:</b> Multiplicamos el numerador y denominador por √{radicando} para eliminar la raíz en el denominador. " +
                           $"Esto da: ({numerador} × √{radicando}) / ({radicando}).</p>";

            // Racionalización: Multiplicamos el numerador por √radicando y el denominador por √radicando.
            double numeradorRacionalizado = numerador * Math.Sqrt(radicando);
            int denominadorRacionalizado = radicando;

            // Paso 2: Resultado final - Calculamos la fracción racionalizada
            string paso2 = $"<p><b>Paso 2:</b> El resultado después de la racionalización es: {numeradorRacionalizado:F2} / {denominadorRacionalizado}.</p>";

            // Paso 3: Calculamos el valor numérico
            double resultadoFinal = numeradorRacionalizado / denominadorRacionalizado;

            // Paso 4: Mostramos la solución numérica final
            string paso3 = $"<p><b>Paso 3:</b> El valor numérico de la fracción es aproximadamente: {resultadoFinal:F2}.</p>";

            // Mostrar todo en el Literal (agregar los pasos en formato HTML)
            LiteralRacionalizacion.Text = ejemplo + paso1 + paso2 + paso3;
        }

        private void GenerarEjemploRadicalFraccion(Random random)
        {
            // Generar un numerador aleatorio
            int numerador = random.Next(1, 50); // Número aleatorio en el numerador

            // Generar un denominador asegurando que no sea 0
            int denominador;
            do
            {
                denominador = random.Next(1, 20);
            } while (denominador == 0);

            // Paso 1: Mostrar la expresión original
            string paso1 = $"<p><b>Paso 1:</b> El ejemplo que vamos a resolver es: <b>√({numerador}/{denominador})</b></p>";

            // Paso 2: Separación de la raíz
            double raizNumerador = Math.Sqrt(numerador);  // Raíz cuadrada del numerador
            double raizDenominador = Math.Sqrt(denominador);  // Raíz cuadrada del denominador

            // Paso 3: Mostrar el resultado de separar la raíz
            string paso2 = $"<p><b>Paso 2:</b> Separamos la raíz en el numerador y denominador, obteniendo: <b>{raizNumerador:F2} / {raizDenominador:F2}</b>.</p>";

            // Paso 4: Resultado final
            string resultado = $"<p><b>Paso 3:</b> El resultado final de la expresión es: <b>{raizNumerador:F2} / {raizDenominador:F2}</b>.</p>";

            // Construir el ejemplo completo
            string ejemplo = $"<p><b>Ejemplo:</b> √({numerador}/{denominador})</p>";

            // Mostrar todo en el control LiteralRadicalFraccion
            LiteralRadicalFraccion.Text = ejemplo + paso1 + paso2 + resultado;
        }

        private void GenerarEjemploRaizPotencia(Random random)
        {
            // Paso 1: Generación de números aleatorios
            int baseNumero = random.Next(2, 10); // Base de la potencia
            int exponente = random.Next(2, 10); // Exponente
            int indiceRaiz = random.Next(2, 5); // Índice de la raíz (cuadrada, cúbica, etc.)

            // Paso 2: Construcción del ejemplo
            string paso1 = $"<p><b>Paso 1:</b> El ejemplo que vamos a resolver es: <b>√[{indiceRaiz}]{baseNumero}^{exponente}</b></p>";

            // Paso 3: Cálculo de la raíz de la potencia
            double resultado = Math.Pow(baseNumero, (double)exponente / indiceRaiz);
            string paso2 = $"<p><b>Paso 2:</b> Calculamos la raíz de la potencia utilizando la fórmula: <b>{baseNumero}^({exponente}/{indiceRaiz})</b> = {resultado:F2}</p>";

            // Paso 4: Resultado final
            string resultadoTexto = $"<p><b>Paso 3:</b> El resultado final es: <b>{resultado:F2}</b></p>";

            // Paso 5: Mostrar todo el ejemplo
            string ejemplo = $"<p><b>Ejemplo:</b> √[{indiceRaiz}]{baseNumero}^{exponente}</p>";

            // Mostrar todo en el control LiteralRaizPotencia
            LiteralRaizPotencia.Text = ejemplo + paso1 + paso2 + resultadoTexto;
        }

        private void GenerarEjemploRaizFraccion(Random random)
        {
            // Paso 1: Generación de números aleatorios
            int numerador = random.Next(1, 100); // Numerador aleatorio
            int denominador;

            // Asegurarse que el denominador no sea 0
            do
            {
                denominador = random.Next(1, 50); // Denominador aleatorio
            } while (denominador == 0);

            int indiceRaiz = random.Next(2, 4); // Índice de la raíz (cuadrada o cúbica)

            // Paso 2: Construcción del ejemplo
            string paso1 = $"<p><b>Paso 1:</b> El ejemplo que vamos a resolver es: <b>√[{indiceRaiz}]({numerador}/{denominador})</b></p>";

            // Paso 3: Cálculo de la raíz para numerador y denominador
            double raizNumerador = Math.Pow(numerador, 1.0 / indiceRaiz);
            double raizDenominador = Math.Pow(denominador, 1.0 / indiceRaiz);
            string paso2 = $"<p><b>Paso 2:</b> Calculamos la raíz para el numerador y el denominador. Esto da: <b>{raizNumerador:F2} / {raizDenominador:F2}</b></p>";

            // Paso 4: Mostrar el resultado
            string resultadoTexto = $"<p><b>Paso 3:</b> El resultado final es: <b>{raizNumerador:F2} / {raizDenominador:F2}</b></p>";

            // Paso 5: Mostrar todo el ejemplo
            string ejemplo = $"<p><b>Ejemplo:</b> √[{indiceRaiz}]({numerador}/{denominador})</p>";

            // Mostrar todo en el control LiteralRaizFraccion
            LiteralRaizFraccion.Text = ejemplo + paso1 + paso2 + resultadoTexto;
        }


        private void GenerarEjemploOperacionRadicales(Random random)
        {
            // Paso 1: Generación de bases e índices de raíz aleatorios
            int base1 = random.Next(2, 20);  // Base del primer radical
            int base2 = random.Next(2, 20);  // Base del segundo radical
            int indiceRaiz1 = random.Next(2, 5);  // Índice del primer radical (raíz cuadrada, cúbica, etc.)
            int indiceRaiz2 = random.Next(2, 5);  // Índice del segundo radical (raíz cuadrada, cúbica, etc.)

            // Paso 2: Crear la expresión original
            string ejemplo = $"Ejemplo: √[{indiceRaiz1}]{base1} + √[{indiceRaiz2}]{base2}";

            // Paso 3: Calcular las raíces de las bases con sus respectivos índices
            double resultado1 = Math.Pow(base1, 1.0 / indiceRaiz1);  // Raíz del primer radical
            double resultado2 = Math.Pow(base2, 1.0 / indiceRaiz2);  // Raíz del segundo radical

            // Paso 4: Sumar los resultados
            double resultadoSuma = resultado1 + resultado2;

            // Paso 5: Construir el texto con el resultado final
            string resultadoTexto = $"= {resultado1:F2} + {resultado2:F2} = {resultadoSuma:F2}";

            // Paso 6: Mostrar el ejemplo y el resultado en el control Literal
            LiteralOperacionRadicales.Text = ejemplo + " " + resultadoTexto;
        }


        // ==================== EJERCICIO DE SUMA ====================
        protected void GenerarEjercicioSuma()
        {
            int coef1 = random.Next(1, 10);
            int coef2 = random.Next(1, 10);
            int radicando = random.Next(2, 50);

            string ejercicio = $"Resuelve: {coef1}√{radicando} + {coef2}√{radicando}";
            Session["RespuestaSuma"] = (coef1 + coef2) + "√" + radicando;

            LiteralEjercicioSuma.Text = $"<p>{ejercicio}</p>";
        }

        protected void VerificarEjercicioSuma(object sender, EventArgs e)
        {
            string respuestaUsuario = txtRespuestaSuma.Text.Trim();
            string respuestaCorrecta = Session["RespuestaSuma"].ToString();

            lblResultadoSuma.Text = respuestaUsuario == respuestaCorrecta ? "✅ ¡Correcto!" : "❌ Incorrecto, intenta de nuevo.";
        }

        // ==================== EJERCICIO DE RESTA ====================
        protected void GenerarEjercicioResta()
        {
            int coef1 = random.Next(5, 15);
            int coef2 = random.Next(1, 5);
            int radicando = random.Next(2, 50);

            string ejercicio = $"Resuelve: {coef1}√{radicando} - {coef2}√{radicando}";
            Session["RespuestaResta"] = (coef1 - coef2) + "√" + radicando;

            LiteralEjercicioResta.Text = $"<p>{ejercicio}</p>";
        }

        protected void VerificarEjercicioResta(object sender, EventArgs e)
        {
            string respuestaUsuario = txtRespuestaResta.Text.Trim();
            string respuestaCorrecta = Session["RespuestaResta"].ToString();

            lblResultadoResta.Text = respuestaUsuario == respuestaCorrecta ? "✅ ¡Correcto!" : "❌ Incorrecto, intenta de nuevo.";
        }

        // ==================== EJERCICIO DE MULTIPLICACIÓN ====================
        protected void GenerarEjercicioMultiplicacion()
        {
            int numero1 = random.Next(2, 20);
            int numero2 = random.Next(2, 20);

            string ejercicio = $"Resuelve: √{numero1} * √{numero2}";
            Session["RespuestaMultiplicacion"] = "√" + (numero1 * numero2);

            LiteralEjercicioMultiplicacion.Text = $"<p>{ejercicio}</p>";
        }

        protected void VerificarEjercicioMultiplicacion(object sender, EventArgs e)
        {
            string respuestaUsuario = txtRespuestaMultiplicacion.Text.Trim();
            string respuestaCorrecta = Session["RespuestaMultiplicacion"].ToString();

            lblResultadoMultiplicacion.Text = respuestaUsuario == respuestaCorrecta ? "✅ ¡Correcto!" : "❌ Incorrecto, intenta de nuevo.";
        }

        // ==================== EJERCICIO DE DIVISIÓN ====================
        protected void GenerarEjercicioDivision()
        {
            int num = random.Next(2, 20);
            int den;
            do
            {
                den = random.Next(2, 10);
            } while (den == 0); // Evitar división por cero

            string ejercicio = $"Resuelve: √{num} / √{den}";
            Session["RespuestaDivision"] = "√" + (num / den);

            LiteralEjercicioDivision.Text = $"<p>{ejercicio}</p>";
        }

        protected void VerificarEjercicioDivision(object sender, EventArgs e)
        {
            string respuestaUsuario = txtRespuestaDivision.Text.Trim();
            string respuestaCorrecta = Session["RespuestaDivision"].ToString();

            lblResultadoDivision.Text = respuestaUsuario == respuestaCorrecta ? "✅ ¡Correcto!" : "❌ Incorrecto, intenta de nuevo.";
        }

        // ==================== EJERCICIO DE RACIONALIZACIÓN ====================
        protected void GenerarEjercicioRacionalizacion()
        {
            int numerador = random.Next(1, 20);
            int denominador = random.Next(2, 10);  // Para evitar división entre cero

            string ejercicio = $"Resuelve: {numerador} / √{denominador}";
            double resultado = Math.Round(numerador * Math.Sqrt(denominador), 2);
            Session["RespuestaRacionalizacion"] = $"{numerador}√{denominador} / {denominador}";

            LiteralEjercicioRacionalizacion.Text = $"<p>{ejercicio}</p>";
        }

        protected void VerificarEjercicioRacionalizacion(object sender, EventArgs e)
        {
            string respuestaUsuario = txtRespuestaRacionalizacion.Text.Trim();
            string respuestaCorrecta = Session["RespuestaRacionalizacion"].ToString();

            lblResultadoRacionalizacion.Text = respuestaUsuario == respuestaCorrecta ? "✅ ¡Correcto!" : "❌ Incorrecto, intenta de nuevo.";
        }
        protected void GenerarNuevosEjercicios(object sender, EventArgs e)
        {

            // Crear una instancia de Random para generar los números aleatorios
            Random random = new Random();
            // Generar un ejercicio nuevo para cada tipo de operación

            // Ejercicio de Suma
            GenerarEjercicioSuma();

            // Ejercicio de Resta
            GenerarEjercicioResta();

            // Ejercicio de Multiplicación
            GenerarEjercicioMultiplicacion();

            // Ejercicio de División
            GenerarEjercicioDivision();

            // Ejercicio de Racionalización
            GenerarEjercicioRacionalizacion();
        }

    }
}