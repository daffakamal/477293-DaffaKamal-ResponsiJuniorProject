namespace ResponsiJunpro_DaffaKamal
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
            lblLogo = new Label();
            tbNamaKaryawan = new TextBox();
            lbNamaKaryawan = new Label();
            lbDepKaryawan = new Label();
            cbDepKaryawan = new ComboBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dgv = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point(83, 34);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(31, 15);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "logo";
            // 
            // tbNamaKaryawan
            // 
            tbNamaKaryawan.Location = new Point(121, 92);
            tbNamaKaryawan.Name = "tbNamaKaryawan";
            tbNamaKaryawan.Size = new Size(121, 23);
            tbNamaKaryawan.TabIndex = 1;
            // 
            // lbNamaKaryawan
            // 
            lbNamaKaryawan.AutoSize = true;
            lbNamaKaryawan.Location = new Point(22, 95);
            lbNamaKaryawan.Name = "lbNamaKaryawan";
            lbNamaKaryawan.Size = new Size(102, 15);
            lbNamaKaryawan.TabIndex = 2;
            lbNamaKaryawan.Text = "Nama Karyawan : ";
            // 
            // lbDepKaryawan
            // 
            lbDepKaryawan.AutoSize = true;
            lbDepKaryawan.Location = new Point(22, 136);
            lbDepKaryawan.Name = "lbDepKaryawan";
            lbDepKaryawan.Size = new Size(94, 15);
            lbDepKaryawan.TabIndex = 3;
            lbDepKaryawan.Text = "Dep. Karyawan : ";
            // 
            // cbDepKaryawan
            // 
            cbDepKaryawan.FormattingEnabled = true;
            cbDepKaryawan.Location = new Point(121, 133);
            cbDepKaryawan.Name = "cbDepKaryawan";
            cbDepKaryawan.Size = new Size(121, 23);
            cbDepKaryawan.TabIndex = 4;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(22, 195);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(227, 195);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(121, 195);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ControlLight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(22, 243);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(386, 183);
            dgv.TabIndex = 8;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(37, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 37);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(429, 34);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 10;
            label1.Text = "ID Departemen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 58);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 11;
            label2.Text = "HR: HR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 82);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 12;
            label3.Text = "ENG: Engineer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 107);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 13;
            label4.Text = "DEV: Developer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 133);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 14;
            label5.Text = "PM: Product M";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(429, 158);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 15;
            label6.Text = "FIN: Finance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgv);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(cbDepKaryawan);
            Controls.Add(lbDepKaryawan);
            Controls.Add(lbNamaKaryawan);
            Controls.Add(tbNamaKaryawan);
            Controls.Add(lblLogo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogo;
        private TextBox tbNamaKaryawan;
        private Label lbNamaKaryawan;
        private Label lbDepKaryawan;
        private ComboBox cbDepKaryawan;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dgv;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
