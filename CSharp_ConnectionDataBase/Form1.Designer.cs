namespace CSharp_ConnectionDataBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            maTen = new TextBox();
            hoTen = new TextBox();
            namSinh = new TextBox();
            queQuan = new TextBox();
            btnThoat = new Button();
            btnSua = new Button();
            btnTim = new Button();
            btnXoa = new Button();
            btnReset = new Button();
            btnThem = new Button();
            dgvQLTT = new DataGridView();
            btnLamMoi = new Button();
            ID = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvQLTT).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 109);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 0;
            label2.Text = "Năm sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 148);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            label3.Text = "Quê quán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 73);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 0;
            label4.Text = "Họ tên:";
            // 
            // maTen
            // 
            maTen.Location = new Point(127, 36);
            maTen.Name = "maTen";
            maTen.Size = new Size(152, 30);
            maTen.TabIndex = 1;
            // 
            // hoTen
            // 
            hoTen.Location = new Point(127, 70);
            hoTen.Name = "hoTen";
            hoTen.Size = new Size(152, 30);
            hoTen.TabIndex = 1;
            // 
            // namSinh
            // 
            namSinh.Location = new Point(127, 106);
            namSinh.Name = "namSinh";
            namSinh.Size = new Size(152, 30);
            namSinh.TabIndex = 1;
            // 
            // queQuan
            // 
            queQuan.Location = new Point(127, 145);
            queQuan.Name = "queQuan";
            queQuan.Size = new Size(152, 30);
            queQuan.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(460, 34);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(83, 32);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(310, 106);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(83, 32);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(519, 135);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(83, 32);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(310, 68);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(83, 32);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(310, 146);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(83, 32);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(310, 31);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(83, 32);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvQLTT
            // 
            dgvQLTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLTT.Dock = DockStyle.Bottom;
            dgvQLTT.Location = new Point(0, 202);
            dgvQLTT.Name = "dgvQLTT";
            dgvQLTT.RowHeadersWidth = 51;
            dgvQLTT.Size = new Size(806, 276);
            dgvQLTT.TabIndex = 3;
            dgvQLTT.CellContentClick += dgvQLTT_CellContentClick;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(561, 34);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(106, 32);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // ID
            // 
            ID.Location = new Point(519, 99);
            ID.Name = "ID";
            ID.Size = new Size(125, 30);
            ID.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(464, 103);
            label5.Name = "label5";
            label5.Size = new Size(37, 23);
            label5.TabIndex = 0;
            label5.Text = "ID:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 478);
            Controls.Add(ID);
            Controls.Add(dgvQLTT);
            Controls.Add(btnThem);
            Controls.Add(btnReset);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Controls.Add(btnSua);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThoat);
            Controls.Add(queQuan);
            Controls.Add(namSinh);
            Controls.Add(hoTen);
            Controls.Add(maTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label1);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQLTT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox maTen;
        private TextBox hoTen;
        private TextBox namSinh;
        private TextBox queQuan;
        private Button btnThoat;
        private Button btnSua;
        private Button btnTim;
        private Button btnXoa;
        private Button btnReset;
        private Button btnThem;
        private DataGridView dgvQLTT;
        private Button btnLamMoi;
        private TextBox ID;
        private Label label5;
    }
}
