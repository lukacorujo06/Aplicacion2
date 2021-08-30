using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicacion_2{

	public partial class MainForm : Form{
		
		public MainForm(){

			InitializeComponent();

		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			lbl_saludo.Text = "Hola " + txt_ingresar_nombre.Text;
			
			
			if (rbtm_color_rojo.Checked){
				
				lbl_saludo.ForeColor = Color.Red;
				
			}
			
			else if (rbtm_color_verde.Checked){
				
				lbl_saludo.ForeColor = Color.Green;
				
			}
			
			else if (rbtm_color_azul.Checked){
				
				lbl_saludo.ForeColor = Color.Blue;
				
			}
			
		}
		
		void Txt_ingresar_nombreTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Lbl_saludoClick(object sender, EventArgs e)
		{
			
		}
	}
}
