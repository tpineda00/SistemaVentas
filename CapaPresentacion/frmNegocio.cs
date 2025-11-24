using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }


        public Image ByteToImage(byte[] imageBytes) {
         MemoryStream ms = new MemoryStream();
         ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;   
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimage = new CN_Negocio().Obtenerlogo(out obtenido);


            if(obtenido )
                piclogo.Image = ByteToImage(byteimage);




            Negocio datos = new CN_Negocio().ObtenerDatos();


            txtnombre.Text = datos.Nombre;
            txtruc.Text = datos.Ruc;    
            txtdireccion.Text = datos.Direccion;







        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;

            OpenFileDialog oOpenFileDialog = new OpenFileDialog();  
            oOpenFileDialog.FileName = "Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteimage = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(byteimage, out mensaje);

                if (respuesta)
              piclogo.Image = ByteToImage(byteimage);
                else
                    MessageBox.Show(mensaje);


            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Negocio obj = new Negocio()
            {
                Nombre = txtnombre.Text,
                Ruc = txtruc.Text,
                Direccion = txtdireccion.Text
            };

            bool respuesta = new CN_Negocio().GuardarDatos(obj, out mensaje);

            if(respuesta)
            {
                MessageBox.Show("Los datos se han guardado correctamente", mensaje, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar los cambios",mensaje,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }
    }
}
