using CapaNegocio;
using CapaPresentacion.Modales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDepositoDistribuido : Form
    {
        public frmDepositoDistribuido()
        {
            InitializeComponent();
        }

        private void frmDepositoDistribuido_Load(object sender, EventArgs e)
        {
            txtMontoTotal.Text = "0.00";
            txtSaldoDisponible.Text = "0.00";
            lblTotalDistribuido.Text = "0.00";
        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCuentaBancaria())
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    dgvDetalleDeposito.Rows.Add(
                        modal._Cuenta.IdCuenta,
                        modal._Cuenta.oBanco.NombreBanco + " - " + modal._Cuenta.NumeroCuenta,
                        modal._Cuenta.Saldo,
                        "0.00");
                }
            }
        }



        private void CalcularTotales()
        {
            decimal totalDistribuido = 0;
            decimal totalSaldo = 0;

            foreach (DataGridViewRow row in dgvDetalleDeposito.Rows)
            {
                decimal saldo = 0;
                decimal monto = 0;

                decimal.TryParse(row.Cells["SaldoActual"].Value.ToString(), out saldo);
                decimal.TryParse(row.Cells["Monto"].Value.ToString(), out monto);

                totalSaldo += saldo;
                totalDistribuido += monto;
            }

            txtSaldoDisponible.Text = totalSaldo.ToString("0.00");
            lblTotalDistribuido.Text = totalDistribuido.ToString("0.00");
        }

        private void dgvDetalleDeposito_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDetalleDeposito.Columns["Monto"].Index)
            {
                CalcularTotales();
            }
        }






        private void dgvDetalleDeposito_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvDetalleDeposito.CurrentCell.ColumnIndex == dgvDetalleDeposito.Columns["Monto"].Index)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress -= soloDecimal_KeyPress;
                    tb.KeyPress += soloDecimal_KeyPress;
                }
            }
        }

        private void soloDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            TextBox tb = sender as TextBox;
            if (e.KeyChar == '.' && tb.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            DataTable detalle = new DataTable();
            detalle.Columns.Add("IdCuenta", typeof(int));
            detalle.Columns.Add("Monto", typeof(decimal));

            foreach (DataGridViewRow fila in dgvDetalleDeposito.Rows)
            {
                detalle.Rows.Add(
                    Convert.ToInt32(fila.Cells["IdCuenta"].Value),
                    Convert.ToDecimal(fila.Cells["Monto"].Value)
                );
            }

            decimal montoTotal = Convert.ToDecimal(txtMontoTotal.Text);
            string mensaje;

            bool respuesta = new CN_Deposito()
                .DepositarEnCuentas(detalle, txtDescripcion.Text, montoTotal, out mensaje);

            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK);
        }



        private void LimpiarFormulario()
        {
            txtDescripcion.Text = "";
            txtMontoTotal.Text = "0.00";
            txtSaldoDisponible.Text = "0.00";
            lblTotalDistribuido.Text = "0.00";
            dgvDetalleDeposito.Rows.Clear();
        }

    }
}