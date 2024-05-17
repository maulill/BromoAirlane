namespace BromoAirlane
{
    partial class Form10
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label16 = new Label();
            pictureBox2 = new PictureBox();
            label17 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            label22 = new Label();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label4 = new Label();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.chevron_left_solid_72;
            pictureBox1.Location = new Point(-3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 2);
            label1.Name = "label1";
            label1.Size = new Size(174, 28);
            label1.TabIndex = 3;
            label1.Text = "List Penerbangan";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.ControlDarkDark;
            label16.Location = new Point(32, 59);
            label16.Name = "label16";
            label16.Size = new Size(96, 20);
            label16.TabIndex = 25;
            label16.Text = "Juanda (SUB)";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.right_arrow_regular_72;
            pictureBox2.Location = new Point(134, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.ControlDarkDark;
            label17.Location = new Point(170, 59);
            label17.Name = "label17";
            label17.Size = new Size(156, 20);
            label17.TabIndex = 27;
            label17.Text = "Soekarno-Hatta (CGK)";
            label17.Click += label17_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.circle_solid_72;
            pictureBox3.Location = new Point(339, 67);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 10);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(363, 60);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 29;
            label2.Text = "Wed, 24 May 2023";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.circle_solid_72;
            pictureBox4.Location = new Point(510, 67);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(10, 10);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = SystemColors.ControlDarkDark;
            label22.Location = new Point(546, 61);
            label22.Name = "label22";
            label22.Size = new Size(101, 20);
            label22.TabIndex = 32;
            label22.Text = "1 penumpang";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(958, 209);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 28);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(748, 158);
            button1.Name = "button1";
            button1.Size = new Size(141, 29);
            button1.TabIndex = 6;
            button1.Text = "Terapkan Filter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 135);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 5;
            label4.Text = "Urutkan Berdasarkan";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(383, 46);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(115, 24);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "18:00 - 24:00";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(262, 46);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(115, 24);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "12:00 - 18:00";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(141, 46);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(115, 24);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "06:00 - 12:00";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(20, 46);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(115, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "00:00 - 06:00";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 23);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 0;
            label3.Text = "Waktu Keberangkatan";
            label3.Click += label3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(12, 331);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1003, 297);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Kode Penerbangan ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Maskapai";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Bandara Keberangkatan";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Bandara Tujuan";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Harga per Tiket";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Tanggal Keberangkatan";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Waktu Penerbangan";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 640);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label22);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label17);
            Controls.Add(pictureBox2);
            Controls.Add(label16);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form10";
            Text = "Form10";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label16;
        private PictureBox pictureBox2;
        private Label label17;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox4;
        private Label label22;
        private GroupBox groupBox1;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private Label label4;
        private ComboBox comboBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewButtonColumn Column8;
    }
}