namespace Bai05
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
            this.components = new System.ComponentModel.Container();
            this.lbNumber1Form1 = new System.Windows.Forms.Label();
            this.lbNumber2Form1 = new System.Windows.Forms.Label();
            this.txbNumber1Form1 = new System.Windows.Forms.TextBox();
            this.txbNumber2Form1 = new System.Windows.Forms.TextBox();
            this.btnPlusForm1 = new System.Windows.Forms.Button();
            this.btnMinusForm1 = new System.Windows.Forms.Button();
            this.btnMulForm1 = new System.Windows.Forms.Button();
            this.btnDivideForm1 = new System.Windows.Forms.Button();
            this.lbAnswerForm1 = new System.Windows.Forms.Label();
            this.txbAnswerForm1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNumber1Form1
            // 
            this.lbNumber1Form1.AutoSize = true;
            this.lbNumber1Form1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber1Form1.Location = new System.Drawing.Point(96, 54);
            this.lbNumber1Form1.Name = "lbNumber1Form1";
            this.lbNumber1Form1.Size = new System.Drawing.Size(120, 29);
            this.lbNumber1Form1.TabIndex = 0;
            this.lbNumber1Form1.Text = "Number 1:";
            // 
            // lbNumber2Form1
            // 
            this.lbNumber2Form1.AutoSize = true;
            this.lbNumber2Form1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber2Form1.Location = new System.Drawing.Point(96, 158);
            this.lbNumber2Form1.Name = "lbNumber2Form1";
            this.lbNumber2Form1.Size = new System.Drawing.Size(120, 29);
            this.lbNumber2Form1.TabIndex = 1;
            this.lbNumber2Form1.Text = "Number 2:";
            // 
            // txbNumber1Form1
            // 
            this.txbNumber1Form1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumber1Form1.Location = new System.Drawing.Point(254, 61);
            this.txbNumber1Form1.Name = "txbNumber1Form1";
            this.txbNumber1Form1.Size = new System.Drawing.Size(318, 30);
            this.txbNumber1Form1.TabIndex = 2;
            this.txbNumber1Form1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumber1Form1_KeyPress);
            this.txbNumber1Form1.Leave += new System.EventHandler(this.txbNumber1Form1_Leave);
            // 
            // txbNumber2Form1
            // 
            this.txbNumber2Form1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumber2Form1.Location = new System.Drawing.Point(254, 161);
            this.txbNumber2Form1.Name = "txbNumber2Form1";
            this.txbNumber2Form1.Size = new System.Drawing.Size(318, 30);
            this.txbNumber2Form1.TabIndex = 3;
            this.txbNumber2Form1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumber2Form1_KeyPress);
            this.txbNumber2Form1.Leave += new System.EventHandler(this.txbNumber2Form1_Leave);
            // 
            // btnPlusForm1
            // 
            this.btnPlusForm1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPlusForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusForm1.Location = new System.Drawing.Point(131, 240);
            this.btnPlusForm1.Name = "btnPlusForm1";
            this.btnPlusForm1.Size = new System.Drawing.Size(58, 54);
            this.btnPlusForm1.TabIndex = 4;
            this.btnPlusForm1.Text = "+";
            this.btnPlusForm1.UseVisualStyleBackColor = false;
            this.btnPlusForm1.Click += new System.EventHandler(this.btnPlusForm1_Click);
            // 
            // btnMinusForm1
            // 
            this.btnMinusForm1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMinusForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusForm1.Location = new System.Drawing.Point(254, 240);
            this.btnMinusForm1.Name = "btnMinusForm1";
            this.btnMinusForm1.Size = new System.Drawing.Size(58, 54);
            this.btnMinusForm1.TabIndex = 5;
            this.btnMinusForm1.Text = "-";
            this.btnMinusForm1.UseVisualStyleBackColor = false;
            this.btnMinusForm1.Click += new System.EventHandler(this.btnMinusForm1_Click);
            // 
            // btnMulForm1
            // 
            this.btnMulForm1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMulForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulForm1.Location = new System.Drawing.Point(395, 240);
            this.btnMulForm1.Name = "btnMulForm1";
            this.btnMulForm1.Size = new System.Drawing.Size(58, 54);
            this.btnMulForm1.TabIndex = 6;
            this.btnMulForm1.Text = "x";
            this.btnMulForm1.UseVisualStyleBackColor = false;
            this.btnMulForm1.Click += new System.EventHandler(this.btnMulForm1_Click);
            // 
            // btnDivideForm1
            // 
            this.btnDivideForm1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDivideForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivideForm1.Location = new System.Drawing.Point(531, 240);
            this.btnDivideForm1.Name = "btnDivideForm1";
            this.btnDivideForm1.Size = new System.Drawing.Size(58, 54);
            this.btnDivideForm1.TabIndex = 7;
            this.btnDivideForm1.Text = "/";
            this.btnDivideForm1.UseVisualStyleBackColor = false;
            this.btnDivideForm1.Click += new System.EventHandler(this.btnDivideForm1_Click);
            // 
            // lbAnswerForm1
            // 
            this.lbAnswerForm1.AutoSize = true;
            this.lbAnswerForm1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswerForm1.Location = new System.Drawing.Point(96, 353);
            this.lbAnswerForm1.Name = "lbAnswerForm1";
            this.lbAnswerForm1.Size = new System.Drawing.Size(97, 29);
            this.lbAnswerForm1.TabIndex = 8;
            this.lbAnswerForm1.Text = "Answer:";
            // 
            // txbAnswerForm1
            // 
            this.txbAnswerForm1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAnswerForm1.Location = new System.Drawing.Point(254, 352);
            this.txbAnswerForm1.Name = "txbAnswerForm1";
            this.txbAnswerForm1.ReadOnly = true;
            this.txbAnswerForm1.Size = new System.Drawing.Size(318, 30);
            this.txbAnswerForm1.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbAnswerForm1);
            this.Controls.Add(this.lbAnswerForm1);
            this.Controls.Add(this.btnDivideForm1);
            this.Controls.Add(this.btnMulForm1);
            this.Controls.Add(this.btnMinusForm1);
            this.Controls.Add(this.btnPlusForm1);
            this.Controls.Add(this.txbNumber2Form1);
            this.Controls.Add(this.txbNumber1Form1);
            this.Controls.Add(this.lbNumber2Form1);
            this.Controls.Add(this.lbNumber1Form1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab02_Example";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumber1Form1;
        private System.Windows.Forms.Label lbNumber2Form1;
        private System.Windows.Forms.TextBox txbNumber1Form1;
        private System.Windows.Forms.TextBox txbNumber2Form1;
        private System.Windows.Forms.Button btnPlusForm1;
        private System.Windows.Forms.Button btnMinusForm1;
        private System.Windows.Forms.Button btnMulForm1;
        private System.Windows.Forms.Button btnDivideForm1;
        private System.Windows.Forms.Label lbAnswerForm1;
        private System.Windows.Forms.TextBox txbAnswerForm1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

