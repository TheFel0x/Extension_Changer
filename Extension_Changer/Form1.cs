using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extension_Changer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_dir_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(tb_dir.Text)) btn_change.Enabled = true;
            else btn_change.Enabled = false;
        }

        private void btn_dir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) 
            {
                tb_dir.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            tb_dir.ReadOnly = true;
            btn_dir.Enabled = false;
            string from = tb_from.Text;
            string to = tb_to.Text;
            foreach (string file in Directory.GetFiles(tb_dir.Text))
            {
                if (file.Remove(0, file.Length - from.Length) == from)
                {
                    string result = Path.ChangeExtension(file, "." + to);
                    File.Delete(result);
                    File.Move(file, result);
                }
            }
            tb_dir.ReadOnly = false;
            btn_dir.Enabled = true;
            MessageBox.Show("Done.");
        }
    }
}
