﻿
namespace Parcial_I___Progra_I
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboTipoConversor = new System.Windows.Forms.ComboBox();
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.lblRespuestaConversores = new System.Windows.Forms.Label();
            this.lblCantidadConversores = new System.Windows.Forms.Label();
            this.cboAConversores = new System.Windows.Forms.ComboBox();
            this.lblAConversores = new System.Windows.Forms.Label();
            this.txtCantidadConversores = new System.Windows.Forms.TextBox();
            this.cboDeConversores = new System.Windows.Forms.ComboBox();
            this.lblDeConversores = new System.Windows.Forms.Label();
            this.btnConvertirConversores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboTipoConversor
            // 
            this.cboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConversor.FormattingEnabled = true;
            this.cboTipoConversor.Items.AddRange(new object[] {
            "Área"});
            this.cboTipoConversor.Location = new System.Drawing.Point(92, 41);
            this.cboTipoConversor.Name = "cboTipoConversor";
            this.cboTipoConversor.Size = new System.Drawing.Size(146, 21);
            this.cboTipoConversor.TabIndex = 19;
            this.cboTipoConversor.SelectedIndexChanged += new System.EventHandler(this.cboTipoConversor_TextChanged);
            this.cboTipoConversor.StyleChanged += new System.EventHandler(this.cboTipoConversor_TextChanged);
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConversor.Location = new System.Drawing.Point(25, 40);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(61, 22);
            this.lblTipoConversor.TabIndex = 18;
            this.lblTipoConversor.Text = "TIPO:";
            // 
            // lblRespuestaConversores
            // 
            this.lblRespuestaConversores.AutoSize = true;
            this.lblRespuestaConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaConversores.Location = new System.Drawing.Point(25, 221);
            this.lblRespuestaConversores.Name = "lblRespuestaConversores";
            this.lblRespuestaConversores.Size = new System.Drawing.Size(123, 22);
            this.lblRespuestaConversores.TabIndex = 17;
            this.lblRespuestaConversores.Text = "Respuesta: ?";
            this.lblRespuestaConversores.StyleChanged += new System.EventHandler(this.cboTipoConversor_TextChanged);
            // 
            // lblCantidadConversores
            // 
            this.lblCantidadConversores.AutoSize = true;
            this.lblCantidadConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadConversores.Location = new System.Drawing.Point(25, 174);
            this.lblCantidadConversores.Name = "lblCantidadConversores";
            this.lblCantidadConversores.Size = new System.Drawing.Size(90, 22);
            this.lblCantidadConversores.TabIndex = 16;
            this.lblCantidadConversores.Text = "Cantidad:";
            // 
            // cboAConversores
            // 
            this.cboAConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAConversores.FormattingEnabled = true;
            this.cboAConversores.Location = new System.Drawing.Point(92, 126);
            this.cboAConversores.Name = "cboAConversores";
            this.cboAConversores.Size = new System.Drawing.Size(146, 21);
            this.cboAConversores.TabIndex = 15;
            this.cboAConversores.StyleChanged += new System.EventHandler(this.cboTipoConversor_TextChanged);
            // 
            // lblAConversores
            // 
            this.lblAConversores.AutoSize = true;
            this.lblAConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAConversores.Location = new System.Drawing.Point(39, 122);
            this.lblAConversores.Name = "lblAConversores";
            this.lblAConversores.Size = new System.Drawing.Size(28, 22);
            this.lblAConversores.TabIndex = 14;
            this.lblAConversores.Text = "A:";
            // 
            // txtCantidadConversores
            // 
            this.txtCantidadConversores.Location = new System.Drawing.Point(121, 178);
            this.txtCantidadConversores.Name = "txtCantidadConversores";
            this.txtCantidadConversores.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadConversores.TabIndex = 13;
            // 
            // cboDeConversores
            // 
            this.cboDeConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeConversores.FormattingEnabled = true;
            this.cboDeConversores.Location = new System.Drawing.Point(92, 81);
            this.cboDeConversores.Name = "cboDeConversores";
            this.cboDeConversores.Size = new System.Drawing.Size(146, 21);
            this.cboDeConversores.TabIndex = 12;
            this.cboDeConversores.StyleChanged += new System.EventHandler(this.cboTipoConversor_TextChanged);
            // 
            // lblDeConversores
            // 
            this.lblDeConversores.AutoSize = true;
            this.lblDeConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeConversores.Location = new System.Drawing.Point(25, 80);
            this.lblDeConversores.Name = "lblDeConversores";
            this.lblDeConversores.Size = new System.Drawing.Size(42, 22);
            this.lblDeConversores.TabIndex = 11;
            this.lblDeConversores.Text = "DE:";
            // 
            // btnConvertirConversores
            // 
            this.btnConvertirConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirConversores.Location = new System.Drawing.Point(29, 266);
            this.btnConvertirConversores.Name = "btnConvertirConversores";
            this.btnConvertirConversores.Size = new System.Drawing.Size(192, 92);
            this.btnConvertirConversores.TabIndex = 10;
            this.btnConvertirConversores.Text = "Convertir";
            this.btnConvertirConversores.UseVisualStyleBackColor = true;
            this.btnConvertirConversores.Click += new System.EventHandler(this.btnConvertirConversores_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 384);
            this.Controls.Add(this.cboTipoConversor);
            this.Controls.Add(this.lblTipoConversor);
            this.Controls.Add(this.lblRespuestaConversores);
            this.Controls.Add(this.lblCantidadConversores);
            this.Controls.Add(this.cboAConversores);
            this.Controls.Add(this.lblAConversores);
            this.Controls.Add(this.txtCantidadConversores);
            this.Controls.Add(this.cboDeConversores);
            this.Controls.Add(this.lblDeConversores);
            this.Controls.Add(this.btnConvertirConversores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoConversor;
        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.Label lblRespuestaConversores;
        private System.Windows.Forms.Label lblCantidadConversores;
        private System.Windows.Forms.ComboBox cboAConversores;
        private System.Windows.Forms.Label lblAConversores;
        private System.Windows.Forms.TextBox txtCantidadConversores;
        private System.Windows.Forms.ComboBox cboDeConversores;
        private System.Windows.Forms.Label lblDeConversores;
        private System.Windows.Forms.Button btnConvertirConversores;
    }
}

