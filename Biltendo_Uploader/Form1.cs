using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Biltendo_Uploader
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public string filePath;
        public string selectedsys;
        public string selectedsysname;
        public string biltendofolder;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.openFileDialog1 = new OpenFileDialog();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = selectedsysname + "|*." + selectedsys;
            openFileDialog1.ShowDialog();
            filePath = openFileDialog1.FileName;
            button2.Enabled = true;
            label5.Text = "Seçilen Dosya Yolu: " + filePath;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                selectedsys = "nes";
                selectedsysname = "Nintendo Entertainment System";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                selectedsys = "gb";
                selectedsysname = "Nintendo Game Boy";
            }
            biltendofolder = "\\" + "\\" + "retropie" + "\\" + "roms" + "\\" + selectedsys + "\\";
            label7.Text = biltendofolder;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            File.Copy(filePath, biltendofolder  + Path.GetFileName(filePath));
            MessageBox.Show("Dosya başarıyla yüklendi.", "Yükleme", MessageBoxButtons.OK);
        }
    }
}
