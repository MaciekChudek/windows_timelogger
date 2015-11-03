/*
 * Created by SharpDevelop.
 * User: Maciek
 * Date: 1/8/2010
 * Time: 12:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace timeLogger
{
	/// <summary>
	/// Description of LogDialog.
	/// </summary>
	public partial class LogDialog : Form
	{
		public string result;
		
		public LogDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
		
		void ButtonLogClick(object sender, EventArgs e)
		{
			result = textBox1.Text;
			this.DialogResult = DialogResult.OK;
		}
	}
}
