using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsJava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = @"C:\Program Files\Java\jdk-20\bin\java.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden ;
            startInfo.RedirectStandardOutput = true;
            startInfo.WorkingDirectory = @"C:\Users\Un Name\Documents\Visual Studio 2022\WindowsFormsJava";
            startInfo.Arguments = $"hello {textBox1.Text}  {maskedTextBox1.Text}";
            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                    while (!exeProcess.StandardOutput.EndOfStream)
                    {
                        string line = exeProcess.StandardOutput.ReadLine();
                        textBox2.AppendText(line + "\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                textBox2.AppendText($"ERROR: {ex.Message}");
            }
        }
    }
}
