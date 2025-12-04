namespace Bai05
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbMSSV = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMajor = new System.Windows.Forms.ComboBox();
            this.txbDTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số Sinh Viên";
            // 
            // txbMSSV
            // 
            this.txbMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMSSV.Location = new System.Drawing.Point(264, 63);
            this.txbMSSV.Name = "txbMSSV";
            this.txbMSSV.Size = new System.Drawing.Size(265, 30);
            this.txbMSSV.TabIndex = 1;
            this.txbMSSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMSSV_KeyPress);
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(264, 127);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(395, 30);
            this.txbName.TabIndex = 3;
            this.txbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khoa";
            // 
            // cbbMajor
            // 
            this.cbbMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMajor.FormattingEnabled = true;
            this.cbbMajor.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Công nghệ phần mềm",
            "Khoa học máy tính",
            "Kĩ thuật máy tính",
            "Hệ thống thông tin",
            "Trí tuệ nhân tạo",
            "Thương mại điện tử"});
            this.cbbMajor.Location = new System.Drawing.Point(264, 196);
            this.cbbMajor.Name = "cbbMajor";
            this.cbbMajor.Size = new System.Drawing.Size(265, 33);
            this.cbbMajor.TabIndex = 5;
            // 
            // txbDTB
            // 
            this.txbDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDTB.Location = new System.Drawing.Point(264, 259);
            this.txbDTB.Name = "txbDTB";
            this.txbDTB.Size = new System.Drawing.Size(139, 30);
            this.txbDTB.TabIndex = 7;
            this.txbDTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDTB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Điểm TB";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(417, 357);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(99, 34);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Thêm mới";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(560, 357);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(99, 34);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 432);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.txbDTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbMajor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbMSSV);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sinh Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMSSV;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMajor;
        private System.Windows.Forms.TextBox txbDTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ExitButton;
    }
}