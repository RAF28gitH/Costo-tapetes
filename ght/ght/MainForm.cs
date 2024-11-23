/*
 * Created by SharpDevelop.
 * User: CC2_PC16
 * Date: 21/11/2024
 * Time: 07:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ght
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnDTClick(object sender, EventArgs e)
		{
			Calculo form1 = new Calculo(); //aquí solo muestro el formulario siguiente y ya
			form1.Show();
		}
	}
}
