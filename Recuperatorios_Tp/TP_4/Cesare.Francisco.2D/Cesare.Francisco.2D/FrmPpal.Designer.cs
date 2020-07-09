namespace Cesare.Francisco._2D
{
    partial class FrmPpal
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
            this.components = new System.ComponentModel.Container();
            this.lblEntregado = new System.Windows.Forms.Label();
            this.lblEnViaje = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblTrackingId = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.MtxtBxTrackinId = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.richtxtMostrar = new System.Windows.Forms.RichTextBox();
            this.listBoxIngresado = new System.Windows.Forms.ListBox();
            this.listBoxEnViaje = new System.Windows.Forms.ListBox();
            this.listBoxEntregado = new System.Windows.Forms.ListBox();
            this.MostrarToolStripMenus = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBestadoPaq = new System.Windows.Forms.GroupBox();
            this.groupB = new System.Windows.Forms.GroupBox();
            this.MostrarToolStripMenus.SuspendLayout();
            this.groupBestadoPaq.SuspendLayout();
            this.groupB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEntregado
            // 
            this.lblEntregado.AutoSize = true;
            this.lblEntregado.Location = new System.Drawing.Point(589, 45);
            this.lblEntregado.Name = "lblEntregado";
            this.lblEntregado.Size = new System.Drawing.Size(56, 13);
            this.lblEntregado.TabIndex = 0;
            this.lblEntregado.Text = "Entregado";
            // 
            // lblEnViaje
            // 
            this.lblEnViaje.AutoSize = true;
            this.lblEnViaje.Location = new System.Drawing.Point(297, 45);
            this.lblEnViaje.Name = "lblEnViaje";
            this.lblEnViaje.Size = new System.Drawing.Size(46, 13);
            this.lblEnViaje.TabIndex = 0;
            this.lblEnViaje.Text = "En Viaje";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(0, 45);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(60, 13);
            this.lblIngreso.TabIndex = 0;
            this.lblIngreso.Text = "Ingresando";
            // 
            // lblTrackingId
            // 
            this.lblTrackingId.AutoSize = true;
            this.lblTrackingId.Location = new System.Drawing.Point(8, 55);
            this.lblTrackingId.Name = "lblTrackingId";
            this.lblTrackingId.Size = new System.Drawing.Size(63, 13);
            this.lblTrackingId.TabIndex = 0;
            this.lblTrackingId.Text = "Tracking ID";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(8, 125);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Direccion";
            // 
            // MtxtBxTrackinId
            // 
            this.MtxtBxTrackinId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtBxTrackinId.Location = new System.Drawing.Point(92, 50);
            this.MtxtBxTrackinId.Mask = "000-000-0000";
            this.MtxtBxTrackinId.Name = "MtxtBxTrackinId";
            this.MtxtBxTrackinId.Size = new System.Drawing.Size(152, 23);
            this.MtxtBxTrackinId.TabIndex = 1;
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Location = new System.Drawing.Point(92, 112);
            this.txtBoxDireccion.Multiline = true;
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(152, 26);
            this.txtBoxDireccion.TabIndex = 2;
            // 
            // richtxtMostrar
            // 
            this.richtxtMostrar.Location = new System.Drawing.Point(12, 287);
            this.richtxtMostrar.Name = "richtxtMostrar";
            this.richtxtMostrar.Size = new System.Drawing.Size(388, 165);
            this.richtxtMostrar.TabIndex = 3;
            this.richtxtMostrar.Text = "";
            // 
            // listBoxIngresado
            // 
            this.listBoxIngresado.FormattingEnabled = true;
            this.listBoxIngresado.Location = new System.Drawing.Point(0, 61);
            this.listBoxIngresado.Name = "listBoxIngresado";
            this.listBoxIngresado.Size = new System.Drawing.Size(274, 147);
            this.listBoxIngresado.TabIndex = 4;
            // 
            // listBoxEnViaje
            // 
            this.listBoxEnViaje.FormattingEnabled = true;
            this.listBoxEnViaje.Location = new System.Drawing.Point(300, 61);
            this.listBoxEnViaje.Name = "listBoxEnViaje";
            this.listBoxEnViaje.Size = new System.Drawing.Size(269, 147);
            this.listBoxEnViaje.TabIndex = 4;
            // 
            // listBoxEntregado
            // 
            this.listBoxEntregado.ContextMenuStrip = this.MostrarToolStripMenus;
            this.listBoxEntregado.FormattingEnabled = true;
            this.listBoxEntregado.Location = new System.Drawing.Point(586, 61);
            this.listBoxEntregado.Name = "listBoxEntregado";
            this.listBoxEntregado.Size = new System.Drawing.Size(272, 147);
            this.listBoxEntregado.TabIndex = 4;
            // 
            // MostrarToolStripMenus
            // 
            this.MostrarToolStripMenus.AllowDrop = true;
            this.MostrarToolStripMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem1});
            this.MostrarToolStripMenus.Name = "MostrarToolStripMenus";
            this.MostrarToolStripMenus.Size = new System.Drawing.Size(116, 26);
            // 
            // mostrarToolStripMenuItem1
            // 
            this.mostrarToolStripMenuItem1.Name = "mostrarToolStripMenuItem1";
            this.mostrarToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.mostrarToolStripMenuItem1.Text = "Mostrar";
            this.mostrarToolStripMenuItem1.Click += new System.EventHandler(this.mostrarToolStripMenuItem1_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(286, 102);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(106, 36);
            this.btnMostrarTodos.TabIndex = 5;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(286, 37);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 36);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Visible = false;
            // 
            // groupBestadoPaq
            // 
            this.groupBestadoPaq.Controls.Add(this.listBoxIngresado);
            this.groupBestadoPaq.Controls.Add(this.lblIngreso);
            this.groupBestadoPaq.Controls.Add(this.lblEnViaje);
            this.groupBestadoPaq.Controls.Add(this.listBoxEntregado);
            this.groupBestadoPaq.Controls.Add(this.lblEntregado);
            this.groupBestadoPaq.Controls.Add(this.listBoxEnViaje);
            this.groupBestadoPaq.Location = new System.Drawing.Point(12, 12);
            this.groupBestadoPaq.Name = "groupBestadoPaq";
            this.groupBestadoPaq.Size = new System.Drawing.Size(875, 265);
            this.groupBestadoPaq.TabIndex = 6;
            this.groupBestadoPaq.TabStop = false;
            this.groupBestadoPaq.Text = "Estado Paquetes";
            // 
            // groupB
            // 
            this.groupB.Controls.Add(this.txtBoxDireccion);
            this.groupB.Controls.Add(this.lblDireccion);
            this.groupB.Controls.Add(this.btnAgregar);
            this.groupB.Controls.Add(this.lblTrackingId);
            this.groupB.Controls.Add(this.btnMostrarTodos);
            this.groupB.Controls.Add(this.MtxtBxTrackinId);
            this.groupB.Location = new System.Drawing.Point(413, 283);
            this.groupB.Name = "groupB";
            this.groupB.Size = new System.Drawing.Size(430, 160);
            this.groupB.TabIndex = 8;
            this.groupB.TabStop = false;
            this.groupB.Text = "Paquete";
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.richtxtMostrar);
            this.Controls.Add(this.groupBestadoPaq);
            this.Controls.Add(this.groupB);
            this.Name = "FrmPpal";
            this.Text = "Correo UTN Cesare Francisco 2D 2020";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
            this.MostrarToolStripMenus.ResumeLayout(false);
            this.groupBestadoPaq.ResumeLayout(false);
            this.groupBestadoPaq.PerformLayout();
            this.groupB.ResumeLayout(false);
            this.groupB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEntregado;
        private System.Windows.Forms.Label lblEnViaje;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblTrackingId;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.MaskedTextBox MtxtBxTrackinId;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.RichTextBox richtxtMostrar;
        private System.Windows.Forms.ListBox listBoxIngresado;
        private System.Windows.Forms.ListBox listBoxEnViaje;
        private System.Windows.Forms.ListBox listBoxEntregado;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ContextMenuStrip MostrarToolStripMenus;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBestadoPaq;
        private System.Windows.Forms.GroupBox groupB;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem1;
    }
}

