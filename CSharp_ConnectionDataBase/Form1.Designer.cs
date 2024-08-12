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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dgvQLTT = new DataGridView();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQLTT).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(59, 18);
            label1.TabIndex = 0;
            label1.Text = "Mã tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 116);
            label2.Name = "label2";
            label2.Size = new Size(74, 18);
            label2.TabIndex = 0;
            label2.Text = "Năm sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 152);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 0;
            label3.Text = "Quê quán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 73);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 0;
            label4.Text = "Họ tên:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 26);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 26);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(127, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 26);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(127, 149);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(152, 26);
            textBox4.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(438, 39);
            button1.Name = "button1";
            button1.Size = new Size(83, 32);
            button1.TabIndex = 2;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(359, 194);
            button2.Name = "button2";
            button2.Size = new Size(83, 32);
            button2.TabIndex = 2;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(581, 194);
            button3.Name = "button3";
            button3.Size = new Size(83, 32);
            button3.TabIndex = 2;
            button3.Text = "Tìm kiếm";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(467, 194);
            button4.Name = "button4";
            button4.Size = new Size(83, 32);
            button4.TabIndex = 2;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(127, 194);
            button5.Name = "button5";
            button5.Size = new Size(83, 32);
            button5.TabIndex = 2;
            button5.Text = "Reset";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(243, 194);
            button6.Name = "button6";
            button6.Size = new Size(83, 32);
            button6.TabIndex = 2;
            button6.Text = "Thêm";
            button6.UseVisualStyleBackColor = true;
            // 
            // dgvQLTT
            // 
            dgvQLTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLTT.Dock = DockStyle.Bottom;
            dgvQLTT.Location = new Point(0, 241);
            dgvQLTT.Name = "dgvQLTT";
            dgvQLTT.Size = new Size(695, 237);
            dgvQLTT.TabIndex = 3;
            // 
            // button7
            // 
            button7.Location = new Point(548, 39);
            button7.Name = "button7";
            button7.Size = new Size(83, 32);
            button7.TabIndex = 2;
            button7.Text = "Trở về";
            button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 478);
            Controls.Add(dgvQLTT);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridView dgvQLTT;
        private Button button7;
    }
}
