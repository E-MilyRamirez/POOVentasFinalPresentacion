namespace POOVentasFinal
{
    public partial class FrmVenta : Form
    {
        private Venta _venta;

        public FrmVenta(string tipoVenta)
        {
            InitializeComponent();

            if (tipoVenta == "credito")
            {
                _venta = new VentaCredito();
                this.Text = "Venta de credito";
            }
            else
            {
                _venta = new VentaContado();
                this.Text = "Venta de contado";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DgvConceptos.DataSource = null;

            //Se crea el concepto de venta
            ConceptoVenta concepto = new ConceptoVenta();
            concepto.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            concepto.Descripcion = TxtDescripcion.Text;
            concepto.ValorUnitario = Convert.ToDecimal(TxtValorUnitario.Text);
            _venta.Conceptos.Add(concepto);

            DgvConceptos.DataSource = _venta.Conceptos;

            //Empty es para la limpieza de los conceptos
            TxtCantidad.Text = string.Empty;
            TxtDescripcion.Text = string.Empty;
            TxtValorUnitario.Text = string.Empty;
            TxtTotal.Text = _venta.Total.ToString();
            TxtDescripcion.Focus();
        }
    }
}
