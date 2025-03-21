
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Radicales.aspx.cs" Inherits="Leccion_ORadicales.Radicales" %>

<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Operaciones con Radicales</title>
    <link rel="stylesheet" href="~/css/style.css">
    <script>
        function insertarRaiz(textBoxId) {
            var txt = document.getElementById(textBoxId);
            txt.value += "√"; // Agrega el símbolo al final del texto
            txt.focus(); // Mantiene el cursor en el TextBox
        }
    </script>
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
        <p>Un radical es cualquier raíz indicada de una expresión. La radicación es la operación inversa de la
potenciación y se representa por el símbolo n
, donde n es el índice del radical y dentro se ubica una
expresión denominada subradical.

        </p> <li>( Espinoza, () )</li>
        
        
    </section>


    <section id="definiciones">
        <h2>Radicales de índice y radicando</h2>
        <p>El <strong>índice</strong> de un radical indica el tipo de raíz: por ejemplo, el índice 2 corresponde a la raíz cuadrada, el índice 3 a la raíz cúbica, etc. Si el índice no está escrito, se asume que es 2. .</p>
        <p>El  <strong>radicando</strong>  es el número dentro del radical del cual se va a extraer la raíz. </p>

        <h2>Propiedades de los radicales</h2>
        <p>
            Las <strong>propiedades de los radicales </strong>son operaciones que permiten solucionar problemas complejos de radicales y potencias. El radical es la forma de simbolizar 
             matemáticamente a la raíz n-ésima de una cantidad “a”. Dicha raíz es otra cantidad, llamada “b”, tal que su potencia n-ésima es precisamente “a”, de modo que es válido escribir lo siguiente:
        </p>

         
        <p>
            El valor de “n” es un número natural, el cual se conoce como el índice de la raíz, “a” es el radicando o  cantidad subradical, y “b” es la raíz n-ésima de “a”. Tanto “a” como “b” pertenecen al conjunto de los números reales.

Si en un radical no se escribe el índice, se entiende de inmediato que su valor es igual a 2 y se lee “raíz cuadrada de a”.

