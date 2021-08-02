namespace Win.Supermercado
{
    partial class FrrmMenu
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
            this.Botones = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconodeFormHijo = new System.Windows.Forms.PictureBox();
            this.btnSesion = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.TituloFrmHijo = new System.Windows.Forms.Label();
            this.Botones.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconodeFormHijo)).BeginInit();
            this.SuspendLayout();
            // 
            // Botones
            // 
            this.Botones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(67)))));
            this.Botones.Controls.Add(this.btnSesion);
            this.Botones.Controls.Add(this.btnReportes);
            this.Botones.Controls.Add(this.btnFacturas);
            this.Botones.Controls.Add(this.btnClientes);
            this.Botones.Controls.Add(this.btnProducto);
            this.Botones.Controls.Add(this.Logo);
            this.Botones.Dock = System.Windows.Forms.DockStyle.Left;
            this.Botones.Location = new System.Drawing.Point(0, 0);
            this.Botones.Name = "Botones";
            this.Botones.Size = new System.Drawing.Size(186, 468);
            this.Botones.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(186, 99);
            this.Logo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.TituloFrmHijo);
            this.panel2.Controls.Add(this.iconodeFormHijo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(186, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 69);
            this.panel2.TabIndex = 1;
            // 
            // iconodeFormHijo
            // 
            this.iconodeFormHijo.Image = global::Win.Supermercado.Properties.Resources.Icono_Maximizar;
            this.iconodeFormHijo.Location = new System.Drawing.Point(18, 21);
            this.iconodeFormHijo.Name = "iconodeFormHijo";
            this.iconodeFormHijo.Size = new System.Drawing.Size(50, 45);
            this.iconodeFormHijo.TabIndex = 0;
            this.iconodeFormHijo.TabStop = false;
            // 
            // btnSesion
            // 
            this.btnSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSesion.FlatAppearance.BorderSize = 0;
            this.btnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSesion.Image = global::Win.Supermercado.Properties.Resources.producto;
            this.btnSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSesion.Location = new System.Drawing.Point(0, 299);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(186, 50);
            this.btnSesion.TabIndex = 5;
            this.btnSesion.Text = "button5";
            this.btnSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSesion.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.Image = global::Win.Supermercado.Properties.Resources.reportes;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 249);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(186, 50);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFacturas.Image = global::Win.Supermercado.Properties.Resources.venta;
            this.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.Location = new System.Drawing.Point(0, 199);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(186, 50);
            this.btnFacturas.TabIndex = 3;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.Image = global::Win.Supermercado.Properties.Resources.clientes;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 149);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(186, 50);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducto.Image = global::Win.Supermercado.Properties.Resources.producto;
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(0, 99);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(186, 50);
            this.btnProducto.TabIndex = 1;
            this.btnProducto.Text = "Productos";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // TituloFrmHijo
            // 
            this.TituloFrmHijo.AutoSize = true;
            this.TituloFrmHijo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloFrmHijo.ForeColor = System.Drawing.Color.Gainsboro;
            this.TituloFrmHijo.Location = new System.Drawing.Point(57, 34);
            this.TituloFrmHijo.Name = "TituloFrmHijo";
            this.TituloFrmHijo.Size = new System.Drawing.Size(51, 21);
            this.TituloFrmHijo.TabIndex = 1;
            this.TituloFrmHijo.Text = "Inicio";
            // 
            // FrrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Botones);
            this.Name = "FrrmMenu";
            this.Text = "FrrmMenu";
            this.Botones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconodeFormHijo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Botones;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox iconodeFormHijo;
        private System.Windows.Forms.Label TituloFrmHijo;
    }
}