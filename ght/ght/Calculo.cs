/*
 * Created by SharpDevelop.
 * User: 52445
 * Date: 21/11/2024
 * Time: 07:06 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ght
{
	/// <summary>
	/// Description of Calculo.
	/// </summary>
	public partial class Calculo : Form
	{
		ulong resultado = 0; //creo una variable para guardar el resultado
		public Calculo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label26Click(object sender, EventArgs e)
		{
	        resultado = 0;
	
	        ulong impar,par;
	        TextBox[] textBoxes = {
	            textBox1, textBox2, textBox3, textBox4,
	            textBox5, textBox6, textBox7, textBox8,
	            textBox9, textBox10, textBox11, textBox12,
	            textBox13, textBox14, textBox15, textBox16
	        }; //creo un arreglo que guarda los textbox para después iterar sobre este
	
	        for (int i=0; i<textBoxes.Length; i+=2) //este for recorre el arreglo de textboxes y multiplica cada número por el número del textbox siguiente
	        {
	            if (ulong.TryParse(textBoxes[i].Text, out impar) &&
	                ulong.TryParse(textBoxes[i + 1].Text, out par))
	            {
	                resultado += impar * par;
	            }
	        }
	        
			resultado form2 = new resultado(resultado); //indico que el formulario resultado debe recibir una variable, en este caso mandando la del resultado
			form2.Show();
		}
	}
}
