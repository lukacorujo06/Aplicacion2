/*
 * Created by SharpDevelop.
 * User: LAB03
 * Date: 30/8/2021
 * Time: 8:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Aplicacion_2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.lbl_nombre = new System.Windows.Forms.Label();
			this.txt_ingresar_nombre = new System.Windows.Forms.TextBox();
			this.rbtm_color_rojo = new System.Windows.Forms.RadioButton();
			this.rbtm_color_verde = new System.Windows.Forms.RadioButton();
			this.rbtm_color_azul = new System.Windows.Forms.RadioButton();
			this.btn_saludar = new System.Windows.Forms.Button();
			this.lbl_saludo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_nombre
			// 
			this.lbl_nombre.Location = new System.Drawing.Point(38, 21);
			this.lbl_nombre.Name = "lbl_nombre";
			this.lbl_nombre.Size = new System.Drawing.Size(100, 23);
			this.lbl_nombre.TabIndex = 0;
			this.lbl_nombre.Text = "Nombre:";
			// 
			// txt_ingresar_nombre
			// 
			this.txt_ingresar_nombre.Location = new System.Drawing.Point(91, 18);
			this.txt_ingresar_nombre.Name = "txt_ingresar_nombre";
			this.txt_ingresar_nombre.Size = new System.Drawing.Size(120, 20);
			this.txt_ingresar_nombre.TabIndex = 1;
			this.txt_ingresar_nombre.TextChanged += new System.EventHandler(this.Txt_ingresar_nombreTextChanged);
			// 
			// rbtm_color_rojo
			// 
			this.rbtm_color_rojo.ForeColor = System.Drawing.Color.Red;
			this.rbtm_color_rojo.Location = new System.Drawing.Point(67, 68);
			this.rbtm_color_rojo.Name = "rbtm_color_rojo";
			this.rbtm_color_rojo.Size = new System.Drawing.Size(104, 24);
			this.rbtm_color_rojo.TabIndex = 2;
			this.rbtm_color_rojo.Text = "Rojo";
			this.rbtm_color_rojo.UseVisualStyleBackColor = true;
			// 
			// rbtm_color_verde
			// 
			this.rbtm_color_verde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.rbtm_color_verde.Location = new System.Drawing.Point(67, 98);
			this.rbtm_color_verde.Name = "rbtm_color_verde";
			this.rbtm_color_verde.Size = new System.Drawing.Size(104, 24);
			this.rbtm_color_verde.TabIndex = 3;
			this.rbtm_color_verde.Text = "Verde";
			this.rbtm_color_verde.UseVisualStyleBackColor = true;
			// 
			// rbtm_color_azul
			// 
			this.rbtm_color_azul.ForeColor = System.Drawing.Color.Blue;
			this.rbtm_color_azul.Location = new System.Drawing.Point(67, 128);
			this.rbtm_color_azul.Name = "rbtm_color_azul";
			this.rbtm_color_azul.Size = new System.Drawing.Size(104, 24);
			this.rbtm_color_azul.TabIndex = 4;
			this.rbtm_color_azul.Text = "Azul";
			this.rbtm_color_azul.UseVisualStyleBackColor = true;
			// 
			// btn_saludar
			// 
			this.btn_saludar.Location = new System.Drawing.Point(67, 170);
			this.btn_saludar.Name = "btn_saludar";
			this.btn_saludar.Size = new System.Drawing.Size(130, 23);
			this.btn_saludar.TabIndex = 5;
			this.btn_saludar.Text = "Saludar";
			this.btn_saludar.UseVisualStyleBackColor = true;
			this.btn_saludar.Click += new System.EventHandler(this.Button1Click);
			// 
			// lbl_saludo
			// 
			this.lbl_saludo.Location = new System.Drawing.Point(67, 219);
			this.lbl_saludo.Name = "lbl_saludo";
			this.lbl_saludo.Size = new System.Drawing.Size(130, 23);
			this.lbl_saludo.TabIndex = 6;
			this.lbl_saludo.Click += new System.EventHandler(this.Lbl_saludoClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lbl_saludo);
			this.Controls.Add(this.btn_saludar);
			this.Controls.Add(this.rbtm_color_azul);
			this.Controls.Add(this.rbtm_color_verde);
			this.Controls.Add(this.rbtm_color_rojo);
			this.Controls.Add(this.txt_ingresar_nombre);
			this.Controls.Add(this.lbl_nombre);
			this.Name = "MainForm";
			this.Text = "Aplicacion 2";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lbl_saludo;
		private System.Windows.Forms.Button btn_saludar;
		private System.Windows.Forms.RadioButton rbtm_color_azul;
		private System.Windows.Forms.RadioButton rbtm_color_verde;
		private System.Windows.Forms.RadioButton rbtm_color_rojo;
		private System.Windows.Forms.TextBox txt_ingresar_nombre;
		private System.Windows.Forms.Label lbl_nombre;
	}
}
