namespace Bai02
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
            this.btnDrawForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDrawForm1
            // 
            this.btnDrawForm1.BackColor = System.Drawing.Color.IndianRed;
            this.btnDrawForm1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawForm1.Location = new System.Drawing.Point(332, 189);
            this.btnDrawForm1.Name = "btnDrawForm1";
            this.btnDrawForm1.Size = new System.Drawing.Size(162, 54);
            this.btnDrawForm1.TabIndex = 0;
            this.btnDrawForm1.Text = "Sự kiện vẽ";
            this.btnDrawForm1.UseVisualStyleBackColor = false;
            this.btnDrawForm1.Click += new System.EventHandler(this.btnDrawForm1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDrawForm1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử lý sự kiện Paint";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrawForm1;
    }
}

