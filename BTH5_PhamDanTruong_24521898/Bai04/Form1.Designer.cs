namespace Bai04
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
            this.FontLabekl = new System.Windows.Forms.Label();
            this.cbbFont = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.rbCenter = new System.Windows.Forms.RadioButton();
            this.rbLeft = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorButton = new System.Windows.Forms.Button();
            this.rtxbText = new System.Windows.Forms.RichTextBox();
            this.cbBold = new System.Windows.Forms.CheckBox();
            this.cbUnderline = new System.Windows.Forms.CheckBox();
            this.cbItalic = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FontLabekl
            // 
            this.FontLabekl.AutoSize = true;
            this.FontLabekl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontLabekl.Location = new System.Drawing.Point(58, 69);
            this.FontLabekl.Name = "FontLabekl";
            this.FontLabekl.Size = new System.Drawing.Size(51, 25);
            this.FontLabekl.TabIndex = 0;
            this.FontLabekl.Text = "Font";
            // 
            // cbbFont
            // 
            this.cbbFont.FormattingEnabled = true;
            this.cbbFont.Location = new System.Drawing.Point(115, 70);
            this.cbbFont.Name = "cbbFont";
            this.cbbFont.Size = new System.Drawing.Size(166, 24);
            this.cbbFont.TabIndex = 1;
            this.cbbFont.SelectedIndexChanged += new System.EventHandler(this.cbbFont_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRight);
            this.groupBox1.Controls.Add(this.rbCenter);
            this.groupBox1.Controls.Add(this.rbLeft);
            this.groupBox1.Location = new System.Drawing.Point(61, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Align Text";
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.Location = new System.Drawing.Point(7, 95);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(59, 20);
            this.rbRight.TabIndex = 2;
            this.rbRight.TabStop = true;
            this.rbRight.Text = "Right";
            this.rbRight.UseVisualStyleBackColor = true;
            this.rbRight.CheckedChanged += new System.EventHandler(this.AlignChange);
            // 
            // rbCenter
            // 
            this.rbCenter.AutoSize = true;
            this.rbCenter.Location = new System.Drawing.Point(7, 58);
            this.rbCenter.Name = "rbCenter";
            this.rbCenter.Size = new System.Drawing.Size(67, 20);
            this.rbCenter.TabIndex = 1;
            this.rbCenter.TabStop = true;
            this.rbCenter.Text = "Center";
            this.rbCenter.UseVisualStyleBackColor = true;
            this.rbCenter.CheckedChanged += new System.EventHandler(this.AlignChange);
            // 
            // rbLeft
            // 
            this.rbLeft.AutoSize = true;
            this.rbLeft.Location = new System.Drawing.Point(7, 22);
            this.rbLeft.Name = "rbLeft";
            this.rbLeft.Size = new System.Drawing.Size(49, 20);
            this.rbLeft.TabIndex = 0;
            this.rbLeft.TabStop = true;
            this.rbLeft.Text = "Left";
            this.rbLeft.UseVisualStyleBackColor = true;
            this.rbLeft.CheckedChanged += new System.EventHandler(this.AlignChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size";
            // 
            // cbbSize
            // 
            this.cbbSize.FormattingEnabled = true;
            this.cbbSize.Items.AddRange(new object[] {
            "8 ",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20 ",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cbbSize.Location = new System.Drawing.Point(479, 70);
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.Size = new System.Drawing.Size(121, 24);
            this.cbbSize.TabIndex = 5;
            this.cbbSize.SelectedIndexChanged += new System.EventHandler(this.cbbSize_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color";
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(479, 126);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(59, 27);
            this.ColorButton.TabIndex = 7;
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // rtxbText
            // 
            this.rtxbText.Location = new System.Drawing.Point(396, 194);
            this.rtxbText.Name = "rtxbText";
            this.rtxbText.Size = new System.Drawing.Size(328, 97);
            this.rtxbText.TabIndex = 8;
            this.rtxbText.Text = "";
            // 
            // cbBold
            // 
            this.cbBold.AutoSize = true;
            this.cbBold.Image = global::Bai04.Properties.Resources.format_bold_24dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.cbBold.Location = new System.Drawing.Point(61, 135);
            this.cbBold.Name = "cbBold";
            this.cbBold.Size = new System.Drawing.Size(42, 24);
            this.cbBold.TabIndex = 11;
            this.cbBold.UseVisualStyleBackColor = true;
            this.cbBold.CheckedChanged += new System.EventHandler(this.cbBold_CheckedChanged);
            // 
            // cbUnderline
            // 
            this.cbUnderline.AutoSize = true;
            this.cbUnderline.Image = global::Bai04.Properties.Resources.format_underlined_24dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.cbUnderline.Location = new System.Drawing.Point(181, 135);
            this.cbUnderline.Name = "cbUnderline";
            this.cbUnderline.Size = new System.Drawing.Size(42, 24);
            this.cbUnderline.TabIndex = 10;
            this.cbUnderline.UseVisualStyleBackColor = true;
            this.cbUnderline.CheckedChanged += new System.EventHandler(this.cbUnderline_CheckedChanged);
            // 
            // cbItalic
            // 
            this.cbItalic.AutoSize = true;
            this.cbItalic.Image = global::Bai04.Properties.Resources.format_italic_24dp_BLACK_FILL0_wght400_GRAD0_opsz24;
            this.cbItalic.Location = new System.Drawing.Point(121, 135);
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.Size = new System.Drawing.Size(42, 24);
            this.cbItalic.TabIndex = 9;
            this.cbItalic.UseVisualStyleBackColor = true;
            this.cbItalic.CheckedChanged += new System.EventHandler(this.cbItalic_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 525);
            this.Controls.Add(this.cbBold);
            this.Controls.Add(this.cbUnderline);
            this.Controls.Add(this.cbItalic);
            this.Controls.Add(this.rtxbText);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbFont);
            this.Controls.Add(this.FontLabekl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FontLabekl;
        private System.Windows.Forms.ComboBox cbbFont;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRight;
        private System.Windows.Forms.RadioButton rbCenter;
        private System.Windows.Forms.RadioButton rbLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.RichTextBox rtxbText;
        private System.Windows.Forms.CheckBox cbItalic;
        private System.Windows.Forms.CheckBox cbUnderline;
        private System.Windows.Forms.CheckBox cbBold;
    }
}

