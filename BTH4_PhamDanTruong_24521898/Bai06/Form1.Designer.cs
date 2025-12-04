namespace Bai06
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbRoot = new System.Windows.Forms.Label();
            this.lbDes = new System.Windows.Forms.Label();
            this.txbSource = new System.Windows.Forms.TextBox();
            this.txbDes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnCopy);
            this.GroupBox1.Controls.Add(this.button2);
            this.GroupBox1.Controls.Add(this.button1);
            this.GroupBox1.Controls.Add(this.txbDes);
            this.GroupBox1.Controls.Add(this.txbSource);
            this.GroupBox1.Controls.Add(this.lbDes);
            this.GroupBox1.Controls.Add(this.lbRoot);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.GroupBox1.Location = new System.Drawing.Point(12, 21);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(776, 264);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Sao chép tập tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(13, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 124);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiến trình sao chép";
            // 
            // lbRoot
            // 
            this.lbRoot.AutoSize = true;
            this.lbRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoot.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbRoot.Location = new System.Drawing.Point(47, 55);
            this.lbRoot.Name = "lbRoot";
            this.lbRoot.Size = new System.Drawing.Size(216, 20);
            this.lbRoot.TabIndex = 0;
            this.lbRoot.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbDes.Location = new System.Drawing.Point(47, 127);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(202, 20);
            this.lbDes.TabIndex = 1;
            this.lbDes.Text = "Đường Dẫn Thư Mục Đích";
            this.lbDes.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbSource
            // 
            this.txbSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSource.Location = new System.Drawing.Point(290, 52);
            this.txbSource.Name = "txbSource";
            this.txbSource.Size = new System.Drawing.Size(382, 30);
            this.txbSource.TabIndex = 2;
            // 
            // txbDes
            // 
            this.txbDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDes.Location = new System.Drawing.Point(290, 117);
            this.txbDes.Name = "txbDes";
            this.txbDes.Size = new System.Drawing.Size(382, 30);
            this.txbDes.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(694, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Location = new System.Drawing.Point(695, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCopy.Location = new System.Drawing.Point(297, 209);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(183, 30);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Sao Chép";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 56);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(676, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(210, 20);
            this.lbStatus.Text = "Không có file nào để sao chép";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao chép tập tin";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.Label lbRoot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbSource;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbDes;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
    }
}

