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
            this.SuspendLayout();
            // 
            // tb_dir
            // 
            this.tb_dir.Location = new System.Drawing.Point(15, 40);
            this.tb_dir.Name = "tb_dir";
            this.tb_dir.Size = new System.Drawing.Size(607, 20);
            this.tb_dir.TabIndex = 0;
            this.tb_dir.TextChanged += new System.EventHandler(this.tb_dir_TextChanged);
            // 
            // btn_dir
            // 
            this.btn_dir.Location = new System.Drawing.Point(628, 37);
            this.btn_dir.Name = "btn_dir";
            this.btn_dir.Size = new System.Drawing.Size(199, 23);
            this.btn_dir.TabIndex = 1;
            this.btn_dir.Text = "Choose Directory";
            this.btn_dir.UseVisualStyleBackColor = true;
            this.btn_dir.Click += new System.EventHandler(this.btn_dir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "from:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "to:";
            // 
            // tb_from
            // 
            this.tb_from.Location = new System.Drawing.Point(57, 101);
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(100, 20);
            this.tb_from.TabIndex = 4;
            this.tb_from.Text = "jfif";
            // 
            // tb_to
            // 
            this.tb_to.Location = new System.Drawing.Point(57, 147);
            this.tb_to.Name = "tb_to";
            this.tb_to.Size = new System.Drawing.Size(100, 20);
            this.tb_to.TabIndex = 5;
            this.tb_to.Text = "jpg";
            // 
            // btn_change
            // 
            this.btn_change.Enabled = false;
            this.btn_change.Location = new System.Drawing.Point(193, 101);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(634, 66);
            this.btn_change.TabIndex = 6;
            this.btn_change.Text = "Change File Extensions For Entire Directory";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 190);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.tb_to);
            this.Controls.Add(this.tb_from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dir);
            this.Controls.Add(this.tb_dir);
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
    }
}

