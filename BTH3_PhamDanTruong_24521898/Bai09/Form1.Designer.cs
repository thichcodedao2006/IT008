namespace Bai09
{
    partial class SinhVienForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Cơ sở dữ liệu");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Hệ điều hành");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Toán rời rạc");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Xác suất thống kê");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Nhập môn mạng máy tính");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Lập trình trực quan");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Cấu trúc dữ liệu và giải thuật");
            this.gbInfoManage = new System.Windows.Forms.GroupBox();
            this.btnDeleteSub = new System.Windows.Forms.Button();
            this.btnChooseSub = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbbMajor = new System.Windows.Forms.ComboBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lvCurChoose = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvChoose = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbChooseSub = new System.Windows.Forms.Label();
            this.cbFemale = new System.Windows.Forms.CheckBox();
            this.cbMale = new System.Windows.Forms.CheckBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbMajor = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lvShow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbInfoManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfoManage
            // 
            this.gbInfoManage.Controls.Add(this.btnDeleteSub);
            this.gbInfoManage.Controls.Add(this.btnChooseSub);
            this.gbInfoManage.Controls.Add(this.btnDelete);
            this.gbInfoManage.Controls.Add(this.btnSave);
            this.gbInfoManage.Controls.Add(this.cbbMajor);
            this.gbInfoManage.Controls.Add(this.txbName);
            this.gbInfoManage.Controls.Add(this.txbID);
            this.gbInfoManage.Controls.Add(this.lvCurChoose);
            this.gbInfoManage.Controls.Add(this.lvChoose);
            this.gbInfoManage.Controls.Add(this.lbChooseSub);
            this.gbInfoManage.Controls.Add(this.cbFemale);
            this.gbInfoManage.Controls.Add(this.cbMale);
            this.gbInfoManage.Controls.Add(this.lbGender);
            this.gbInfoManage.Controls.Add(this.lbMajor);
            this.gbInfoManage.Controls.Add(this.lbName);
            this.gbInfoManage.Controls.Add(this.lbID);
            this.gbInfoManage.Location = new System.Drawing.Point(12, 25);
            this.gbInfoManage.Name = "gbInfoManage";
            this.gbInfoManage.Size = new System.Drawing.Size(872, 422);
            this.gbInfoManage.TabIndex = 0;
            this.gbInfoManage.TabStop = false;
            this.gbInfoManage.Text = "Thông tin sinh viên";
            // 
            // btnDeleteSub
            // 
            this.btnDeleteSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSub.Location = new System.Drawing.Point(486, 299);
            this.btnDeleteSub.Name = "btnDeleteSub";
            this.btnDeleteSub.Size = new System.Drawing.Size(75, 40);
            this.btnDeleteSub.TabIndex = 15;
            this.btnDeleteSub.Text = "<";
            this.btnDeleteSub.UseVisualStyleBackColor = true;
            this.btnDeleteSub.Click += new System.EventHandler(this.btnDeleteSub_Click);
            // 
            // btnChooseSub
            // 
            this.btnChooseSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseSub.Location = new System.Drawing.Point(486, 242);
            this.btnChooseSub.Name = "btnChooseSub";
            this.btnChooseSub.Size = new System.Drawing.Size(75, 40);
            this.btnChooseSub.TabIndex = 14;
            this.btnChooseSub.Text = ">";
            this.btnChooseSub.UseVisualStyleBackColor = true;
            this.btnChooseSub.Click += new System.EventHandler(this.btnChooseSub_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(552, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 26);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa chọn";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.Location = new System.Drawing.Point(351, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 26);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbbMajor
            // 
            this.cbbMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMajor.FormattingEnabled = true;
            this.cbbMajor.Items.AddRange(new object[] {
            "Hệ thống thông tin",
            "Kĩ thuật phần mềm",
            "Công nghệ thông tin",
            "Kĩ thuật máy tính",
            "Khoa học máy tính ",
            "Trí tuệ nhân tạo ",
            "Thương mại điện tử"});
            this.cbbMajor.Location = new System.Drawing.Point(351, 95);
            this.cbbMajor.Name = "cbbMajor";
            this.cbbMajor.Size = new System.Drawing.Size(284, 24);
            this.cbbMajor.TabIndex = 11;
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(350, 49);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(285, 27);
            this.txbName.TabIndex = 10;
            this.txbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbName_KeyPress);
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(350, 11);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(285, 27);
            this.txbID.TabIndex = 9;
            this.txbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            // 
            // lvCurChoose
            // 
            this.lvCurChoose.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8});
            this.lvCurChoose.FullRowSelect = true;
            this.lvCurChoose.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvCurChoose.HideSelection = false;
            this.lvCurChoose.Location = new System.Drawing.Point(580, 242);
            this.lvCurChoose.Name = "lvCurChoose";
            this.lvCurChoose.Size = new System.Drawing.Size(240, 142);
            this.lvCurChoose.TabIndex = 8;
            this.lvCurChoose.UseCompatibleStateImageBehavior = false;
            this.lvCurChoose.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Width = 200;
            // 
            // lvChoose
            // 
            this.lvChoose.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.lvChoose.FullRowSelect = true;
            this.lvChoose.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvChoose.HideSelection = false;
            this.lvChoose.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.lvChoose.Location = new System.Drawing.Point(225, 242);
            this.lvChoose.Name = "lvChoose";
            this.lvChoose.Size = new System.Drawing.Size(240, 142);
            this.lvChoose.TabIndex = 7;
            this.lvChoose.UseCompatibleStateImageBehavior = false;
            this.lvChoose.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Width = 174;
            // 
            // lbChooseSub
            // 
            this.lbChooseSub.AutoSize = true;
            this.lbChooseSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChooseSub.Location = new System.Drawing.Point(221, 196);
            this.lbChooseSub.Name = "lbChooseSub";
            this.lbChooseSub.Size = new System.Drawing.Size(234, 20);
            this.lbChooseSub.TabIndex = 6;
            this.lbChooseSub.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.Location = new System.Drawing.Point(504, 148);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(46, 20);
            this.cbFemale.TabIndex = 5;
            this.cbFemale.Text = "Nữ";
            this.cbFemale.UseVisualStyleBackColor = true;
            this.cbFemale.CheckedChanged += new System.EventHandler(this.cbFemale_CheckedChanged);
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.Location = new System.Drawing.Point(379, 149);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(58, 20);
            this.cbMale.TabIndex = 4;
            this.cbMale.Text = "Nam";
            this.cbMale.UseVisualStyleBackColor = true;
            this.cbMale.CheckedChanged += new System.EventHandler(this.cbMale_CheckedChanged);
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(221, 149);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(81, 20);
            this.lbGender.TabIndex = 3;
            this.lbGender.Text = "Giới Tính:";
            // 
            // lbMajor
            // 
            this.lbMajor.AutoSize = true;
            this.lbMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMajor.Location = new System.Drawing.Point(221, 100);
            this.lbMajor.Name = "lbMajor";
            this.lbMajor.Size = new System.Drawing.Size(123, 20);
            this.lbMajor.TabIndex = 2;
            this.lbMajor.Text = "Chuyên Ngành:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(221, 56);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(69, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Họ Tên:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(221, 18);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(113, 20);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã Sinh Viên:";
            // 
            // lvShow
            // 
            this.lvShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvShow.FullRowSelect = true;
            this.lvShow.HideSelection = false;
            this.lvShow.Location = new System.Drawing.Point(12, 487);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(871, 266);
            this.lvShow.TabIndex = 1;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.View = System.Windows.Forms.View.Details;
            this.lvShow.SelectedIndexChanged += new System.EventHandler(this.lvShow_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MSSV";
            this.columnHeader2.Width = 198;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Họ Tên";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Chuyên Ngành";
            this.columnHeader4.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giới Tính";
            this.columnHeader5.Width = 122;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số Môn";
            // 
            // SinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 765);
            this.Controls.Add(this.lvShow);
            this.Controls.Add(this.gbInfoManage);
            this.Name = "SinhVienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập liệu sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SinhVienForm_FormClosing);
            this.gbInfoManage.ResumeLayout(false);
            this.gbInfoManage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoManage;
        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.Label lbMajor;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ListView lvChoose;
        private System.Windows.Forms.Label lbChooseSub;
        private System.Windows.Forms.CheckBox cbFemale;
        private System.Windows.Forms.CheckBox cbMale;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.ComboBox cbbMajor;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.ListView lvCurChoose;
        private System.Windows.Forms.Button btnDeleteSub;
        private System.Windows.Forms.Button btnChooseSub;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}

