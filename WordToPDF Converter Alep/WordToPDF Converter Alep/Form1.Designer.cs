namespace WordToPDF_Converter_Alep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.D_SOURCE = new System.Windows.Forms.TextBox();
            this.B_SOURCE = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.D_TARGET = new System.Windows.Forms.TextBox();
            this.B_TARGET = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OFD_SOURCE = new System.Windows.Forms.OpenFileDialog();
            this.BFD_TARGET = new System.Windows.Forms.FolderBrowserDialog();
            this.B_CONVERT = new System.Windows.Forms.Button();
            this.I_NAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // D_SOURCE
            // 
            this.D_SOURCE.Location = new System.Drawing.Point(125, 61);
            this.D_SOURCE.Name = "D_SOURCE";
            this.D_SOURCE.ReadOnly = true;
            this.D_SOURCE.Size = new System.Drawing.Size(123, 22);
            this.D_SOURCE.TabIndex = 14;
            // 
            // B_SOURCE
            // 
            this.B_SOURCE.ForeColor = System.Drawing.Color.Black;
            this.B_SOURCE.Location = new System.Drawing.Point(249, 61);
            this.B_SOURCE.Name = "B_SOURCE";
            this.B_SOURCE.Size = new System.Drawing.Size(66, 23);
            this.B_SOURCE.TabIndex = 13;
            this.B_SOURCE.Text = "Browse";
            this.B_SOURCE.UseVisualStyleBackColor = true;
            this.B_SOURCE.Click += new System.EventHandler(this.B_SOURCE_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 64);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(94, 17);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Source Path :";
            // 
            // D_TARGET
            // 
            this.D_TARGET.Location = new System.Drawing.Point(123, 115);
            this.D_TARGET.Name = "D_TARGET";
            this.D_TARGET.ReadOnly = true;
            this.D_TARGET.Size = new System.Drawing.Size(123, 22);
            this.D_TARGET.TabIndex = 17;
            // 
            // B_TARGET
            // 
            this.B_TARGET.ForeColor = System.Drawing.Color.Black;
            this.B_TARGET.Location = new System.Drawing.Point(247, 115);
            this.B_TARGET.Name = "B_TARGET";
            this.B_TARGET.Size = new System.Drawing.Size(66, 23);
            this.B_TARGET.TabIndex = 16;
            this.B_TARGET.Text = "Browse";
            this.B_TARGET.UseVisualStyleBackColor = true;
            this.B_TARGET.Click += new System.EventHandler(this.B_TARGET_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Target Path :";
            // 
            // OFD_SOURCE
            // 
            this.OFD_SOURCE.FileName = "OpenFileDialog1";
            // 
            // B_CONVERT
            // 
            this.B_CONVERT.Location = new System.Drawing.Point(240, 218);
            this.B_CONVERT.Name = "B_CONVERT";
            this.B_CONVERT.Size = new System.Drawing.Size(75, 23);
            this.B_CONVERT.TabIndex = 18;
            this.B_CONVERT.Text = "Convert";
            this.B_CONVERT.UseVisualStyleBackColor = true;
            this.B_CONVERT.Click += new System.EventHandler(this.B_CONVERT_Click);
            // 
            // I_NAME
            // 
            this.I_NAME.Location = new System.Drawing.Point(122, 167);
            this.I_NAME.Name = "I_NAME";
            this.I_NAME.Size = new System.Drawing.Size(190, 22);
            this.I_NAME.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "New File Name :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(322, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 253);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.I_NAME);
            this.Controls.Add(this.B_CONVERT);
            this.Controls.Add(this.D_TARGET);
            this.Controls.Add(this.B_TARGET);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.D_SOURCE);
            this.Controls.Add(this.B_SOURCE);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word To PDF";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox D_SOURCE;
        internal System.Windows.Forms.Button B_SOURCE;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox D_TARGET;
        internal System.Windows.Forms.Button B_TARGET;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.OpenFileDialog OFD_SOURCE;
        private System.Windows.Forms.FolderBrowserDialog BFD_TARGET;
        private System.Windows.Forms.Button B_CONVERT;
        private System.Windows.Forms.TextBox I_NAME;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

