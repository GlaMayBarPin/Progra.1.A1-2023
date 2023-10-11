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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void nombre_del_clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nombre_del_clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proveedoresDataSet3);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedoresDataSet3.Nombre_del_cliente' Puede moverla o quitarla según sea necesario.
            this.nombre_del_clienteTableAdapter.Fill(this.proveedoresDataSet3.Nombre_del_cliente);

        }
    }
}