Dado que “n” pertenece al conjunto de los números naturales, puede tratarse de un número par o impar.
        </p>
        <p>Lifeder, (2022).</p>

         
 
        <strong>Ejemplos:</strong>
        <p>Producto de radicales:  <strong>&radic;a &times; &radic;b = &radic;(a &times; b) </strong> </p> 
        <p>Cociente de radicales: <strong>&radic;a / &radic;b = &radic;(a / b) </strong></p>
        <p>Raíz de un producto: <strong>&radic;&sup2;(a &times; b) = &radic;&sup2;(a) &times; &radic;&sup2;(b)</strong></p>
        <p>Raíz de una potencia: <strong>&radic;&sup2;(a^m) = a^(m/&sup2;)</strong></p>
        <p>Suma y resta de radicales: (con el mismo radicando): <strong>&radic;2 + &radic;2 = 2 &radic;2</strong> </p>
        <p>Simplificación de radicales: <strong>&radic;8 = &radic;4 &times; 2 = 2 &radic;2</strong></p>
        <p>Racionalización de radicales: <strong>1 / &radic;2 &times; &radic;2 / &radic;2 = &radic;2 / 2</strong></p>
        <p>Resolución de ecuaciones con radicales:  <strong>&radic;(x+3) = 5 &rarr; x + 3 = 25 &rarr; x = 22</strong></p>

    </section>

    <section id="conceptos">
        <h2>Conceptos Básicos</h2>
        <p>Las <strong>operaciones con radicales</strong> son aquellas que se realizan con raíces, como la raíz cuadrada, raíz cúbica, entre otras.</p>

           
    </section>



    <section id="operaciones">
        <h2>Operaciones Básicas con Radicales</h2>

        <h2>Simplificación de radicales</h2>
        <strong>Simplificación</strong> <p>Si el radicando tiene factores que son potencias perfectas (como 4, 9,16, etc.), puedes extraer la raíz de esos factores fuera del radical.
    Por ejemplo:  <strong>&radic;8 = &radic;4&times;2 = 2&radic;2</strong></p>


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

            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    
                    <asp:Button ID="btnRestaRadicales" runat="server" Text="Generar Resta de radicales" OnClick="btnRestaRadicales_Click" />
                    <asp:Literal ID="LiteralRestaRadicales" runat="server" />
                </ContentTemplate>
            </asp:UpdatePanel>





        <h3>Multiplicación de Radicales</h3>
        <p>Para multiplicar radicales, se multiplican los radicandos:</p>
            <strong>Fórmula: &radic;a &times;  &radic;b  = &radic;a&times;b</strong>
        <h3>Ejemplo:</h3>
        
          <asp:UpdatePanel runat="server">
            <ContentTemplate>
               
                <asp:Button ID="Button1" runat="server" Text="Generar Ejemplo" OnClick="btnNuevoEjemplo_Click" />
                 <asp:Literal ID="LiteralMultiplicacion" runat="server"></asp:Literal>
            </ContentTemplate>
        </asp:UpdatePanel>
            

        <h3>División de Radicales</h3>
        <p>Para dividir radicales, se dividen los radicandos:</p>
            <strong>Fórmula:  &radic;a /  &radic;b =  &radic;a / &radic;b </strong>
        <p>Ejemplo:  &radic;6 /  &radic;2 =  &radic;6 / &radic;2 = &radic;3</p>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    
                    <asp:Button ID="btnDivisionRadicales" runat="server" Text="Generar División de Radicales" OnClick="btnDivisionRadicales_Click" />
                    <asp:Literal ID="LiteralDivisionRadicales" runat="server"/>
                </ContentTemplate>
            </asp:UpdatePanel>








            <h3>Racionalización de radicales</h3>
            <p>es el proceso de eliminar un radical del denominador de una fracción. Esto se logra multiplicando tanto el numerador como el denominador de la fracción por el radical en el denominador. Esto es importante porque, en matemáticas, 
                generalmente preferimos no tener raíces en los denominadores.</p>
           <p> <strong>Con un solo radical en el denominador: </strong> Multiplica el numerador y denominador por el mismo radical.</p> 
            <p><strong>Con una suma o resta de radicales:</strong> Multiplica por el conjugado del denominador. </p>
            <p><strong>Con fracciones dentro de radicales:</strong>Simplifica primero y luego racionaliza como en el caso del radical simple.</p>
            <strong>Ejercicio</strong>
             <p><strong>Objetivo:</strong>  Eliminar los radicales en el denominador de una fracción.</p>
            <p><strong>Proceso:</strong> Se multiplica el numerador y el denominador por el radical del denominador.</p>
            <strong>Ejemplo:  1 / &radic;2  &times;  &radic;2 / &radic;2 =  &radic;2 / 2  </strong>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    
                    <asp:Button ID="btnRacionalizacion" runat="server" Text="Generar Ejemplo de Racionalización" OnClick="btnRacionalizar_Click" />
                    <asp:Literal ID="LiteralRacionalizacion" runat="server"/>
                </ContentTemplate>
            </asp:UpdatePanel>










            <h3>Radicales de fracciones</h3>
            <p> Se puede aplicar la raíz a los numeradores y denominadores por separado. </p>
            <strong> Fórmula:  &radic;a/b  =  &radic;a/b </strong> <br />
            <strong>Ejemplo:   &radic;9/16  =  &radic;9/&radic;b = 3/4   </strong>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Literal ID="LiteralRadicalFracc" runat="server"></asp:Literal>
                    <asp:Button ID="LiteralRadicalFraccion" runat="server" Text="Generar Radical de Fracción" OnClick="btnRadicalFraccion_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>



            <h3>Ráíz de una potencia</h3>
            <p> Cuando el radicando es una potencia, se puede simplificar usando las propiedades de las potencias.</p>
            <strong>Fórmula:  </strong> <br />
             <strong>Ejemplo:  </strong>

            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Literal ID="LiteralRaizPotencia" runat="server"></asp:Literal>
                    <asp:Button ID="btnRaizPotencia" runat="server" Text="Generar Raíz de Potencia" OnClick="btnRaizPotencia_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>



            <h3>Raíz de una fracción</h3>
            <p>La raíz de una fracción es igual a la raíz del numerador sobre la raíz del denominador.</p>
            <strong>Fórmula:  </strong>
            <br />
            <strong>Ejemplo:  </strong>

            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Literal ID="LiteralRaizFraccion" runat="server"></asp:Literal>
                    <asp:Button ID="btnRaizFraccion" runat="server" Text="Generar Raíz de Fracción" OnClick="btnRaizFraccion_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>




            <h3>Operaciones con radicales de índices distintos</h3>
            <p>Si los radicales tienen índices diferentes, se deben hacer coincidir los índices antes de operar con ellos.</p>
             <strong>Ejemplo: Para sumar &radic;2 y 3&radic;2, primero debes expresar ambos con el  mismo índice. </strong>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Literal ID="LiteralOperacionRadicales" runat="server"></asp:Literal>
                    <asp:Button ID="btnOperacionRadicales" runat="server" Text="Generar Operación con Radicales de Índices Distintos" OnClick="btnOperacionRadicales_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>





             <section id="ejercicios">
     <h2>Ejercicios Prácticos</h2>
     <p>Resuelve los siguientes ejercicios:</p>
                 <asp:UpdatePanel ID="UpdatePanelEjercicios" runat="server">
                     <ContentTemplate>
     
     <div>
         <h2>Ejercicio de Suma de Radicales</h2>
         <asp:Literal ID="LiteralEjercicioSuma" runat="server"></asp:Literal>
         <asp:TextBox ID="txtRespuestaSuma" runat="server"></asp:TextBox>
         <asp:Button ID="btnInsertarRaiz" runat="server" Text="√" OnClientClick="insertarRaiz('txtRespuestaSuma'); return false;" />
         <asp:Button ID="btnVerificarSuma" runat="server" Text="Verificar" OnClick="VerificarEjercicioSuma" />
         <asp:Label ID="lblResultadoSuma" runat="server"></asp:Label>

         <h2>Ejercicio de Resta de Radicales</h2>
         <asp:Literal ID="LiteralEjercicioResta" runat="server"></asp:Literal>
         <asp:TextBox ID="txtRespuestaResta" runat="server"></asp:TextBox>
         <asp:Button ID="Button2" runat="server" Text="√" OnClientClick="insertarRaiz('txtRespuestaSuma'); return false;" />
         <asp:Button ID="btnVerificarResta" runat="server" Text="Verificar" OnClick="VerificarEjercicioResta" />
         <asp:Label ID="lblResultadoResta" runat="server"></asp:Label>

         <h2>Ejercicio de Multiplicación de Radicales</h2>
         <asp:Literal ID="LiteralEjercicioMultiplicacion" runat="server"></asp:Literal>
         <asp:TextBox ID="txtRespuestaMultiplicacion" runat="server"></asp:TextBox>
         <asp:Button ID="Button3" runat="server" Text="√" OnClientClick="insertarRaiz('txtRespuestaSuma'); return false;" />
         <asp:Button ID="btnVerificarMultiplicacion" runat="server" Text="Verificar" OnClick="VerificarEjercicioMultiplicacion" />
         <asp:Label ID="lblResultadoMultiplicacion" runat="server"></asp:Label>

         <h2>Ejercicio de División de Radicales</h2>
         <asp:Literal ID="LiteralEjercicioDivision" runat="server"></asp:Literal>
         <asp:TextBox ID="txtRespuestaDivision" runat="server"></asp:TextBox>
         <asp:Button ID="Button4" runat="server" Text="√" OnClientClick="insertarRaiz('txtRespuestaSuma'); return false;" />
         <asp:Button ID="btnVerificarDivision" runat="server" Text="Verificar" OnClick="VerificarEjercicioDivision" />
         <asp:Label ID="lblResultadoDivision" runat="server"></asp:Label>

         <h2>Ejercicio de Racionalización</h2>
         <asp:Literal ID="LiteralEjercicioRacionalizacion" runat="server"></asp:Literal>
         <asp:TextBox ID="txtRespuestaRacionalizacion" runat="server"></asp:TextBox>
         <asp:Button ID="Button5" runat="server" Text="√" OnClientClick="insertarRaiz('txtRespuestaSuma'); return false;" />
         <asp:Button ID="btnVerificarRacionalizacion" runat="server" Text="Verificar" OnClick="VerificarEjercicioRacionalizacion" />
         <asp:Label ID="lblResultadoRacionalizacion" runat="server"></asp:Label>


         <asp:Button ID="btnGenerarEjercicios" runat="server" Text="Generar Nuevo Ejercicio" OnClick="GenerarNuevosEjercicios" />


     </div>
                     </ContentTemplate>
                 </asp:UpdatePanel>
 
 </section>



             </form>
    </section>
    <p>StudySmarter, (2022).</p>

    


    

   

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

    <section id="referencias">
    <h2>Referencias</h2>
        <p>Espinoza, J (). <i>Matemáticas Básicas</i>.Facultad de Contaduría y Administración. UNAM.  Recuperado de <a hrfe="enlace_al_pdf.pdf">http://132.248.164.227/publicaciones/docs/apuntes_matematicas/09.%20Radicales.pdf</a> http://www.acervodigital.cab.unam.mx/materiales/mate/dr_becerra/libro_mate_IV/m4-unidad02/files/basic-html/page61.html</p>
        <p>Lifeder, (2022). <i>Propiedades de los radicales</i>.Lifeder.  Recuperado de <a hrfe="enlace_al_pdf.pdf">https://www.lifeder.com/propiedades-radicales/</a></p>
          <p>StudySmarter, (2022). <i>Analisis matematico</i>.StudySmarter.  Recuperado de <a hrfe="enlace_al_pdf.pdf">https://www.studysmarter.es/resumenes/matematicas/analisis-matematico/radicales/</a></p>



</section>


</body>

</html>
