﻿namespace POOVentasFinal
{
    internal class ConceptoVenta
    {
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Importe
        {
            //Solo lectura
            get
            {
                return CalcularImporte();
            }
        }

        private decimal CalcularImporte()
        {
            return Cantidad * ValorUnitario;
        }
    }
}
