using System;

namespace ejercicio4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            
            decimal montoCompra = 0;
            bool esValido = decimal.TryParse(txtMonto.Text, out montoCompra);

            // Validar si el valor ingresado es un número válido
            if (esValido && montoCompra > 0)
            {
                decimal descuento = 0;

                
                if (montoCompra >= 0.01m && montoCompra <= 1000.00m)
                {
                    descuento = 0.10m; // 10% de descuento
                }
                else if (montoCompra >= 1000.01m && montoCompra <= 3000.00m)
                {
                    descuento = 0.20m; // 20% de descuento
                }
                else if (montoCompra >= 3000.01m)
                {
                    descuento = 0.30m; // 30% de descuento
                }

                
                decimal montoDescuento = montoCompra * descuento;
                decimal totalPagar = montoCompra - montoDescuento;

                
                lblResultado.Text = $"El descuento aplicado es del {descuento * 100}%" +
                    $" ({montoDescuento:C2}).<br />El total a pagar es: {totalPagar:C2}.";
            }
            else
            {
                lblResultado.Text = "Por favor, ingresa un monto válido.";
            }
        }
    }
}
