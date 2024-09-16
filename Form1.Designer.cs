namespace PhanBaoTrung_Buoi4
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
            txt_mssv = new TextBox();
            btn_save = new Button();
            txt_ht = new TextBox();
            label2 = new Label();
            txt_gt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txt_dc = new TextBox();
            label5 = new Label();
            dt_ns = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 48);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã Sinh Viên:";
            // 
            // txt_mssv
            // 
            txt_mssv.Location = new Point(162, 40);
            txt_mssv.Name = "txt_mssv";
            txt_mssv.Size = new Size(164, 23);
            txt_mssv.TabIndex = 1;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.Location = new Point(425, 163);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 2;
            btn_save.Text = "Kiểm Tra";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txt_ht
            // 
            txt_ht.Location = new Point(162, 102);
            txt_ht.Name = "txt_ht";
            txt_ht.Size = new Size(164, 23);
            txt_ht.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 110);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Họ Tên:";
            // 
            // txt_gt
            // 
            txt_gt.Location = new Point(162, 163);
            txt_gt.Name = "txt_gt";
            txt_gt.Size = new Size(164, 23);
            txt_gt.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 171);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Giới Tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(425, 48);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 7;
            label4.Text = "Ngày Sinh:";
            // 
            // txt_dc
            // 
            txt_dc.Location = new Point(523, 92);
            txt_dc.Name = "txt_dc";
            txt_dc.Size = new Size(164, 23);
            txt_dc.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(425, 100);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 9;
            label5.Text = "Địa Chỉ:";
            // 
            // dt_ns
            // 
            dt_ns.Location = new Point(511, 40);
            dt_ns.Name = "dt_ns";
            dt_ns.Size = new Size(200, 23);
            dt_ns.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(723, 178);
            dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(535, 163);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(636, 162);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(dt_ns);
            Controls.Add(txt_dc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_gt);
            Controls.Add(label3);
            Controls.Add(txt_ht);
            Controls.Add(label2);
            Controls.Add(btn_save);
            Controls.Add(txt_mssv);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_mssv;
        private Button btn_save;
        private TextBox txt_ht;
        private Label label2;
        private TextBox txt_gt;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox txt_dc;
        private Label label5;
        private DateTimePicker dt_ns;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}
