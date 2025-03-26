namespace POOVentasFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnVentaCredito = new Button();
            BtnVentaContado = new Button();
            SuspendLayout();
            // 
            // BtnVentaCredito
            // 
            BtnVentaCredito.Location = new Point(474, 241);
            BtnVentaCredito.Name = "BtnVentaCredito";
            BtnVentaCredito.Size = new Size(124, 29);
            BtnVentaCredito.TabIndex = 0;
            BtnVentaCredito.Text = "Venta Credito";
            BtnVentaCredito.UseVisualStyleBackColor = true;
            // 
            // BtnVentaContado
            // 
            BtnVentaContado.Location = new Point(159, 241);
            BtnVentaContado.Name = "BtnVentaContado";
            BtnVentaContado.Size = new Size(118, 29);
            BtnVentaContado.TabIndex = 0;
            BtnVentaContado.Text = "Venta Contado";
            BtnVentaContado.UseVisualStyleBackColor = true;
            BtnVentaContado.Click += BtnVentaContado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnVentaContado);
            Controls.Add(BtnVentaCredito);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnVentaCredito;
        private Button BtnVentaContado;
    }
}
