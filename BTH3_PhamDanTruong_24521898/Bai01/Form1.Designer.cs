namespace Bai01
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flpanelTextForm1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpenChildFormForm1 = new System.Windows.Forms.Button();
            this.btnCloseChildFormForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpanelTextForm1
            // 
            this.flpanelTextForm1.AllowDrop = true;
            this.flpanelTextForm1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpanelTextForm1.Location = new System.Drawing.Point(0, 0);
            this.flpanelTextForm1.Name = "flpanelTextForm1";
            this.flpanelTextForm1.Size = new System.Drawing.Size(319, 670);
            this.flpanelTextForm1.TabIndex = 3;
            // 
            // btnOpenChildFormForm1
            // 
            this.btnOpenChildFormForm1.Location = new System.Drawing.Point(583, 136);
            this.btnOpenChildFormForm1.Name = "btnOpenChildFormForm1";
            this.btnOpenChildFormForm1.Size = new System.Drawing.Size(138, 54);
            this.btnOpenChildFormForm1.TabIndex = 4;
            this.btnOpenChildFormForm1.Text = "Mở Form con";
            this.btnOpenChildFormForm1.UseVisualStyleBackColor = true;
            this.btnOpenChildFormForm1.Click += new System.EventHandler(this.btnOpenChildFormForm1_Click);
            // 
            // btnCloseChildFormForm1
            // 
            this.btnCloseChildFormForm1.Location = new System.Drawing.Point(583, 280);
            this.btnCloseChildFormForm1.Name = "btnCloseChildFormForm1";
            this.btnCloseChildFormForm1.Size = new System.Drawing.Size(138, 54);
            this.btnCloseChildFormForm1.TabIndex = 5;
            this.btnCloseChildFormForm1.Text = "Đóng Form con";
            this.btnCloseChildFormForm1.UseVisualStyleBackColor = true;
            this.btnCloseChildFormForm1.Click += new System.EventHandler(this.btnCloseChildFormForm1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 670);
            this.Controls.Add(this.btnCloseChildFormForm1);
            this.Controls.Add(this.btnOpenChildFormForm1);
            this.Controls.Add(this.flpanelTextForm1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vòng Đời của Form";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel flpanelTextForm1;
        private System.Windows.Forms.Button btnOpenChildFormForm1;
        private System.Windows.Forms.Button btnCloseChildFormForm1;
    }
}

