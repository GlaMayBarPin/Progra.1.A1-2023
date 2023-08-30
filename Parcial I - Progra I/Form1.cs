using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_I___Progra_I
{
    public partial class Form1 : Form
    {
        String[][] TipoDeConversores = new String[][]{
          new String[]{"Pie Cuadrado", "Vara Cuadrado", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectárea", },
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void cboTipoConversor_TextChanged(object sender, EventArgs e)
        {
            cboDeConversores.Items.Clear();
            cboDeConversores.Items.AddRange(TipoDeConversores[cboTipoConversor.SelectedIndex]);

            cboAConversores.Items.Clear();
            cboAConversores.Items.AddRange(TipoDeConversores[cboTipoConversor.SelectedIndex]);

        }

        private void btnConvertirConversores_Click_1(object sender, EventArgs e)
        {
            int de, a;
            double cantidad, respuesta;

            de = cboDeConversores.SelectedIndex;
            a = cboAConversores.SelectedIndex;

            cantidad = double.Parse(txtCantidadConversores.Text);

            double[][] Pie = {
                new double[]{ 0.09290304, 0.698896, 0.836127, 1, 437.5 , 7000, 10.000, },
                };

            respuesta = Pie[cboTipoConversor.SelectedIndex][de] / Pie[cboTipoConversor.SelectedIndex][a] * cantidad;
            lblRespuestaConversores.Text = "Respuesta:" + Math.Round(respuesta, 3);
        }
    }
}
