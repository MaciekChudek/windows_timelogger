/*
 * Note, icon (with permission) from: http://www.fg-a.com.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace timelogger
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public static string logFile = "";
		public static string homePath = "";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			
			getConfig();
		}
		
		public static void getConfig()
		{
			
			if (File.Exists(homePath + "timeLogger.conf"))
			{
				StreamReader read = new StreamReader(homePath + "timeLogger.conf");
				logFile = read.ReadLine();
				read.Close();
			}
			else // create the file and write to it
			{
				logFile = homePath +  "log.txt";
				StreamWriter s = new StreamWriter(homePath + "timeLogger.conf", true);
				s.WriteLine(homePath + "log.txt");
				s.Close();
			}
		}
		


		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void ButtonLogClick(object sender, EventArgs e)
		{
			StreamWriter s = new StreamWriter(logFile, true);
			s.WriteLine(DateTime.Now.ToShortDateString() +" : " +DateTime.Now.DayOfWeek +" " + DateTime.Now.ToShortTimeString() +" -> "+ textBox1.Text + " <br />");
			s.Close();
			this.Close();
		}
	}
}
