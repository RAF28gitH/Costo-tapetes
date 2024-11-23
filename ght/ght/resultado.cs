/*
 * Created by SharpDevelop.
 * User: CC1_PC10
 * Date: 22/11/2024
 * Time: 08:25 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ght
{
	/// <summary>
	/// Description of resultado.
	/// </summary>
	public partial class resultado : Form
	{
		public resultado(ulong res)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			label1.Text="$"+res.ToString();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
