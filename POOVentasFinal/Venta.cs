namespace POOVentasFinal
{
    internal abstract class Venta
    {
        public decimal Total

        {
            get
            {
                return CalcularTotal();
            }

        }
        //Lista con constructor, los Conceptos son los Productos


        //[] indica para iniciar la lista
        public List<ConceptoVenta> Conceptos { get; set; } = [];

        public virtual decimal CalcularTotal()
        {
            decimal total = 0.00m;
            foreach (ConceptoVenta concepto in Conceptos) 
            {
                total += concepto.Importe;
            }
            return total;
        }
    }
}
