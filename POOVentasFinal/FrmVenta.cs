namespace POOVentasFinal
{
    public partial class FrmVenta : Form
    {
        List<ConceptoVenta> conceptos;
        public FrmVenta(string tipoVenta)
        {
            InitializeComponent();
            List<ConceptoVenta> conceptos = new List<ConceptoVenta>();
            
            if (tipoVenta == "credito")
            {
                this.Text = "Venta de credito";
            }
            else
            {
                this.Text = "Venta de contado";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DgvConceptos.DataSource = null;

            ConceptoVenta concepto = new ConceptoVenta();
            concepto.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            concepto.Descripcion = TxtDescripcion.Text;
            concepto.ValorUnitario = Convert.ToDecimal(TxtValorUnitario.Text);
            conceptos.Add(concepto);

            DgvConceptos.DataSource = conceptos;
        }
    }
}
