namespace CapaPresentacion
{
    partial class frmDepositoDistribuido
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaldoDisponible = new System.Windows.Forms.TextBox();
            this.dgvDetalleDeposito = new System.Windows.Forms.DataGridView();
            this.IdCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalDistribuido = new System.Windows.Forms.Label();
            this.btnAgregarCuenta = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleDeposito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(160, 36);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(324, 22);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto Total :";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(668, 36);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(100, 22);
            this.txtMontoTotal.TabIndex = 3;
            this.txtMontoTotal.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo Total Disponible";
            // 
            // txtSaldoDisponible
            // 
            this.txtSaldoDisponible.Location = new System.Drawing.Point(243, 75);
            this.txtSaldoDisponible.Name = "txtSaldoDisponible";
            this.txtSaldoDisponible.ReadOnly = true;
            this.txtSaldoDisponible.Size = new System.Drawing.Size(158, 22);
            this.txtSaldoDisponible.TabIndex = 5;
            this.txtSaldoDisponible.Text = "0.00";
            // 
            // dgvDetalleDeposito
            // 
            this.dgvDetalleDeposito.AllowUserToAddRows = false;
            this.dgvDetalleDeposito.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvDetalleDeposito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleDeposito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCuenta,
            this.Cuenta,
            this.SaldoActual,
            this.Monto,
            this.btnEliminar});
            this.dgvDetalleDeposito.Location = new System.Drawing.Point(12, 129);
            this.dgvDetalleDeposito.MultiSelect = false;
            this.dgvDetalleDeposito.Name = "dgvDetalleDeposito";
            this.dgvDetalleDeposito.RowHeadersWidth = 51;
            this.dgvDetalleDeposito.RowTemplate.Height = 24;
            this.dgvDetalleDeposito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleDeposito.Size = new System.Drawing.Size(952, 283);
            this.dgvDetalleDeposito.TabIndex = 6;
            this.dgvDetalleDeposito.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleDeposito_CellValueChanged);
            // 
            // IdCuenta
            // 
            this.IdCuenta.HeaderText = "IdCuenta";
            this.IdCuenta.MinimumWidth = 6;
            this.IdCuenta.Name = "IdCuenta";
            this.IdCuenta.Visible = false;
            this.IdCuenta.Width = 125;
            // 
            // Cuenta
            // 
            this.Cuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.MinimumWidth = 6;
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Width = 125;
            // 
            // SaldoActual
            // 
            this.SaldoActual.HeaderText = "Saldo Actual";
            this.SaldoActual.MinimumWidth = 6;
            this.SaldoActual.Name = "SaldoActual";
            this.SaldoActual.Width = 125;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto a Depositar";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.Width = 125;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.MinimumWidth = 6;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "X";
            this.btnEliminar.UseColumnTextForButtonValue = true;
            this.btnEliminar.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Distibuido :";
            // 
            // lblTotalDistribuido
            // 
            this.lblTotalDistribuido.AutoSize = true;
            this.lblTotalDistribuido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDistribuido.Location = new System.Drawing.Point(188, 442);
            this.lblTotalDistribuido.Name = "lblTotalDistribuido";
            this.lblTotalDistribuido.Size = new System.Drawing.Size(49, 22);
            this.lblTotalDistribuido.TabIndex = 8;
            this.lblTotalDistribuido.Text = "0.00";
            // 
            // btnAgregarCuenta
            // 
            this.btnAgregarCuenta.Location = new System.Drawing.Point(600, 435);
            this.btnAgregarCuenta.Name = "btnAgregarCuenta";
            this.btnAgregarCuenta.Size = new System.Drawing.Size(136, 40);
            this.btnAgregarCuenta.TabIndex = 9;
            this.btnAgregarCuenta.Text = "Agregar cuenta";
            this.btnAgregarCuenta.UseVisualStyleBackColor = true;
            this.btnAgregarCuenta.Click += new System.EventHandler(this.btnAgregarCuenta_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(765, 435);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(136, 40);
            this.btnDepositar.TabIndex = 10;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // frmDepositoDistribuido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 539);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnAgregarCuenta);
            this.Controls.Add(this.lblTotalDistribuido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDetalleDeposito);
            this.Controls.Add(this.txtSaldoDisponible);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Name = "frmDepositoDistribuido";
            this.Text = "frmDepositoDistribuido";
            this.Load += new System.EventHandler(this.frmDepositoDistribuido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleDeposito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaldoDisponible;
        private System.Windows.Forms.DataGridView dgvDetalleDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalDistribuido;
        private System.Windows.Forms.Button btnAgregarCuenta;
        private System.Windows.Forms.Button btnDepositar;
    }
}