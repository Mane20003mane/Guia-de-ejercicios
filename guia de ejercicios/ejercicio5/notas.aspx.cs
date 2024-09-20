using System;
using System.Web.UI;

namespace ejercicio4
{
    public partial class notas : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Obtener las notas de la URL
            double e1 = Convert.ToDouble(Request.QueryString["e1"]);
            double e2 = Convert.ToDouble(Request.QueryString["e2"]);
            double e3 = Convert.ToDouble(Request.QueryString["e3"]);
            double e4 = Convert.ToDouble(Request.QueryString["e4"]);
            double e5 = Convert.ToDouble(Request.QueryString["e5"]);

            // Definir los porcentajes de las evaluaciones
            double p1 = 0.2;  // 20%
            double p2 = 0.2;  // 20%
            double p3 = 0.2;  // 20%
            double p4 = 0.2;  // 20%
            double p5 = 0.2;  // 20%

            // Calcular los puntos ganados
            double pg1 = e1 * p1;
            double pg2 = e2 * p2;
            double pg3 = e3 * p3;
            double pg4 = e4 * p4;
            double pg5 = e5 * p5;

            // Calcular la nota final
            double notaFinal = pg1 + pg2 + pg3 + pg4 + pg5;

            // Mostrar las notas, porcentajes y puntos ganados
            lblE1.Text = e1.ToString();
            lblP1.Text = (p1 * 100).ToString() + "%";
            lblPG1.Text = pg1.ToString();

            lblE2.Text = e2.ToString();
            lblP2.Text = (p2 * 100).ToString() + "%";
            lblPG2.Text = pg2.ToString();

            lblE3.Text = e3.ToString();
            lblP3.Text = (p3 * 100).ToString() + "%";
            lblPG3.Text = pg3.ToString();

            lblE4.Text = e4.ToString();
            lblP4.Text = (p4 * 100).ToString() + "%";
            lblPG4.Text = pg4.ToString();

            lblE5.Text = e5.ToString();
            lblP5.Text = (p5 * 100).ToString() + "%";
            lblPG5.Text = pg5.ToString();

            // Mostrar la nota final
            lblNotaFinal.Text = notaFinal.ToString();
        }
    }
}
