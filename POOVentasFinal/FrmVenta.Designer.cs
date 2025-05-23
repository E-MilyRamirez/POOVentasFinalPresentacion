﻿namespace POOVentasFinal
{
    partial class FrmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            TxtDescripcion = new TextBox();
            TxtCantidad = new TextBox();
            DgvConceptos = new DataGridView();
            label3 = new Label();
            TxtValorUnitario = new TextBox();
            BtnAgregar = new Button();
            TxtTotal = new TextBox();
            label4 = new Label();
            label5 = new Label();
            TxtCortesia = new TextBox();
            btnEfectivo = new Button();
            btnTarjeta = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvConceptos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 151);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Cantidad:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 22);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripción:";
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(140, 22);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(612, 92);
            TxtDescripcion.TabIndex = 0;
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(381, 153);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(125, 27);
            TxtCantidad.TabIndex = 2;
            // 
            // DgvConceptos
            // 
            DgvConceptos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConceptos.Location = new Point(33, 270);
            DgvConceptos.Name = "DgvConceptos";
            DgvConceptos.RowHeadersWidth = 51;
            DgvConceptos.Size = new Size(970, 304);
            DgvConceptos.TabIndex = 4;
            DgvConceptos.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 151);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 0;
            label3.Text = "Valor unitario:";
            label3.Click += label1_Click;
            // 
            // TxtValorUnitario
            // 
            TxtValorUnitario.Location = new Point(140, 153);
            TxtValorUnitario.Name = "TxtValorUnitario";
            TxtValorUnitario.Size = new Size(125, 27);
            TxtValorUnitario.TabIndex = 1;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(658, 153);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(94, 29);
            BtnAgregar.TabIndex = 3;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // TxtTotal
            // 
            TxtTotal.Location = new Point(878, 600);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.ReadOnly = true;
            TxtTotal.Size = new Size(125, 27);
            TxtTotal.TabIndex = 5;
            TxtTotal.Text = "0.00";
            TxtTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(827, 603);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 6;
            label4.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 600);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 7;
            label5.Text = "V. Cortesía:";
            label5.Click += label5_Click;
            // 
            // TxtCortesia
            // 
            TxtCortesia.Location = new Point(189, 597);
            TxtCortesia.Name = "TxtCortesia";
            TxtCortesia.ReadOnly = true;
            TxtCortesia.Size = new Size(125, 27);
            TxtCortesia.TabIndex = 8;
            TxtCortesia.TextChanged += TxtCortesia_TextChanged;
            // 
            // btnEfectivo
            // 
            btnEfectivo.Location = new Point(463, 597);
            btnEfectivo.Name = "btnEfectivo";
            btnEfectivo.Size = new Size(94, 29);
            btnEfectivo.TabIndex = 9;
            btnEfectivo.Text = "Efectivo";
            btnEfectivo.UseVisualStyleBackColor = true;
            btnEfectivo.Click += btnEfectivo_Click;
            // 
            // btnTarjeta
            // 
            btnTarjeta.Location = new Point(597, 599);
            btnTarjeta.Name = "btnTarjeta";
            btnTarjeta.Size = new Size(94, 29);
            btnTarjeta.TabIndex = 10;
            btnTarjeta.Text = "Tarjeta";
            btnTarjeta.UseVisualStyleBackColor = true;
            btnTarjeta.Click += btnTarjeta_Click;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 648);
            Controls.Add(btnTarjeta);
            Controls.Add(btnEfectivo);
            Controls.Add(TxtCortesia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtTotal);
            Controls.Add(BtnAgregar);
            Controls.Add(DgvConceptos);
            Controls.Add(TxtValorUnitario);
            Controls.Add(TxtCantidad);
            Controls.Add(TxtDescripcion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmVenta";
            Text = "FrmVenta";
            ((System.ComponentModel.ISupportInitialize)DgvConceptos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtDescripcion;
        private TextBox TxtCantidad;
        private DataGridView DgvConceptos;
        private Label label3;
        private TextBox TxtValorUnitario;
        private Button BtnAgregar;
        private TextBox TxtTotal;
        private Label label4;
        private Label label5;
        private TextBox TxtCortesia;
        private Button btnEfectivo;
        private Button btnTarjeta;
    }
}