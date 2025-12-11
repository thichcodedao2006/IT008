namespace Bai01
{
    partial class MouseAndKeyForm
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
            this.flpText = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpText
            // 
            this.flpText.AutoScroll = true;
            this.flpText.AutoSize = true;
            this.flpText.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpText.Location = new System.Drawing.Point(12, 12);
            this.flpText.Name = "flpText";
            this.flpText.Size = new System.Drawing.Size(776, 426);
            this.flpText.TabIndex = 0;
            // 
            // MouseAndKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpText);
            this.Name = "MouseAndKeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse and Keyboard";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MouseAndKeyForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MouseAndKeyForm_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseAndKeyForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpText;
    }
}

