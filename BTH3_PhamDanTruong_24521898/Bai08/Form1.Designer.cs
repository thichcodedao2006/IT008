namespace Bai08
{
    partial class ManageForm
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
            this.lbMangeTitleForm = new System.Windows.Forms.Label();
            this.lbSTKForm = new System.Windows.Forms.Label();
            this.txbSTKForm = new System.Windows.Forms.TextBox();
            this.lbNameCuSForm = new System.Windows.Forms.Label();
            this.txbNameCusForm = new System.Windows.Forms.TextBox();
            this.lbAddressForm = new System.Windows.Forms.Label();
            this.txbAddressForm = new System.Windows.Forms.TextBox();
            this.lbMoneyAccountForm = new System.Windows.Forms.Label();
            this.txbMoneyAccountForm = new System.Windows.Forms.TextBox();
            this.btnAddForm = new System.Windows.Forms.Button();
            this.btnEraseForm = new System.Windows.Forms.Button();
            this.btnOutForm = new System.Windows.Forms.Button();
            this.lvShowForm = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTotalForm = new System.Windows.Forms.Label();
            this.txbTotalForm = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMangeTitleForm
            // 
            this.lbMangeTitleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMangeTitleForm.ForeColor = System.Drawing.Color.Blue;
            this.lbMangeTitleForm.Location = new System.Drawing.Point(12, 9);
            this.lbMangeTitleForm.Name = "lbMangeTitleForm";
            this.lbMangeTitleForm.Size = new System.Drawing.Size(776, 56);
            this.lbMangeTitleForm.TabIndex = 0;
            this.lbMangeTitleForm.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            this.lbMangeTitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSTKForm
            // 
            this.lbSTKForm.AutoSize = true;
            this.lbSTKForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSTKForm.Location = new System.Drawing.Point(89, 75);
            this.lbSTKForm.Name = "lbSTKForm";
            this.lbSTKForm.Size = new System.Drawing.Size(127, 25);
            this.lbSTKForm.TabIndex = 1;
            this.lbSTKForm.Text = "Số tài khoản:";
            this.lbSTKForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbSTKForm
            // 
            this.txbSTKForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSTKForm.Location = new System.Drawing.Point(240, 70);
            this.txbSTKForm.Name = "txbSTKForm";
            this.txbSTKForm.Size = new System.Drawing.Size(483, 30);
            this.txbSTKForm.TabIndex = 2;
            this.txbSTKForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSTKForm_KeyPress);
            this.txbSTKForm.Leave += new System.EventHandler(this.txbSTKForm_Leave);
            // 
            // lbNameCuSForm
            // 
            this.lbNameCuSForm.AutoSize = true;
            this.lbNameCuSForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameCuSForm.Location = new System.Drawing.Point(56, 139);
            this.lbNameCuSForm.Name = "lbNameCuSForm";
            this.lbNameCuSForm.Size = new System.Drawing.Size(160, 25);
            this.lbNameCuSForm.TabIndex = 3;
            this.lbNameCuSForm.Text = "Tên khách hàng:";
            this.lbNameCuSForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbNameCusForm
            // 
            this.txbNameCusForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameCusForm.Location = new System.Drawing.Point(240, 134);
            this.txbNameCusForm.Name = "txbNameCusForm";
            this.txbNameCusForm.Size = new System.Drawing.Size(483, 30);
            this.txbNameCusForm.TabIndex = 4;
            this.txbNameCusForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNameCusForm_KeyPress);
            this.txbNameCusForm.Leave += new System.EventHandler(this.txbNameCusForm_Leave);
            // 
            // lbAddressForm
            // 
            this.lbAddressForm.AutoSize = true;
            this.lbAddressForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddressForm.Location = new System.Drawing.Point(32, 203);
            this.lbAddressForm.Name = "lbAddressForm";
            this.lbAddressForm.Size = new System.Drawing.Size(184, 25);
            this.lbAddressForm.TabIndex = 5;
            this.lbAddressForm.Text = "Địa chỉ khách hàng:";
            this.lbAddressForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbAddressForm
            // 
            this.txbAddressForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddressForm.Location = new System.Drawing.Point(240, 198);
            this.txbAddressForm.Name = "txbAddressForm";
            this.txbAddressForm.Size = new System.Drawing.Size(483, 30);
            this.txbAddressForm.TabIndex = 6;
            this.txbAddressForm.Leave += new System.EventHandler(this.txbAddressForm_Leave);
            // 
            // lbMoneyAccountForm
            // 
            this.lbMoneyAccountForm.AutoSize = true;
            this.lbMoneyAccountForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyAccountForm.Location = new System.Drawing.Point(4, 271);
            this.lbMoneyAccountForm.Name = "lbMoneyAccountForm";
            this.lbMoneyAccountForm.Size = new System.Drawing.Size(212, 25);
            this.lbMoneyAccountForm.TabIndex = 7;
            this.lbMoneyAccountForm.Text = "Số tiền trong tài khoản:";
            this.lbMoneyAccountForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbMoneyAccountForm
            // 
            this.txbMoneyAccountForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMoneyAccountForm.Location = new System.Drawing.Point(240, 266);
            this.txbMoneyAccountForm.Name = "txbMoneyAccountForm";
            this.txbMoneyAccountForm.Size = new System.Drawing.Size(483, 30);
            this.txbMoneyAccountForm.TabIndex = 8;
            this.txbMoneyAccountForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMoneyAccountForm_KeyPress);
            this.txbMoneyAccountForm.Leave += new System.EventHandler(this.txbMoneyAccountForm_Leave);
            // 
            // btnAddForm
            // 
            this.btnAddForm.AutoSize = true;
            this.btnAddForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddForm.Location = new System.Drawing.Point(351, 312);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(112, 26);
            this.btnAddForm.TabIndex = 9;
            this.btnAddForm.Text = "Thêm/ Cập nhật";
            this.btnAddForm.UseVisualStyleBackColor = false;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // btnEraseForm
            // 
            this.btnEraseForm.AutoSize = true;
            this.btnEraseForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEraseForm.Location = new System.Drawing.Point(478, 312);
            this.btnEraseForm.Name = "btnEraseForm";
            this.btnEraseForm.Size = new System.Drawing.Size(112, 26);
            this.btnEraseForm.TabIndex = 10;
            this.btnEraseForm.Text = "Xóa";
            this.btnEraseForm.UseVisualStyleBackColor = false;
            this.btnEraseForm.Click += new System.EventHandler(this.btnEraseForm_Click);
            // 
            // btnOutForm
            // 
            this.btnOutForm.AutoSize = true;
            this.btnOutForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOutForm.Location = new System.Drawing.Point(611, 312);
            this.btnOutForm.Name = "btnOutForm";
            this.btnOutForm.Size = new System.Drawing.Size(112, 26);
            this.btnOutForm.TabIndex = 11;
            this.btnOutForm.Text = "Thoát";
            this.btnOutForm.UseVisualStyleBackColor = false;
            this.btnOutForm.Click += new System.EventHandler(this.btnOutForm_Click);
            // 
            // lvShowForm
            // 
            this.lvShowForm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvShowForm.FullRowSelect = true;
            this.lvShowForm.HideSelection = false;
            this.lvShowForm.Location = new System.Drawing.Point(37, 358);
            this.lvShowForm.Name = "lvShowForm";
            this.lvShowForm.Size = new System.Drawing.Size(686, 315);
            this.lvShowForm.TabIndex = 12;
            this.lvShowForm.UseCompatibleStateImageBehavior = false;
            this.lvShowForm.View = System.Windows.Forms.View.Details;
            this.lvShowForm.SelectedIndexChanged += new System.EventHandler(this.lvShowForm_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã tài khoản";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên khách hàng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số tiền";
            // 
            // lbTotalForm
            // 
            this.lbTotalForm.AutoSize = true;
            this.lbTotalForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalForm.Location = new System.Drawing.Point(396, 698);
            this.lbTotalForm.Name = "lbTotalForm";
            this.lbTotalForm.Size = new System.Drawing.Size(100, 25);
            this.lbTotalForm.TabIndex = 13;
            this.lbTotalForm.Text = "Tổng tiền:";
            // 
            // txbTotalForm
            // 
            this.txbTotalForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalForm.Location = new System.Drawing.Point(503, 693);
            this.txbTotalForm.Name = "txbTotalForm";
            this.txbTotalForm.ReadOnly = true;
            this.txbTotalForm.Size = new System.Drawing.Size(220, 30);
            this.txbTotalForm.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 751);
            this.Controls.Add(this.txbTotalForm);
            this.Controls.Add(this.lbTotalForm);
            this.Controls.Add(this.lvShowForm);
            this.Controls.Add(this.btnOutForm);
            this.Controls.Add(this.btnEraseForm);
            this.Controls.Add(this.btnAddForm);
            this.Controls.Add(this.txbMoneyAccountForm);
            this.Controls.Add(this.lbMoneyAccountForm);
            this.Controls.Add(this.txbAddressForm);
            this.Controls.Add(this.lbAddressForm);
            this.Controls.Add(this.txbNameCusForm);
            this.Controls.Add(this.lbNameCuSForm);
            this.Controls.Add(this.txbSTKForm);
            this.Controls.Add(this.lbSTKForm);
            this.Controls.Add(this.lbMangeTitleForm);
            this.Name = "ManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMangeTitleForm;
        private System.Windows.Forms.Label lbSTKForm;
        private System.Windows.Forms.TextBox txbSTKForm;
        private System.Windows.Forms.Label lbNameCuSForm;
        private System.Windows.Forms.TextBox txbNameCusForm;
        private System.Windows.Forms.Label lbAddressForm;
        private System.Windows.Forms.TextBox txbAddressForm;
        private System.Windows.Forms.Label lbMoneyAccountForm;
        private System.Windows.Forms.TextBox txbMoneyAccountForm;
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.Button btnEraseForm;
        private System.Windows.Forms.Button btnOutForm;
        private System.Windows.Forms.ListView lvShowForm;
        private System.Windows.Forms.Label lbTotalForm;
        private System.Windows.Forms.TextBox txbTotalForm;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}

