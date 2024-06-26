namespace QLTTNN
{
    partial class frmThemHocVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemHocVien));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.btoLop = new System.Windows.Forms.Button();
            this.dgvHocVienDangKy = new System.Windows.Forms.DataGridView();
            this.colTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btoXoa = new System.Windows.Forms.Button();
            this.btoThem = new System.Windows.Forms.Button();
            this.tboDiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboDiaChi = new System.Windows.Forms.TextBox();
            this.grbGioiTinh = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.chbGioiTinh = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboEmail = new System.Windows.Forms.TextBox();
            this.tboDienThoai = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tboTen = new System.Windows.Forms.TextBox();
            this.tboHo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.erpMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.btoLuu = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVienDangKy)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 716);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(916, 26);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 20);
            this.lblStatus.Text = "Thông báo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbbLop);
            this.groupBox3.Controls.Add(this.btoLop);
            this.groupBox3.Controls.Add(this.dgvHocVienDangKy);
            this.groupBox3.Controls.Add(this.btoXoa);
            this.groupBox3.Controls.Add(this.btoThem);
            this.groupBox3.Controls.Add(this.tboDiem);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(16, 254);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(884, 410);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "phân lớp";
            // 
            // cbbLop
            // 
            this.cbbLop.DisplayMember = "TenLop";
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(76, 33);
            this.cbbLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(173, 24);
            this.cbbLop.TabIndex = 32;
            this.cbbLop.ValueMember = "MaLop";
            this.cbbLop.SelectedIndexChanged += new System.EventHandler(this.cbbLop_SelectedIndexChanged);
            // 
            // btoLop
            // 
            this.btoLop.Location = new System.Drawing.Point(259, 30);
            this.btoLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btoLop.Name = "btoLop";
            this.btoLop.Size = new System.Drawing.Size(40, 31);
            this.btoLop.TabIndex = 1;
            this.btoLop.Text = "...";
            this.btoLop.UseVisualStyleBackColor = true;
            this.btoLop.Click += new System.EventHandler(this.btoLop_Click);
            // 
            // dgvHocVienDangKy
            // 
            this.dgvHocVienDangKy.AllowUserToAddRows = false;
            this.dgvHocVienDangKy.AllowUserToDeleteRows = false;
            this.dgvHocVienDangKy.AllowUserToResizeColumns = false;
            this.dgvHocVienDangKy.AllowUserToResizeRows = false;
            this.dgvHocVienDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocVienDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocVienDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenLop,
            this.colDiem});
            this.dgvHocVienDangKy.Location = new System.Drawing.Point(13, 80);
            this.dgvHocVienDangKy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHocVienDangKy.MultiSelect = false;
            this.dgvHocVienDangKy.Name = "dgvHocVienDangKy";
            this.dgvHocVienDangKy.ReadOnly = true;
            this.dgvHocVienDangKy.RowHeadersWidth = 62;
            this.dgvHocVienDangKy.RowTemplate.Height = 28;
            this.dgvHocVienDangKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocVienDangKy.Size = new System.Drawing.Size(855, 322);
            this.dgvHocVienDangKy.TabIndex = 7;
            // 
            // colTenLop
            // 
            this.colTenLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenLop.DataPropertyName = "TenLop";
            this.colTenLop.HeaderText = "Tên Lớp";
            this.colTenLop.MinimumWidth = 6;
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.ReadOnly = true;
            // 
            // colDiem
            // 
            this.colDiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiem.DataPropertyName = "Diem";
            this.colDiem.HeaderText = "Điểm";
            this.colDiem.MinimumWidth = 6;
            this.colDiem.Name = "colDiem";
            this.colDiem.ReadOnly = true;
            // 
            // btoXoa
            // 
            this.btoXoa.Enabled = false;
            this.btoXoa.Image = ((System.Drawing.Image)(resources.GetObject("btoXoa.Image")));
            this.btoXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoXoa.Location = new System.Drawing.Point(737, 23);
            this.btoXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btoXoa.Name = "btoXoa";
            this.btoXoa.Size = new System.Drawing.Size(133, 43);
            this.btoXoa.TabIndex = 6;
            this.btoXoa.Text = "Xóa";
            this.btoXoa.UseVisualStyleBackColor = true;
            this.btoXoa.Click += new System.EventHandler(this.btoXoa_Click);
            // 
            // btoThem
            // 
            this.btoThem.Image = ((System.Drawing.Image)(resources.GetObject("btoThem.Image")));
            this.btoThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoThem.Location = new System.Drawing.Point(596, 23);
            this.btoThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btoThem.Name = "btoThem";
            this.btoThem.Size = new System.Drawing.Size(133, 43);
            this.btoThem.TabIndex = 5;
            this.btoThem.Text = "Thêm";
            this.btoThem.UseVisualStyleBackColor = true;
            this.btoThem.Click += new System.EventHandler(this.btoThem_Click);
            // 
            // tboDiem
            // 
            this.tboDiem.Location = new System.Drawing.Point(379, 33);
            this.tboDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboDiem.Name = "tboDiem";
            this.tboDiem.Size = new System.Drawing.Size(203, 22);
            this.tboDiem.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Điểm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Lớp học:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tboDiaChi);
            this.groupBox1.Controls.Add(this.grbGioiTinh);
            this.groupBox1.Controls.Add(this.chbGioiTinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboEmail);
            this.groupBox1.Controls.Add(this.tboDienThoai);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.tboTen);
            this.groupBox1.Controls.Add(this.tboHo);
            this.groupBox1.Location = new System.Drawing.Point(16, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(884, 191);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Địa chỉ";
            // 
            // tboDiaChi
            // 
            this.tboDiaChi.Location = new System.Drawing.Point(135, 106);
            this.tboDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboDiaChi.Name = "tboDiaChi";
            this.tboDiaChi.Size = new System.Drawing.Size(612, 22);
            this.tboDiaChi.TabIndex = 5;
            // 
            // grbGioiTinh
            // 
            this.grbGioiTinh.Controls.Add(this.rdbNu);
            this.grbGioiTinh.Controls.Add(this.rdbNam);
            this.grbGioiTinh.Location = new System.Drawing.Point(405, 62);
            this.grbGioiTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbGioiTinh.Name = "grbGioiTinh";
            this.grbGioiTinh.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbGioiTinh.Size = new System.Drawing.Size(163, 42);
            this.grbGioiTinh.TabIndex = 4;
            this.grbGioiTinh.TabStop = false;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(91, 14);
            this.rdbNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(45, 20);
            this.rdbNu.TabIndex = 1;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(7, 14);
            this.rdbNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(57, 20);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // chbGioiTinh
            // 
            this.chbGioiTinh.AutoSize = true;
            this.chbGioiTinh.Checked = true;
            this.chbGioiTinh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbGioiTinh.Location = new System.Drawing.Point(309, 78);
            this.chbGioiTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbGioiTinh.Name = "chbGioiTinh";
            this.chbGioiTinh.Size = new System.Drawing.Size(76, 20);
            this.chbGioiTinh.TabIndex = 3;
            this.chbGioiTinh.Text = "Giới tính";
            this.chbGioiTinh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Họ tên";
            // 
            // tboEmail
            // 
            this.tboEmail.Location = new System.Drawing.Point(405, 144);
            this.tboEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboEmail.Name = "tboEmail";
            this.tboEmail.Size = new System.Drawing.Size(341, 22);
            this.tboEmail.TabIndex = 7;
            // 
            // tboDienThoai
            // 
            this.tboDienThoai.Location = new System.Drawing.Point(135, 144);
            this.tboDienThoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboDienThoai.Name = "tboDienThoai";
            this.tboDienThoai.Size = new System.Drawing.Size(149, 22);
            this.tboDienThoai.TabIndex = 6;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(135, 68);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(149, 22);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // tboTen
            // 
            this.tboTen.Location = new System.Drawing.Point(293, 30);
            this.tboTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboTen.Name = "tboTen";
            this.tboTen.Size = new System.Drawing.Size(327, 22);
            this.tboTen.TabIndex = 1;
            // 
            // tboHo
            // 
            this.tboHo.Location = new System.Drawing.Point(135, 30);
            this.tboHo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboHo.Name = "tboHo";
            this.tboHo.Size = new System.Drawing.Size(149, 22);
            this.tboHo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 40);
            this.label3.TabIndex = 28;
            this.label3.Text = "THÊM HỒ SƠ HỌC VIÊN";
            // 
            // erpMessage
            // 
            this.erpMessage.ContainerControl = this;
            // 
            // btoLuu
            // 
            this.btoLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btoLuu.Image = ((System.Drawing.Image)(resources.GetObject("btoLuu.Image")));
            this.btoLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoLuu.Location = new System.Drawing.Point(395, 671);
            this.btoLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btoLuu.Name = "btoLuu";
            this.btoLuu.Size = new System.Drawing.Size(133, 43);
            this.btoLuu.TabIndex = 24;
            this.btoLuu.Text = "Lưu";
            this.btoLuu.UseVisualStyleBackColor = true;
            this.btoLuu.Click += new System.EventHandler(this.btoLuu_Click_1);
            // 
            // frmThemHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 742);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btoLuu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThemHocVien";
            this.Text = "frmAddHocVien";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVienDangKy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbGioiTinh.ResumeLayout(false);
            this.grbGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Button btoLuu;
        private System.Windows.Forms.Button btoLop;
        private System.Windows.Forms.DataGridView dgvHocVienDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem;
        private System.Windows.Forms.Button btoXoa;
        private System.Windows.Forms.Button btoThem;
        private System.Windows.Forms.TextBox tboDiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboDiaChi;
        private System.Windows.Forms.GroupBox grbGioiTinh;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.CheckBox chbGioiTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboEmail;
        private System.Windows.Forms.TextBox tboDienThoai;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox tboTen;
        private System.Windows.Forms.TextBox tboHo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider erpMessage;
    }
}