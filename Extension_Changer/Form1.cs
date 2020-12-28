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
        bool searchSub = false;
        string dirName = "";
        List<string> fileList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_dir_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(tb_dir.Text))
            {
                dirName = tb_dir.Text;
                updateLabel();
                btn_change.Enabled = true;
                btn_check.Enabled = true;
                cb_sub.Enabled = true;
            }
            else 
            {
                btn_change.Enabled = false;
                btn_check.Enabled = false;
                cb_sub.Enabled = false;
            }
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

        private void cb_sub_CheckedChanged(object sender, EventArgs e)
        {
            searchSub = cb_sub.Checked;
            updateLabel();
        }

        public int countFiles(string dir, int count = 0) 
        {
            foreach (string file in Directory.GetFiles(dir))
            {
                if (file.Remove(0, file.Length - tb_from.Text.Length) == tb_from.Text)
                {
                    count++;
                    fileList.Add(file);
                }
            }
            if (searchSub)
            {
                foreach (string newDir in Directory.GetDirectories(dir))
                {
                    count += countFiles(newDir);
                }
            }
            return count;
        }

        private void tb_from_TextChanged(object sender, EventArgs e)
        {
            updateLabel();
        }

        public void updateLabel() 
        {
            fileList.Clear();
            lb_filecount.Text = countFiles(dirName).ToString();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            fileList.Clear();
            int num = countFiles(dirName);
            if (num == 0)
            {
                MessageBox.Show("No \"."+tb_from.Text+"\" files found in specified location.");
            }
            else 
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save a list of "+num+" \"."+tb_from.Text+"\" files?", "Save File List", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Title = "Save";
                    saveDialog.Filter = "Text Files (*.txt)|*.txt" + "|" +
                                        "All Files (*.*)|*.*";
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string file = saveDialog.FileName;
                        System.IO.File.WriteAllLines(file, fileList);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //nothing
                }
            }
        }
    }
}
