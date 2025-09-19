using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        claseTDA estacionamiento = new claseTDA(10);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertarPush_Click(object sender, EventArgs e)
        {
            try
            {
                if (estacionamiento.EstaLLeno())
                {
                    MessageBox.Show("El estacionamiento esta lleno.");
                    return;
                }
                string placas = txtPlacas.Text;
                string propietario = txtProp.Text;
                string color = txtColor.Text;

                if (placas == "" || propietario == "" || color == "")
                {
                    MessageBox.Show(" Debes llenar todos los campos para continuar.");
                    return;
                }
                Auto nuevo = new Auto(placas, propietario, color);
                estacionamiento.InsertarAuto(nuevo);
                MessageBox.Show("El auto se ingreso correctamente", "Auto Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvAutosDatosS.DataSource = null;
                dgvAutosDatosS.DataSource = estacionamiento.ObtenerAutos();
            }
            catch
            {
                MessageBox.Show("La Placa ya existe o esta repetida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalidaPush_Click(object sender, EventArgs e)
        {
            try
            {
                if (estacionamiento.EstaVacio())
                {
                    MessageBox.Show("El Estacionamiento esta vacio.");
                    return;
                }

                Auto salida = estacionamiento.SacarAuto();
                MessageBox.Show("Salio El Auto: " + salida.Placas + " - " + salida.Propietario + " - " + salida.Color);

                dgvAutosDatosS.DataSource = null;
                dgvAutosDatosS.DataSource = estacionamiento.ObtenerAutos();
            }
            catch 
            {
                MessageBox.Show("No Hay ningun carro en el estacionamiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarTop_Click(object sender, EventArgs e)
        {
            txtTop.Text = estacionamiento.Top1.ToString();
        }
    }
}
