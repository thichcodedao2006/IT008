namespace Bai06
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txbAnswerForm = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBackSForm = new System.Windows.Forms.Button();
            this.btnCEForm = new System.Windows.Forms.Button();
            this.btnCForm = new System.Windows.Forms.Button();
            this.btnMPlusForm = new System.Windows.Forms.Button();
            this.btnMSForm = new System.Windows.Forms.Button();
            this.btnMRForm = new System.Windows.Forms.Button();
            this.btnMCForm = new System.Windows.Forms.Button();
            this.btn0Form = new System.Windows.Forms.Button();
            this.btn1Form = new System.Windows.Forms.Button();
            this.btn4Form = new System.Windows.Forms.Button();
            this.btn7Form = new System.Windows.Forms.Button();
            this.btnDivideForm = new System.Windows.Forms.Button();
            this.btn9Form = new System.Windows.Forms.Button();
            this.btn8Form = new System.Windows.Forms.Button();
            this.btnSqrtForm = new System.Windows.Forms.Button();
            this.btnPerForm = new System.Windows.Forms.Button();
            this.btn5Form = new System.Windows.Forms.Button();
            this.btn6Form = new System.Windows.Forms.Button();
            this.btnMulForm = new System.Windows.Forms.Button();
            this.btnPhanSoForm = new System.Windows.Forms.Button();
            this.btn2Form = new System.Windows.Forms.Button();
            this.btn3Form = new System.Windows.Forms.Button();
            this.btnMinusForm = new System.Windows.Forms.Button();
            this.btnEqualForm = new System.Windows.Forms.Button();
            this.btnOptForm = new System.Windows.Forms.Button();
            this.btnColForm = new System.Windows.Forms.Button();
            this.bntPlusForm = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // txbAnswerForm
            // 
            this.txbAnswerForm.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAnswerForm.Location = new System.Drawing.Point(12, 44);
            this.txbAnswerForm.Name = "txbAnswerForm";
            this.txbAnswerForm.ReadOnly = true;
            this.txbAnswerForm.Size = new System.Drawing.Size(564, 51);
            this.txbAnswerForm.TabIndex = 1;
            this.txbAnswerForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox2.Location = new System.Drawing.Point(12, 116);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(65, 64);
            this.textBox2.TabIndex = 2;
            // 
            // btnBackSForm
            // 
            this.btnBackSForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSForm.ForeColor = System.Drawing.Color.Red;
            this.btnBackSForm.Location = new System.Drawing.Point(102, 116);
            this.btnBackSForm.Name = "btnBackSForm";
            this.btnBackSForm.Size = new System.Drawing.Size(175, 64);
            this.btnBackSForm.TabIndex = 3;
            this.btnBackSForm.Text = "Backspace";
            this.btnBackSForm.UseVisualStyleBackColor = true;
            this.btnBackSForm.Click += new System.EventHandler(this.btnBackSForm_Click);
            // 
            // btnCEForm
            // 
            this.btnCEForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCEForm.ForeColor = System.Drawing.Color.Red;
            this.btnCEForm.Location = new System.Drawing.Point(294, 116);
            this.btnCEForm.Name = "btnCEForm";
            this.btnCEForm.Size = new System.Drawing.Size(131, 64);
            this.btnCEForm.TabIndex = 4;
            this.btnCEForm.Text = "CE";
            this.btnCEForm.UseVisualStyleBackColor = true;
            this.btnCEForm.Click += new System.EventHandler(this.btnCEForm_Click);
            // 
            // btnCForm
            // 
            this.btnCForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCForm.ForeColor = System.Drawing.Color.Red;
            this.btnCForm.Location = new System.Drawing.Point(445, 116);
            this.btnCForm.Name = "btnCForm";
            this.btnCForm.Size = new System.Drawing.Size(131, 64);
            this.btnCForm.TabIndex = 5;
            this.btnCForm.Text = "C";
            this.btnCForm.UseVisualStyleBackColor = true;
            this.btnCForm.Click += new System.EventHandler(this.btnCForm_Click);
            // 
            // btnMPlusForm
            // 
            this.btnMPlusForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMPlusForm.ForeColor = System.Drawing.Color.Red;
            this.btnMPlusForm.Location = new System.Drawing.Point(12, 487);
            this.btnMPlusForm.Name = "btnMPlusForm";
            this.btnMPlusForm.Size = new System.Drawing.Size(65, 64);
            this.btnMPlusForm.TabIndex = 6;
            this.btnMPlusForm.Text = "M+";
            this.btnMPlusForm.UseVisualStyleBackColor = true;
            this.btnMPlusForm.Click += new System.EventHandler(this.btnMPlusForm_Click);
            // 
            // btnMSForm
            // 
            this.btnMSForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMSForm.ForeColor = System.Drawing.Color.Red;
            this.btnMSForm.Location = new System.Drawing.Point(12, 389);
            this.btnMSForm.Name = "btnMSForm";
            this.btnMSForm.Size = new System.Drawing.Size(65, 64);
            this.btnMSForm.TabIndex = 7;
            this.btnMSForm.Text = "MS";
            this.btnMSForm.UseVisualStyleBackColor = true;
            this.btnMSForm.Click += new System.EventHandler(this.btnMSForm_Click);
            // 
            // btnMRForm
            // 
            this.btnMRForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMRForm.ForeColor = System.Drawing.Color.Red;
            this.btnMRForm.Location = new System.Drawing.Point(12, 293);
            this.btnMRForm.Name = "btnMRForm";
            this.btnMRForm.Size = new System.Drawing.Size(65, 64);
            this.btnMRForm.TabIndex = 8;
            this.btnMRForm.Text = "MR";
            this.btnMRForm.UseVisualStyleBackColor = true;
            this.btnMRForm.Click += new System.EventHandler(this.btnMRForm_Click);
            // 
            // btnMCForm
            // 
            this.btnMCForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCForm.ForeColor = System.Drawing.Color.Red;
            this.btnMCForm.Location = new System.Drawing.Point(12, 202);
            this.btnMCForm.Name = "btnMCForm";
            this.btnMCForm.Size = new System.Drawing.Size(65, 64);
            this.btnMCForm.TabIndex = 9;
            this.btnMCForm.Text = "MC";
            this.btnMCForm.UseVisualStyleBackColor = true;
            this.btnMCForm.Click += new System.EventHandler(this.btnMCForm_Click);
            // 
            // btn0Form
            // 
            this.btn0Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0Form.ForeColor = System.Drawing.Color.Blue;
            this.btn0Form.Location = new System.Drawing.Point(102, 487);
            this.btn0Form.Name = "btn0Form";
            this.btn0Form.Size = new System.Drawing.Size(82, 64);
            this.btn0Form.TabIndex = 11;
            this.btn0Form.Text = "0";
            this.btn0Form.UseVisualStyleBackColor = true;
            this.btn0Form.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn1Form
            // 
            this.btn1Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Form.ForeColor = System.Drawing.Color.Blue;
            this.btn1Form.Location = new System.Drawing.Point(102, 389);
            this.btn1Form.Name = "btn1Form";
            this.btn1Form.Size = new System.Drawing.Size(82, 64);
            this.btn1Form.TabIndex = 12;
            this.btn1Form.Text = "1";
            this.btn1Form.UseVisualStyleBackColor = true;
            this.btn1Form.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn4Form
            // 
            this.btn4Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Form.ForeColor = System.Drawing.Color.Blue;
            this.btn4Form.Location = new System.Drawing.Point(102, 293);
            this.btn4Form.Name = "btn4Form";
            this.btn4Form.Size = new System.Drawing.Size(82, 64);
            this.btn4Form.TabIndex = 13;
            this.btn4Form.Text = "4";
            this.btn4Form.UseVisualStyleBackColor = true;
            this.btn4Form.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn7Form
            // 
            this.btn7Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7Form.ForeColor = System.Drawing.Color.Blue;
            this.btn7Form.Location = new System.Drawing.Point(102, 202);
            this.btn7Form.Name = "btn7Form";
            this.btn7Form.Size = new System.Drawing.Size(82, 64);
            this.btn7Form.TabIndex = 14;
            this.btn7Form.Text = "7";
            this.btn7Form.UseVisualStyleBackColor = true;
            this.btn7Form.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnDivideForm
            // 
            this.btnDivideForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivideForm.ForeColor = System.Drawing.Color.Red;
            this.btnDivideForm.Location = new System.Drawing.Point(396, 202);
            this.btnDivideForm.Name = "btnDivideForm";
            this.btnDivideForm.Size = new System.Drawing.Size(82, 64);
            this.btnDivideForm.TabIndex = 15;
            this.btnDivideForm.Text = "/";
            this.btnDivideForm.UseVisualStyleBackColor = true;
            this.btnDivideForm.Click += new System.EventHandler(this.Opearand_Click);
            // 
            // btn9Form
            // 
            this.btn9Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9Form.ForeColor = System.Drawing.Color.Blue;
            this.btn9Form.Location = new System.Drawing.Point(294, 202);
            this.btn9Form.Name = "btn9Form";
            this.btn9Form.Size = new System.Drawing.Size(82, 64);
            this.btn9Form.TabIndex = 16;
            this.btn9Form.Text = "9";
            this.btn9Form.UseVisualStyleBackColor = true;
            this.btn9Form.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn8Form
            // 
            this.btn8Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8Form.ForeColor = System.Drawing.Color.Blue;
            this.btn8Form.Location = new System.Drawing.Point(195, 202);
            this.btn8Form.Name = "btn8Form";
            this.btn8Form.Size = new System.Drawing.Size(82, 64);
            this.btn8Form.TabIndex = 17;
            this.btn8Form.Text = "8";
            this.btn8Form.UseVisualStyleBackColor = true;
            this.btn8Form.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnSqrtForm
            // 
            this.btnSqrtForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrtForm.ForeColor = System.Drawing.Color.Blue;
            this.btnSqrtForm.Location = new System.Drawing.Point(494, 202);
            this.btnSqrtForm.Name = "btnSqrtForm";
            this.btnSqrtForm.Size = new System.Drawing.Size(82, 64);
            this.btnSqrtForm.TabIndex = 18;
            this.btnSqrtForm.Text = "Sqrt";
            this.btnSqrtForm.UseVisualStyleBackColor = true;
            this.btnSqrtForm.Click += new System.EventHandler(this.btnSqrtForm_Click);
            // 
            // btnPerForm
            // 
            this.btnPerForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerForm.ForeColor = System.Drawing.Color.Blue;
            this.btnPerForm.Location = new System.Drawing.Point(494, 293);
            this.btnPerForm.Name = "btnPerForm";
            this.btnPerForm.Size = new System.Drawing.Size(82, 64);
            this.btnPerForm.TabIndex = 22;
            this.btnPerForm.Text = "%";
            this.btnPerForm.UseVisualStyleBackColor = true;
            this.btnPerForm.Click += new System.EventHandler(this.btnPerForm_Click);
            // 
            // btn5Form
            // 
            this.btn5Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Form.ForeColor = System.Drawing.Color.Blue;
            this.btn5Form.Location = new System.Drawing.Point(195, 293);
            this.btn5Form.Name = "btn5Form";
            this.btn5Form.Size = new System.Drawing.Size(82, 64);
            this.btn5Form.TabIndex = 21;
            this.btn5Form.Text = "5";
            this.btn5Form.UseVisualStyleBackColor = true;
            this.btn5Form.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn6Form
            // 
            this.btn6Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6Form.ForeColor = System.Drawing.Color.Blue;
            this.btn6Form.Location = new System.Drawing.Point(294, 293);
            this.btn6Form.Name = "btn6Form";
            this.btn6Form.Size = new System.Drawing.Size(82, 64);
            this.btn6Form.TabIndex = 20;
            this.btn6Form.Text = "6";
            this.btn6Form.UseVisualStyleBackColor = true;
            this.btn6Form.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnMulForm
            // 
            this.btnMulForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulForm.ForeColor = System.Drawing.Color.Red;
            this.btnMulForm.Location = new System.Drawing.Point(396, 293);
            this.btnMulForm.Name = "btnMulForm";
            this.btnMulForm.Size = new System.Drawing.Size(82, 64);
            this.btnMulForm.TabIndex = 19;
            this.btnMulForm.Text = "x";
            this.btnMulForm.UseVisualStyleBackColor = true;
            this.btnMulForm.Click += new System.EventHandler(this.Opearand_Click);
            // 
            // btnPhanSoForm
            // 
            this.btnPhanSoForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanSoForm.ForeColor = System.Drawing.Color.Blue;
            this.btnPhanSoForm.Location = new System.Drawing.Point(494, 389);
            this.btnPhanSoForm.Name = "btnPhanSoForm";
            this.btnPhanSoForm.Size = new System.Drawing.Size(82, 64);
            this.btnPhanSoForm.TabIndex = 26;
            this.btnPhanSoForm.Text = "1/x";
            this.btnPhanSoForm.UseVisualStyleBackColor = true;
            this.btnPhanSoForm.Click += new System.EventHandler(this.btnPhanSoForm_Click);
            // 
            // btn2Form
            // 
            this.btn2Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Form.ForeColor = System.Drawing.Color.Blue;
            this.btn2Form.Location = new System.Drawing.Point(195, 389);
            this.btn2Form.Name = "btn2Form";
            this.btn2Form.Size = new System.Drawing.Size(82, 64);
            this.btn2Form.TabIndex = 25;
            this.btn2Form.Text = "2";
            this.btn2Form.UseVisualStyleBackColor = true;
            this.btn2Form.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn3Form
            // 
            this.btn3Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Form.ForeColor = System.Drawing.Color.Blue;
            this.btn3Form.Location = new System.Drawing.Point(294, 389);
            this.btn3Form.Name = "btn3Form";
            this.btn3Form.Size = new System.Drawing.Size(82, 64);
            this.btn3Form.TabIndex = 24;
            this.btn3Form.Text = "3";
            this.btn3Form.UseVisualStyleBackColor = true;
            this.btn3Form.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnMinusForm
            // 
            this.btnMinusForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusForm.ForeColor = System.Drawing.Color.Red;
            this.btnMinusForm.Location = new System.Drawing.Point(396, 389);
            this.btnMinusForm.Name = "btnMinusForm";
            this.btnMinusForm.Size = new System.Drawing.Size(82, 64);
            this.btnMinusForm.TabIndex = 23;
            this.btnMinusForm.Text = "-";
            this.btnMinusForm.UseVisualStyleBackColor = true;
            this.btnMinusForm.Click += new System.EventHandler(this.Opearand_Click);
            // 
            // btnEqualForm
            // 
            this.btnEqualForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqualForm.ForeColor = System.Drawing.Color.Red;
            this.btnEqualForm.Location = new System.Drawing.Point(494, 487);
            this.btnEqualForm.Name = "btnEqualForm";
            this.btnEqualForm.Size = new System.Drawing.Size(82, 64);
            this.btnEqualForm.TabIndex = 30;
            this.btnEqualForm.Text = "=";
            this.btnEqualForm.UseVisualStyleBackColor = true;
            this.btnEqualForm.Click += new System.EventHandler(this.btnEqualForm_Click);
            // 
            // btnOptForm
            // 
            this.btnOptForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptForm.ForeColor = System.Drawing.Color.Blue;
            this.btnOptForm.Location = new System.Drawing.Point(195, 487);
            this.btnOptForm.Name = "btnOptForm";
            this.btnOptForm.Size = new System.Drawing.Size(82, 64);
            this.btnOptForm.TabIndex = 29;
            this.btnOptForm.Text = "+/-";
            this.btnOptForm.UseVisualStyleBackColor = true;
            this.btnOptForm.Click += new System.EventHandler(this.btnOptForm_Click);
            // 
            // btnColForm
            // 
            this.btnColForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColForm.ForeColor = System.Drawing.Color.Blue;
            this.btnColForm.Location = new System.Drawing.Point(294, 487);
            this.btnColForm.Name = "btnColForm";
            this.btnColForm.Size = new System.Drawing.Size(82, 64);
            this.btnColForm.TabIndex = 28;
            this.btnColForm.Text = ",";
            this.btnColForm.UseVisualStyleBackColor = true;
            this.btnColForm.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // bntPlusForm
            // 
            this.bntPlusForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPlusForm.ForeColor = System.Drawing.Color.Red;
            this.bntPlusForm.Location = new System.Drawing.Point(396, 487);
            this.bntPlusForm.Name = "bntPlusForm";
            this.bntPlusForm.Size = new System.Drawing.Size(82, 64);
            this.bntPlusForm.TabIndex = 27;
            this.bntPlusForm.Text = "+";
            this.bntPlusForm.UseVisualStyleBackColor = true;
            this.bntPlusForm.Click += new System.EventHandler(this.Opearand_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 588);
            this.Controls.Add(this.btnEqualForm);
            this.Controls.Add(this.btnOptForm);
            this.Controls.Add(this.btnColForm);
            this.Controls.Add(this.bntPlusForm);
            this.Controls.Add(this.btnPhanSoForm);
            this.Controls.Add(this.btn2Form);
            this.Controls.Add(this.btn3Form);
            this.Controls.Add(this.btnMinusForm);
            this.Controls.Add(this.btnPerForm);
            this.Controls.Add(this.btn5Form);
            this.Controls.Add(this.btn6Form);
            this.Controls.Add(this.btnMulForm);
            this.Controls.Add(this.btnSqrtForm);
            this.Controls.Add(this.btn8Form);
            this.Controls.Add(this.btn9Form);
            this.Controls.Add(this.btnDivideForm);
            this.Controls.Add(this.btn7Form);
            this.Controls.Add(this.btn4Form);
            this.Controls.Add(this.btn1Form);
            this.Controls.Add(this.btn0Form);
            this.Controls.Add(this.btnMCForm);
            this.Controls.Add(this.btnMRForm);
            this.Controls.Add(this.btnMSForm);
            this.Controls.Add(this.btnMPlusForm);
            this.Controls.Add(this.btnCForm);
            this.Controls.Add(this.btnCEForm);
            this.Controls.Add(this.btnBackSForm);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txbAnswerForm);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox txbAnswerForm;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnBackSForm;
        private System.Windows.Forms.Button btnCEForm;
        private System.Windows.Forms.Button btnCForm;
        private System.Windows.Forms.Button btnMPlusForm;
        private System.Windows.Forms.Button btnMSForm;
        private System.Windows.Forms.Button btnMRForm;
        private System.Windows.Forms.Button btnMCForm;
        private System.Windows.Forms.Button btn0Form;
        private System.Windows.Forms.Button btn1Form;
        private System.Windows.Forms.Button btn4Form;
        private System.Windows.Forms.Button btn7Form;
        private System.Windows.Forms.Button btnDivideForm;
        private System.Windows.Forms.Button btn9Form;
        private System.Windows.Forms.Button btn8Form;
        private System.Windows.Forms.Button btnSqrtForm;
        private System.Windows.Forms.Button btnPerForm;
        private System.Windows.Forms.Button btn5Form;
        private System.Windows.Forms.Button btn6Form;
        private System.Windows.Forms.Button btnMulForm;
        private System.Windows.Forms.Button btnPhanSoForm;
        private System.Windows.Forms.Button btn2Form;
        private System.Windows.Forms.Button btn3Form;
        private System.Windows.Forms.Button btnMinusForm;
        private System.Windows.Forms.Button btnEqualForm;
        private System.Windows.Forms.Button btnOptForm;
        private System.Windows.Forms.Button btnColForm;
        private System.Windows.Forms.Button bntPlusForm;
    }
}

