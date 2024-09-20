using System;
using System.Web.UI;

namespace TuProyecto
{
    public partial class Ejercicio6 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // Evento para el botón de la imagen 1
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            MostrarTablaDeMultiplicar(1);
        }

        // Evento para el botón de la imagen 2
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            MostrarTablaDeMultiplicar(2);
        }

        // Evento para el botón de la imagen 3
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            MostrarTablaDeMultiplicar(3);
        }

        // Evento para el botón de la imagen 4
        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            MostrarTablaDeMultiplicar(4);
        }

        // Evento para el botón de la imagen 5
        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            MostrarTablaDeMultiplicar(5);
        }

        // Evento para el botón de la imagen 6
        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            MostrarTablaDeMultiplicar(6);
        }

        // Evento para el botón de la imagen 7
        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            MostrarTablaDeMultiplicar(7);
        }

        // Evento para el botón de la imagen 8
        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            MostrarTablaDeMultiplicar(8);
        }

        // Evento para el botón de la imagen 9
        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            MostrarTablaDeMultiplicar(9);
        }

        // Método para generar la tabla de multiplicar
        private void MostrarTablaDeMultiplicar(int numero)
        {
            string tabla = $"<h2>Tabla de multiplicar del {numero}</h2><br/>";
            for (int i = 1; i <= 10; i++)
            {
                tabla += $"{numero} x {i} = {numero * i}<br/>";
            }
            lblTablaMultiplicar.Text = tabla;
        }
    }
}
