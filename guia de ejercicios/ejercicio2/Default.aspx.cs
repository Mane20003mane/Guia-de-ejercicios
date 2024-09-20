using System;
using System.Web.UI;

namespace SalarioNetoCalculator
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TxtSalarioBruto.Text, out double salarioBruto))
            {
                (double salarioNeto, double descuentoIsss, double descuentoRenta, double descuentoAfp, double descuentoSeguro)
                    = CalcularSalarioNeto(salarioBruto);

                LblResultado.Text = $"El salario neto es: ${salarioNeto:F2}";
                LblDescuentoIsss.Text = $"Descuento ISSS: ${descuentoIsss:F2}";
                LblDescuentoRenta.Text = $"Descuento Renta: ${descuentoRenta:F2}";
                LblDescuentoAfp.Text = $"Descuento AFP: ${descuentoAfp:F2}";
                LblDescuentoSeguro.Text = $"Descuento Seguro: ${descuentoSeguro:F2}";
            }
            else
            {
                LblResultado.Text = "Por favor, ingrese un salario válido.";
                LimpiarDescuentos();
            }
        }

        private (double salarioNeto, double isss, double renta, double afp, double seguro) 
            CalcularSalarioNeto(double salarioBruto)
        {
            double descuentoIsss = salarioBruto > 657.25 ? salarioBruto * 0.03 : 0;
            double descuentoRenta = salarioBruto > 857.15 ? salarioBruto * 0.10 : 0;
            double descuentoAfp = salarioBruto > 450.00 ? salarioBruto * 0.05 : 0;
            double descuentoSeguro = salarioBruto < 1000 ? salarioBruto * 0.04 : salarioBruto * 0.06;

            double totalDescuentos = descuentoIsss + descuentoRenta + descuentoAfp + descuentoSeguro;
            double salarioNeto = salarioBruto - totalDescuentos;

            return (salarioNeto, descuentoIsss, descuentoRenta, descuentoAfp, descuentoSeguro);
        }

        private void LimpiarDescuentos()
        {
            LblDescuentoIsss.Text = string.Empty;
            LblDescuentoRenta.Text = string.Empty;
            LblDescuentoAfp.Text = string.Empty;
            LblDescuentoSeguro.Text = string.Empty;
        }
    }
}