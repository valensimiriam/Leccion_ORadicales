<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Radicales.aspx.cs" Inherits="Leccion_ORadicales.Radicales" %>

<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Operaciones con Radicales</title>
    <link rel="stylesheet" href="~/css/style.css">
</head>

<body>
    <header>
        <h1>Operaciones con Radicales</h1>
        <nav>
            <ul>
                <li><a href="#conceptos">Conceptos</a></li>
                <li><a href="#practica">Práctica</a></li>
                <li><a href="graficos.html">Evaluación</a></li>
            </ul>
        </nav>
    </header>

    <section id="introduccion">
        <h2>¿Qué son los Radicales?</h2>
        <p>Un radical es una expresión matemática que involucra raíces. Por ejemplo, la raíz cuadrada de un número 'x' se representa como √x.</p>
        <p>Existen diferentes tipos de radicales: raíces cuadradas, cúbicas, cuartas, etc.</p>
    </section>

    <section id="conceptos">
        <h2>Conceptos Básicos</h2>
        <p>Las <strong>operaciones con radicales</strong> son aquellas que se realizan con raíces, como la raíz cuadrada, raíz cúbica, entre otras.</p>

           
    </section>

    <section id="operaciones">
        <h2>Operaciones Básicas con Radicales</h2>

        <h3>Suma de Radicales</h3>
        <p>Para sumar radicales, deben tener el mismo índice y el mismo radicando. Por ejemplo:</p>
        <p>Ejemplo:</p>
        <form id="form1" runat="server">
         <asp:ScriptManager runat="server" />
        
        <!-- Panel para Suma de Radicales -->
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:Button ID="btnSumaRadicales" runat="server" Text="Generar Suma de Radicales" OnClick="btnSumaRadicales_Click" />
                <asp:Literal ID="LiteralSumaRadicales" runat="server" />
            </ContentTemplate>
        </asp:UpdatePanel>
        


        <h3>Resta de Radicales</h3>
        <p>Al igual que con la suma, la resta solo es posible cuando los radicales tienen el mismo índice y radicando.</p>
        <p>√5 - √5 = 0</p>

        <h3>Multiplicación de Radicales</h3>
        <p>Para multiplicar radicales, se multiplican los radicandos:</p>
        <h3>Ejemplo:</h3>
        
          <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:Literal ID="LiteralMultiplicacion" runat="server"></asp:Literal>
                <asp:Button ID="Button1" runat="server" Text="Generar Ejemplo" OnClick="btnNuevoEjemplo_Click" />
            </ContentTemplate>
        </asp:UpdatePanel>
            

        <h3>División de Radicales</h3>
        <p>Para dividir radicales, se dividen los radicandos:</p>
        <p>√8 ÷ √2 = √4 = 2</p>
             </form>
    </section>


    <section id="propiedades">
        <h2>Propiedades de los Radicales</h2>
        <ul>
            <li>√a * √b = √(a * b)</li>
            <li>√a / √b = √(a / b)</li>
            <li>(√a)^2 = a</li>
            <li>√(a * b) = √a * √b</li>
        </ul>
    </section>

    <section id="ejercicios">
        <h2>Ejercicios Prácticos</h2>
        <p>Resuelve los siguientes ejercicios:</p>
        <form>
            <label for="ejercicio1">√16 + √9 = </label>
            <input type="text" id="ejercicio1">

            <label for="ejercicio2">√25 * √4 = </label>
            <input type="text" id="ejercicio2">

            <button type="submit">Verificar Respuestas</button>
        </form>
    </section>

    <section id="conclusion">
        <h2>Conclusión</h2>
        <p>Las operaciones con radicales requieren práctica, así que asegúrate de seguir resolviendo ejercicios para mejorar tu habilidad. Recuerda que la clave es entender bien las propiedades de los radicales.</p>
    </section>





    <section id="evaluacion">
        <h2>Reactivos</h2>
        <p>Responde las siguientes preguntas.</p>
    </section>

    <script>
        // Este script es para manejar la interacción del front-end si es necesario.
        // Si quieres que el botón de cambio de ejemplo sea solo del lado del servidor, no hace falta.
    </script>

</body>

</html>
