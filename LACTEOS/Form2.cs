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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
             this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proveedoresDataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedoresDataSet2.Table' Puede moverla o quitarla según sea necesario.
           
            // TODO: esta línea de código carga datos en la tabla 'proveedoresDataSet1.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.proveedoresDataSet1.producto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
        }
    }
}
