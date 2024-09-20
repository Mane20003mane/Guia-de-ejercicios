using System;
using System.Web.UI;

namespace ejercicio4
{
    public partial class leernotas : Page
    {
        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener las notas ingresadas
            double e1 = Convert.ToDouble(txtE1.Text);
            double e2 = Convert.ToDouble(txtE2.Text);
            double e3 = Convert.ToDouble(txtE3.Text);
            double e4 = Convert.ToDouble(txtE4.Text);
            double e5 = Convert.ToDouble(txtE5.Text);

            // Redirigir a la página de notas y pasar los valores
            Response.Redirect($"notas.aspx?e1={e1}&e2={e2}&e3={e3}&e4={e4}&e5={e5}");
        }

    }
}
