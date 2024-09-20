using System;
using System.Web.UI.WebControls;

namespace MultiplicacionApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Generar botones del 1 al 100 solo la primera vez que carga la página
            GenerarBotones();
        }

        private void GenerarBotones()
        {
            // Crear 100 botones con números del 1 al 100
            for (int i = 1; i <= 100; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.CssClass = "number-btn";
                btn.Click += new EventHandler(Boton_Click);
                PanelNumeros.Controls.Add(btn);
            }
        }

        protected void Boton_Click(object sender, EventArgs e)
        {
            // Obtener el número del botón que fue presionado
            Button btn = (Button)sender;
            int numero = int.Parse(btn.Text);

            // Mostrar la tabla de multiplicación para el número seleccionado
            MostrarTablaMultiplicacion(numero);
        }

        private void MostrarTablaMultiplicacion(int numero)
        {
            string tablaHtml = "<table>";
            for (int i = 1; i <= 10; i++)
            {
                tablaHtml += $"<tr><td>{numero} x {i}</td><td>{numero * i}</td></tr>";
            }
            tablaHtml += "</table>";

            lblTabla.Text = tablaHtml;
        }
    }
}
