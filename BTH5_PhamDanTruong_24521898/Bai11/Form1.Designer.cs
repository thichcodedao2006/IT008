namespace Bai11
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbElipse = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbWidth = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbSolid = new System.Windows.Forms.RadioButton();
            this.rbHatch = new System.Windows.Forms.RadioButton();
            this.rbTexture = new System.Windows.Forms.RadioButton();
            this.rbLinear = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 762);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(394, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 762);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbElipse);
            this.groupBox1.Controls.Add(this.rbRectangle);
            this.groupBox1.Controls.Add(this.rbLine);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape";
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbLine.Location = new System.Drawing.Point(25, 30);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(70, 29);
            this.rbLine.TabIndex = 0;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbRectangle.Location = new System.Drawing.Point(25, 77);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(120, 29);
            this.rbRectangle.TabIndex = 1;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbElipse
            // 
            this.rbElipse.AutoSize = true;
            this.rbElipse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbElipse.Location = new System.Drawing.Point(25, 128);
            this.rbElipse.Name = "rbElipse";
            this.rbElipse.Size = new System.Drawing.Size(86, 29);
            this.rbElipse.TabIndex = 2;
            this.rbElipse.TabStop = true;
            this.rbElipse.Text = "Elipse";
            this.rbElipse.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txbWidth);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox2.Location = new System.Drawing.Point(13, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            // 
            // txbWidth
            // 
            this.txbWidth.Location = new System.Drawing.Point(99, 49);
            this.txbWidth.Name = "txbWidth";
            this.txbWidth.Size = new System.Drawing.Size(203, 30);
            this.txbWidth.TabIndex = 1;
            this.txbWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbWidth.TextChanged += new System.EventHandler(this.txbWidth_TextChanged);
            this.txbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbWidth_KeyPress);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(109, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Color...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbLinear);
            this.groupBox3.Controls.Add(this.rbTexture);
            this.groupBox3.Controls.Add(this.rbHatch);
            this.groupBox3.Controls.Add(this.rbSolid);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox3.Location = new System.Drawing.Point(13, 436);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 314);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brushes";
            // 
            // rbSolid
            // 
            this.rbSolid.AutoSize = true;
            this.rbSolid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbSolid.Location = new System.Drawing.Point(25, 43);
            this.rbSolid.Name = "rbSolid";
            this.rbSolid.Size = new System.Drawing.Size(128, 29);
            this.rbSolid.TabIndex = 0;
            this.rbSolid.TabStop = true;
            this.rbSolid.Text = "SolidBrush";
            this.rbSolid.UseVisualStyleBackColor = true;
            this.rbSolid.CheckedChanged += new System.EventHandler(this.RadioButton_Changed);
            // 
            // rbHatch
            // 
            this.rbHatch.AutoSize = true;
            this.rbHatch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbHatch.Location = new System.Drawing.Point(25, 97);
            this.rbHatch.Name = "rbHatch";
            this.rbHatch.Size = new System.Drawing.Size(135, 29);
            this.rbHatch.TabIndex = 1;
            this.rbHatch.TabStop = true;
            this.rbHatch.Text = "HatchBrush";
            this.rbHatch.UseVisualStyleBackColor = true;
            this.rbHatch.CheckedChanged += new System.EventHandler(this.RadioButton_Changed);
            // 
            // rbTexture
            // 
            this.rbTexture.AutoSize = true;
            this.rbTexture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbTexture.Location = new System.Drawing.Point(25, 155);
            this.rbTexture.Name = "rbTexture";
            this.rbTexture.Size = new System.Drawing.Size(151, 29);
            this.rbTexture.TabIndex = 2;
            this.rbTexture.TabStop = true;
            this.rbTexture.Text = "TextureBrush";
            this.rbTexture.UseVisualStyleBackColor = true;
            this.rbTexture.CheckedChanged += new System.EventHandler(this.RadioButton_Changed);
            // 
            // rbLinear
            // 
            this.rbLinear.AutoSize = true;
            this.rbLinear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbLinear.Location = new System.Drawing.Point(25, 215);
            this.rbLinear.Name = "rbLinear";
            this.rbLinear.Size = new System.Drawing.Size(212, 29);
            this.rbLinear.TabIndex = 3;
            this.rbLinear.TabStop = true;
            this.rbLinear.Text = "LinearGradientBrush";
            this.rbLinear.UseVisualStyleBackColor = true;
            this.rbLinear.CheckedChanged += new System.EventHandler(this.RadioButton_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 762);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai Thi";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbElipse;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbLinear;
        private System.Windows.Forms.RadioButton rbTexture;
        private System.Windows.Forms.RadioButton rbHatch;
        private System.Windows.Forms.RadioButton rbSolid;
        private System.Windows.Forms.Button button1;
    }
}

