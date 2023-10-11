
namespace LACTEOS
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label códigoLabel;
            System.Windows.Forms.Label tipo_de_productoLabel;
            System.Windows.Forms.Label nombre_de_productoLabel;
            System.Windows.Forms.Label idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombredeproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodeproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedoresDataSet1 = new LACTEOS.proveedoresDataSet1();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new LACTEOS.proveedoresDataSet1TableAdapters.productoTableAdapter();
            this.tableAdapterManager = new LACTEOS.proveedoresDataSet1TableAdapters.TableAdapterManager();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.nombre_de_productoTextBox = new System.Windows.Forms.TextBox();
            this.códigoTextBox = new System.Windows.Forms.TextBox();
            this.tipo_de_productoTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.productoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            cantidadLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            códigoLabel = new System.Windows.Forms.Label();
            tipo_de_productoLabel = new System.Windows.Forms.Label();
            nombre_de_productoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).BeginInit();
            this.productoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.Location = new System.Drawing.Point(16, 206);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(65, 16);
            cantidadLabel.TabIndex = 11;
            cantidadLabel.Text = "Cantidad:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(16, 176);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(50, 16);
            precioLabel.TabIndex = 9;
            precioLabel.Text = "Precio:";
            // 
            // códigoLabel
            // 
            códigoLabel.AutoSize = true;
            códigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            códigoLabel.Location = new System.Drawing.Point(26, 79);
            códigoLabel.Name = "códigoLabel";
            códigoLabel.Size = new System.Drawing.Size(55, 16);
            códigoLabel.TabIndex = 3;
            códigoLabel.Text = "Código:";
            // 
            // tipo_de_productoLabel
            // 
            tipo_de_productoLabel.AutoSize = true;
            tipo_de_productoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipo_de_productoLabel.Location = new System.Drawing.Point(16, 144);
            tipo_de_productoLabel.Name = "tipo_de_productoLabel";
            tipo_de_productoLabel.Size = new System.Drawing.Size(114, 16);
            tipo_de_productoLabel.TabIndex = 7;
            tipo_de_productoLabel.Text = "Tipo de producto:";
            // 
            // nombre_de_productoLabel
            // 
            nombre_de_productoLabel.AutoSize = true;
            nombre_de_productoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombre_de_productoLabel.Location = new System.Drawing.Point(16, 114);
            nombre_de_productoLabel.Name = "nombre_de_productoLabel";
            nombre_de_productoLabel.Size = new System.Drawing.Size(135, 16);
            nombre_de_productoLabel.TabIndex = 5;
            nombre_de_productoLabel.Text = "Nombre de producto:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(30, 50);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(22, 16);
            idLabel.TabIndex = 14;
            idLabel.Text = "Id:";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // códigoDataGridViewTextBoxColumn
            // 
            this.códigoDataGridViewTextBoxColumn.DataPropertyName = "Código";
            this.códigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.códigoDataGridViewTextBoxColumn.Name = "códigoDataGridViewTextBoxColumn";
            // 
            // nombredeproductoDataGridViewTextBoxColumn
            // 
            this.nombredeproductoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_de_producto";
            this.nombredeproductoDataGridViewTextBoxColumn.HeaderText = "Nombre_de_producto";
            this.nombredeproductoDataGridViewTextBoxColumn.Name = "nombredeproductoDataGridViewTextBoxColumn";
            // 
            // tipodeproductoDataGridViewTextBoxColumn
            // 
            this.tipodeproductoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_de_producto";
            this.tipodeproductoDataGridViewTextBoxColumn.HeaderText = "Tipo_de_producto";
            this.tipodeproductoDataGridViewTextBoxColumn.Name = "tipodeproductoDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // proveedoresDataSet1
            // 
            this.proveedoresDataSet1.DataSetName = "proveedoresDataSet1";
            this.proveedoresDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.proveedoresDataSet1;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.productoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.UpdateOrder = LACTEOS.proveedoresDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productoBindingNavigator
            // 
            this.productoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productoBindingNavigator.BindingSource = this.productoBindingSource;
            this.productoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productoBindingNavigatorSaveItem});
            this.productoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productoBindingNavigator.Name = "productoBindingNavigator";
            this.productoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productoBindingNavigator.Size = new System.Drawing.Size(687, 25);
            this.productoBindingNavigator.TabIndex = 0;
            this.productoBindingNavigator.Text = "bindingNavigator1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tipo_de_producto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipo_de_producto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre_de_producto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre_de_producto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Código";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.AllowUserToAddRows = false;
            this.productoDataGridView.AllowUserToDeleteRows = false;
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.productoDataGridView.DataSource = this.productoBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(24, 261);
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.ReadOnly = true;
            this.productoDataGridView.Size = new System.Drawing.Size(643, 174);
            this.productoDataGridView.TabIndex = 13;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(157, 205);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(212, 20);
            this.cantidadTextBox.TabIndex = 12;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(157, 176);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(212, 20);
            this.precioTextBox.TabIndex = 10;
            // 
            // nombre_de_productoTextBox
            // 
            this.nombre_de_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Nombre_de_producto", true));
            this.nombre_de_productoTextBox.Location = new System.Drawing.Point(157, 114);
            this.nombre_de_productoTextBox.Name = "nombre_de_productoTextBox";
            this.nombre_de_productoTextBox.Size = new System.Drawing.Size(212, 20);
            this.nombre_de_productoTextBox.TabIndex = 6;
            // 
            // códigoTextBox
            // 
            this.códigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Código", true));
            this.códigoTextBox.Location = new System.Drawing.Point(157, 75);
            this.códigoTextBox.Name = "códigoTextBox";
            this.códigoTextBox.Size = new System.Drawing.Size(212, 20);
            this.códigoTextBox.TabIndex = 4;
            // 
            // tipo_de_productoTextBox
            // 
            this.tipo_de_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Tipo_de_producto", true));
            this.tipo_de_productoTextBox.Location = new System.Drawing.Point(157, 144);
            this.tipo_de_productoTextBox.Name = "tipo_de_productoTextBox";
            this.tipo_de_productoTextBox.Size = new System.Drawing.Size(212, 20);
            this.tipo_de_productoTextBox.TabIndex = 8;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(157, 46);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(212, 20);
            this.idTextBox.TabIndex = 15;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LACTEOS.Properties.Resources.quesos_y_mas_logo_7EA29788E9_seeklogo_com;
            this.pictureBox4.Location = new System.Drawing.Point(430, 34);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(227, 196);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // productoBindingNavigatorSaveItem
            // 
            this.productoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productoBindingNavigatorSaveItem.Image")));
            this.productoBindingNavigatorSaveItem.Name = "productoBindingNavigatorSaveItem";
            this.productoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.productoBindingNavigatorSaveItem.Click += new System.EventHandler(this.productoBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(228, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "clientes de la tabla 3 ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.productoDataGridView);
            this.Controls.Add(códigoLabel);
            this.Controls.Add(this.códigoTextBox);
            this.Controls.Add(nombre_de_productoLabel);
            this.Controls.Add(this.nombre_de_productoTextBox);
            this.Controls.Add(tipo_de_productoLabel);
            this.Controls.Add(this.tipo_de_productoTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.productoBindingNavigator);
            this.Name = "Form2";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).EndInit();
            this.productoBindingNavigator.ResumeLayout(false);
            this.productoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredeproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodeproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private proveedoresDataSet1 proveedoresDataSet1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private proveedoresDataSet1TableAdapters.productoTableAdapter productoTableAdapter;
        private proveedoresDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton productoBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator productoBindingNavigator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView productoDataGridView;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox nombre_de_productoTextBox;
        private System.Windows.Forms.TextBox códigoTextBox;
        private System.Windows.Forms.TextBox tipo_de_productoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button button1;
    }
}