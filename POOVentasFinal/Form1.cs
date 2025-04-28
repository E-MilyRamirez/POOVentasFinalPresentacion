namespace POOVentasFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVentaContado_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta("contado");
            frmVenta.ShowDialog();
        }

        private void BtnVentaCredito_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta("credito");
            frmVenta.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
