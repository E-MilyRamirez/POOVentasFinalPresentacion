namespace POOVentasFinal
{
    internal class VentaCredito : Venta
    {
        public override decimal CalcularTotal()
        {
            decimal incremento = 1.05m; //5% de incremento
            decimal total = base.CalcularTotal();
            decimal totalConIncremento = total * incremento;
            return totalConIncremento;
        }
    }
}
