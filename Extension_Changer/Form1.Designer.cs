namespace Extension_Changer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_dir = new System.Windows.Forms.TextBox();
            this.btn_dir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.tb_to = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_check = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_filecount = new System.Windows.Forms.Label();
            this.cb_sub = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_dir
            // 
            this.tb_dir.Location = new System.Drawing.Point(22, 62);
            this.tb_dir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_dir.Name = "tb_dir";
            this.tb_dir.Size = new System.Drawing.Size(908, 26);
            this.tb_dir.TabIndex = 0;
            this.tb_dir.TextChanged += new System.EventHandler(this.tb_dir_TextChanged);
            // 
            // btn_dir
            // 
            this.btn_dir.Location = new System.Drawing.Point(942, 57);
            this.btn_dir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_dir.Name = "btn_dir";
            this.btn_dir.Size = new System.Drawing.Size(298, 35);
            this.btn_dir.TabIndex = 1;
            this.btn_dir.Text = "Choose Directory";
            this.btn_dir.UseVisualStyleBackColor = true;
            this.btn_dir.Click += new System.EventHandler(this.btn_dir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "from:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "to:";
            // 
            // tb_from
            // 
            this.tb_from.Location = new System.Drawing.Point(86, 155);
            this.tb_from.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(148, 26);
            this.tb_from.TabIndex = 4;
            this.tb_from.Text = "jfif";
            this.tb_from.TextChanged += new System.EventHandler(this.tb_from_TextChanged);
            // 
            // tb_to
            // 
            this.tb_to.Location = new System.Drawing.Point(86, 226);
            this.tb_to.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_to.Name = "tb_to";
            this.tb_to.Size = new System.Drawing.Size(148, 26);
            this.tb_to.TabIndex = 5;
            this.tb_to.Text = "jpg";
            // 
            // btn_change
            // 
            this.btn_change.Enabled = false;
            this.btn_change.Location = new System.Drawing.Point(290, 164);
            this.btn_change.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(951, 102);
            this.btn_change.TabIndex = 6;
            this.btn_change.Text = "Change File Extensions For Entire Directory";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_check
            // 
            this.btn_check.Enabled = false;
            this.btn_check.Location = new System.Drawing.Point(942, 100);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(298, 51);
            this.btn_check.TabIndex = 7;
            this.btn_check.Text = "Check Files";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Files Selected:";
            // 
            // lb_filecount
            // 
            this.lb_filecount.AutoSize = true;
            this.lb_filecount.Location = new System.Drawing.Point(405, 115);
            this.lb_filecount.Name = "lb_filecount";
            this.lb_filecount.Size = new System.Drawing.Size(18, 20);
            this.lb_filecount.TabIndex = 9;
            this.lb_filecount.Text = "0";
            // 
            // cb_sub
            // 
            this.cb_sub.AutoSize = true;
            this.cb_sub.Enabled = false;
            this.cb_sub.Location = new System.Drawing.Point(22, 96);
            this.cb_sub.Name = "cb_sub";
            this.cb_sub.Size = new System.Drawing.Size(161, 24);
            this.cb_sub.TabIndex = 10;
            this.cb_sub.Text = "search subfolders";
            this.cb_sub.UseVisualStyleBackColor = true;
            this.cb_sub.CheckedChanged += new System.EventHandler(this.cb_sub_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 292);
            this.Controls.Add(this.cb_sub);
            this.Controls.Add(this.lb_filecount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.tb_to);
            this.Controls.Add(this.tb_from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dir);
            this.Controls.Add(this.tb_dir);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "ExtCh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_dir;
        private System.Windows.Forms.Button btn_dir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.TextBox tb_to;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_filecount;
        private System.Windows.Forms.CheckBox cb_sub;
    }
}

