namespace AppProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNomnbreP = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.listViewRegistro = new System.Windows.Forms.ListView();
            this.btnAgregarRegistro = new System.Windows.Forms.Button();
            this.columnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrecioV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFechaC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUnidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE DEL PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRECIO VENTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA DE COMPRA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(706, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "UNIDAD:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(38, 75);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(93, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtNomnbreP
            // 
            this.txtNomnbreP.Location = new System.Drawing.Point(157, 75);
            this.txtNomnbreP.Name = "txtNomnbreP";
            this.txtNomnbreP.Size = new System.Drawing.Size(176, 20);
            this.txtNomnbreP.TabIndex = 6;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(379, 75);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 7;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(513, 75);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(138, 20);
            this.txtFecha.TabIndex = 8;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(688, 75);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtUnidad.TabIndex = 9;
            // 
            // listViewRegistro
            // 
            this.listViewRegistro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCodigo,
            this.columnProducto,
            this.columnPrecioV,
            this.columnFechaC,
            this.columnUnidad});
            this.listViewRegistro.HideSelection = false;
            this.listViewRegistro.Location = new System.Drawing.Point(23, 130);
            this.listViewRegistro.Name = "listViewRegistro";
            this.listViewRegistro.Size = new System.Drawing.Size(764, 304);
            this.listViewRegistro.TabIndex = 10;
            this.listViewRegistro.UseCompatibleStateImageBehavior = false;
            this.listViewRegistro.View = System.Windows.Forms.View.Details;
            // 
            // btnAgregarRegistro
            // 
            this.btnAgregarRegistro.Location = new System.Drawing.Point(38, 465);
            this.btnAgregarRegistro.Name = "btnAgregarRegistro";
            this.btnAgregarRegistro.Size = new System.Drawing.Size(146, 23);
            this.btnAgregarRegistro.TabIndex = 11;
            this.btnAgregarRegistro.Text = "Agregar producto";
            this.btnAgregarRegistro.UseVisualStyleBackColor = true;
            this.btnAgregarRegistro.Click += new System.EventHandler(this.btnAgregarRegistro_Click);
            // 
            // columnCodigo
            // 
            this.columnCodigo.Text = "Codigo";
            this.columnCodigo.Width = 93;
            // 
            // columnProducto
            // 
            this.columnProducto.Text = "Nombre Producto";
            this.columnProducto.Width = 219;
            // 
            // columnPrecioV
            // 
            this.columnPrecioV.Text = "PrecioVenta";
            this.columnPrecioV.Width = 128;
            // 
            // columnFechaC
            // 
            this.columnFechaC.Text = "Fecha Compra";
            this.columnFechaC.Width = 190;
            // 
            // columnUnidad
            // 
            this.columnUnidad.Text = "Unidad";
            this.columnUnidad.Width = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 585);
            this.Controls.Add(this.btnAgregarRegistro);
            this.Controls.Add(this.listViewRegistro);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtNomnbreP);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNomnbreP;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.ListView listViewRegistro;
        private System.Windows.Forms.Button btnAgregarRegistro;
        private System.Windows.Forms.ColumnHeader columnCodigo;
        private System.Windows.Forms.ColumnHeader columnProducto;
        private System.Windows.Forms.ColumnHeader columnPrecioV;
        private System.Windows.Forms.ColumnHeader columnFechaC;
        private System.Windows.Forms.ColumnHeader columnUnidad;
    }
}

