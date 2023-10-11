using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LACTEOS
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void datos__de_los_proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datos__de_los_proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proveedoresDataSet);

        }

        private void datos__de_los_proveedoresBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.datos__de_los_proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proveedoresDataSet);

        }

        private void datos__de_los_proveedoresBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.datos__de_los_proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proveedoresDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedoresDataSet.Datos__de_los_proveedores' Puede moverla o quitarla según sea necesario.
            this.datos__de_los_proveedoresTableAdapter.Fill(this.proveedoresDataSet.Datos__de_los_proveedores);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
        }
    }
}
