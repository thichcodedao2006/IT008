namespace Bai10
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
            this.cbbEndCap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbStartCap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbDashCap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLineJoin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbWidth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDashStyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.cbbEndCap);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbbStartCap);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbbDashCap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbbLineJoin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbbWidth);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbbDashStyle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 670);
            this.panel1.TabIndex = 0;
            // 
            // cbbEndCap
            // 
            this.cbbEndCap.FormattingEnabled = true;
            this.cbbEndCap.Location = new System.Drawing.Point(115, 327);
            this.cbbEndCap.Name = "cbbEndCap";
            this.cbbEndCap.Size = new System.Drawing.Size(187, 24);
            this.cbbEndCap.TabIndex = 11;
            this.cbbEndCap.SelectedIndexChanged += new System.EventHandler(this.cbbEndCap_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "End Cap:";
            // 
            // cbbStartCap
            // 
            this.cbbStartCap.FormattingEnabled = true;
            this.cbbStartCap.Location = new System.Drawing.Point(115, 272);
            this.cbbStartCap.Name = "cbbStartCap";
            this.cbbStartCap.Size = new System.Drawing.Size(187, 24);
            this.cbbStartCap.TabIndex = 9;
            this.cbbStartCap.SelectedIndexChanged += new System.EventHandler(this.cbbStartCap_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Start Cap:";
            // 
            // cbbDashCap
            // 
            this.cbbDashCap.FormattingEnabled = true;
            this.cbbDashCap.Items.AddRange(new object[] {
            "Flat",
            "Round",
            "Triangle"});
            this.cbbDashCap.Location = new System.Drawing.Point(115, 209);
            this.cbbDashCap.Name = "cbbDashCap";
            this.cbbDashCap.Size = new System.Drawing.Size(187, 24);
            this.cbbDashCap.TabIndex = 7;
            this.cbbDashCap.SelectedIndexChanged += new System.EventHandler(this.cbbDashCap_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dash Cap:";
            // 
            // cbbLineJoin
            // 
            this.cbbLineJoin.FormattingEnabled = true;
            this.cbbLineJoin.Items.AddRange(new object[] {
            "Miter",
            "Bevel",
            "Round"});
            this.cbbLineJoin.Location = new System.Drawing.Point(115, 144);
            this.cbbLineJoin.Name = "cbbLineJoin";
            this.cbbLineJoin.Size = new System.Drawing.Size(187, 24);
            this.cbbLineJoin.TabIndex = 5;
            this.cbbLineJoin.SelectedIndexChanged += new System.EventHandler(this.cbbLineJoin_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Line Join:";
            // 
            // cbbWidth
            // 
            this.cbbWidth.FormattingEnabled = true;
            this.cbbWidth.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40"});
            this.cbbWidth.Location = new System.Drawing.Point(115, 84);
            this.cbbWidth.Name = "cbbWidth";
            this.cbbWidth.Size = new System.Drawing.Size(187, 24);
            this.cbbWidth.TabIndex = 3;
            this.cbbWidth.SelectedIndexChanged += new System.EventHandler(this.cbbWidth_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width:";
            // 
            // cbbDashStyle
            // 
            this.cbbDashStyle.FormattingEnabled = true;
            this.cbbDashStyle.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot"});
            this.cbbDashStyle.Location = new System.Drawing.Point(115, 28);
            this.cbbDashStyle.Name = "cbbDashStyle";
            this.cbbDashStyle.Size = new System.Drawing.Size(187, 24);
            this.cbbDashStyle.TabIndex = 1;
            this.cbbDashStyle.SelectedIndexChanged += new System.EventHandler(this.cbbDashStyle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dash Style:";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(336, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 670);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 670);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pen Demo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbDashStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbWidth;
        private System.Windows.Forms.ComboBox cbbDashCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbLineJoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbEndCap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbStartCap;
        private System.Windows.Forms.Label label5;
    }
}

