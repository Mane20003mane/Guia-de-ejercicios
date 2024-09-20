using System;
using System.Web.UI;

namespace DescuentoCalculator
{
    public partial class CalculoDescuento : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidadArticulos.Text, out int cantidadArticulos) &&
                double.TryParse(txtPrecioUnitario.Text, out double precioUnitario))
            {
                if (cantidadArticulos > 0 && precioUnitario > 0)
                {
                    double totalSinDescuento = cantidadArticulos * precioUnitario;
                    double descuento = CalcularDescuento(cantidadArticulos, totalSinDescuento);
                    double totalConDescuento = totalSinDescuento - descuento;

                    lblResultado.Text = $"Total sin descuento: ${totalSinDescuento:F2}<br/>" +
                                        $"Descuento aplicado: ${descuento:F2}<br/>" +
                                        $"Total a pagar: ${totalConDescuento:F2}";
                }
                else
                {
                    lblResultado.Text = "Por favor, ingrese valores mayores que cero.";
                }
            }
            else
            {
                lblResultado.Text = "Por favor, ingrese valores numéricos válidos.";
            }
        }

        private double CalcularDescuento(int cantidadArticulos, double totalCompra)
        {
            double porcentajeDescuento;

            if (cantidadArticulos >= 21)
            {
                porcentajeDescuento = 0.50;
            }
            else if (cantidadArticulos >= 16)
            {
                porcentajeDescuento = 0.40;
            }
            else if (cantidadArticulos >= 11)
            {
                porcentajeDescuento = 0.30;
            }
            else if (cantidadArticulos >= 6)
            {
                porcentajeDescuento = 0.20;
            }
            else
            {
                porcentajeDescuento = 0.10;
            }

            return totalCompra * porcentajeDescuento;
        }
    }
}