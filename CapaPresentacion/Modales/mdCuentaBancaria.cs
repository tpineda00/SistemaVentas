using System;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Modales
{
    public partial class mdCuentaBancaria : Form
    {
        public CuentaBancaria _Cuenta { get; set; }

        public mdCuentaBancaria()
        {
            InitializeComponent();
        }

        private void mdCuentaBancaria_Load(object sender, EventArgs e)
        {
            dgvdata.DataSource = new CN_CuentaBancaria().Listar();
        }

        private void dgvCuentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _Cuenta = dgvdata.Rows[e.RowIndex].DataBoundItem as CuentaBancaria;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

