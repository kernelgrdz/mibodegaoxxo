﻿/*
 * Creado por SharpDevelop.
 * Usuario: Carlos
 * Fecha: 15/10/2018
 * Hora: 04:27 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace MibodegaOxxo
{
	partial class RegistrarProveedor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label btnCerrar;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textCorreo;
		private System.Windows.Forms.TextBox textTelefono;
		private System.Windows.Forms.TextBox textRFC;
		private System.Windows.Forms.TextBox textEmpresa;
		private System.Windows.Forms.TextBox textMaterno;
		private System.Windows.Forms.TextBox textPaterno;
		private System.Windows.Forms.TextBox textNombre;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnGuardarProveedor;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarProveedor));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCerrar = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnGuardarProveedor = new System.Windows.Forms.Button();
			this.textCorreo = new System.Windows.Forms.TextBox();
			this.textTelefono = new System.Windows.Forms.TextBox();
			this.textRFC = new System.Windows.Forms.TextBox();
			this.textEmpresa = new System.Windows.Forms.TextBox();
			this.textMaterno = new System.Windows.Forms.TextBox();
			this.textPaterno = new System.Windows.Forms.TextBox();
			this.textNombre = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
			this.panel1.Controls.Add(this.btnCerrar);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(730, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(222, 465);
			this.panel1.TabIndex = 1;
			// 
			// btnCerrar
			// 
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.Location = new System.Drawing.Point(189, 0);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(33, 30);
			this.btnCerrar.TabIndex = 2;
			this.btnCerrar.Text = "X";
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(3, 262);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(216, 176);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(216, 182);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.btnGuardarProveedor);
			this.panel2.Controls.Add(this.textCorreo);
			this.panel2.Controls.Add(this.textTelefono);
			this.panel2.Controls.Add(this.textRFC);
			this.panel2.Controls.Add(this.textEmpresa);
			this.panel2.Controls.Add(this.textMaterno);
			this.panel2.Controls.Add(this.textPaterno);
			this.panel2.Controls.Add(this.textNombre);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(730, 465);
			this.panel2.TabIndex = 2;
			// 
			// btnGuardarProveedor
			// 
			this.btnGuardarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnGuardarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnGuardarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardarProveedor.FlatAppearance.BorderSize = 0;
			this.btnGuardarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnGuardarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardarProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardarProveedor.ForeColor = System.Drawing.Color.White;
			this.btnGuardarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarProveedor.Image")));
			this.btnGuardarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarProveedor.Location = new System.Drawing.Point(212, 398);
			this.btnGuardarProveedor.Name = "btnGuardarProveedor";
			this.btnGuardarProveedor.Size = new System.Drawing.Size(322, 40);
			this.btnGuardarProveedor.TabIndex = 14;
			this.btnGuardarProveedor.Text = "Guardar proveedor";
			this.btnGuardarProveedor.UseVisualStyleBackColor = false;
			this.btnGuardarProveedor.Click += new System.EventHandler(this.BtnGuardarProveedorClick);
			// 
			// textCorreo
			// 
			this.textCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textCorreo.Location = new System.Drawing.Point(85, 322);
			this.textCorreo.Name = "textCorreo";
			this.textCorreo.Size = new System.Drawing.Size(630, 27);
			this.textCorreo.TabIndex = 13;
			// 
			// textTelefono
			// 
			this.textTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textTelefono.Location = new System.Drawing.Point(491, 276);
			this.textTelefono.Name = "textTelefono";
			this.textTelefono.Size = new System.Drawing.Size(223, 27);
			this.textTelefono.TabIndex = 12;
			// 
			// textRFC
			// 
			this.textRFC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textRFC.Location = new System.Drawing.Point(174, 275);
			this.textRFC.Name = "textRFC";
			this.textRFC.Size = new System.Drawing.Size(223, 27);
			this.textRFC.TabIndex = 11;
			// 
			// textEmpresa
			// 
			this.textEmpresa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textEmpresa.Location = new System.Drawing.Point(16, 236);
			this.textEmpresa.Name = "textEmpresa";
			this.textEmpresa.Size = new System.Drawing.Size(699, 27);
			this.textEmpresa.TabIndex = 10;
			// 
			// textMaterno
			// 
			this.textMaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textMaterno.Location = new System.Drawing.Point(16, 183);
			this.textMaterno.Name = "textMaterno";
			this.textMaterno.Size = new System.Drawing.Size(699, 27);
			this.textMaterno.TabIndex = 9;
			// 
			// textPaterno
			// 
			this.textPaterno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textPaterno.Location = new System.Drawing.Point(16, 128);
			this.textPaterno.Name = "textPaterno";
			this.textPaterno.Size = new System.Drawing.Size(699, 27);
			this.textPaterno.TabIndex = 8;
			// 
			// textNombre
			// 
			this.textNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textNombre.Location = new System.Drawing.Point(12, 73);
			this.textNombre.Name = "textNombre";
			this.textNombre.Size = new System.Drawing.Size(699, 27);
			this.textNombre.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(410, 280);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Telefono";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 326);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(266, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Correo";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 279);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(266, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "RFC de la Empresa";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 213);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(266, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Nombre de la Empresa";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(266, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Apellido materno del proveedor";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(266, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Apellido paterno del proveedor";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(194, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre del Proveedor";
			// 
			// RegistrarProveedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 465);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegistrarProveedor";
			this.Text = "RegistrarProveedor";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
