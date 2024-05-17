namespace BromoAirlane
{
    partial class Form4
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
            panel2 = new Panel();
            label10 = new Label();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            masterBandaraToolStripMenuItem = new ToolStripMenuItem();
            masterMaskapaiToolStripMenuItem = new ToolStripMenuItem();
            masterJadwalPenerbanganToolStripMenuItem = new ToolStripMenuItem();
            masterKodePromoToolStripMenuItem = new ToolStripMenuItem();
            ubahStatusPenerbanganToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 86);
            panel2.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(75, 29);
            label10.Name = "label10";
            label10.Size = new Size(108, 28);
            label10.TabIndex = 1;
            label10.Text = "Dashboard";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Image = Properties.Resources.menu_alt_72;
            button1.Location = new Point(3, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 61);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { masterBandaraToolStripMenuItem, masterMaskapaiToolStripMenuItem, masterJadwalPenerbanganToolStripMenuItem, masterKodePromoToolStripMenuItem, ubahStatusPenerbanganToolStripMenuItem });
            menuStrip1.Location = new Point(0, 86);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(230, 472);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // masterBandaraToolStripMenuItem
            // 
            masterBandaraToolStripMenuItem.Image = Properties.Resources.map_selected_72;
            masterBandaraToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            masterBandaraToolStripMenuItem.Name = "masterBandaraToolStripMenuItem";
            masterBandaraToolStripMenuItem.Size = new Size(223, 24);
            masterBandaraToolStripMenuItem.Text = "Master Bandara";
            masterBandaraToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // masterMaskapaiToolStripMenuItem
            // 
            masterMaskapaiToolStripMenuItem.Image = Properties.Resources.plane_take_off_unselected_721;
            masterMaskapaiToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            masterMaskapaiToolStripMenuItem.Name = "masterMaskapaiToolStripMenuItem";
            masterMaskapaiToolStripMenuItem.Size = new Size(223, 24);
            masterMaskapaiToolStripMenuItem.Text = "Master Maskapai";
            masterMaskapaiToolStripMenuItem.Click += masterMaskapaiToolStripMenuItem_Click;
            // 
            // masterJadwalPenerbanganToolStripMenuItem
            // 
            masterJadwalPenerbanganToolStripMenuItem.Image = Properties.Resources.calendar_unselected_72;
            masterJadwalPenerbanganToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            masterJadwalPenerbanganToolStripMenuItem.Name = "masterJadwalPenerbanganToolStripMenuItem";
            masterJadwalPenerbanganToolStripMenuItem.Size = new Size(223, 24);
            masterJadwalPenerbanganToolStripMenuItem.Text = "Master Jadwal Penerbangan";
            // 
            // masterKodePromoToolStripMenuItem
            // 
            masterKodePromoToolStripMenuItem.Image = Properties.Resources.purchase_tag_alt_unselected_72;
            masterKodePromoToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            masterKodePromoToolStripMenuItem.Name = "masterKodePromoToolStripMenuItem";
            masterKodePromoToolStripMenuItem.Size = new Size(223, 24);
            masterKodePromoToolStripMenuItem.Text = "Master Kode Promo";
            // 
            // ubahStatusPenerbanganToolStripMenuItem
            // 
            ubahStatusPenerbanganToolStripMenuItem.Image = Properties.Resources.notepad_unselected_72;
            ubahStatusPenerbanganToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            ubahStatusPenerbanganToolStripMenuItem.Name = "ubahStatusPenerbanganToolStripMenuItem";
            ubahStatusPenerbanganToolStripMenuItem.Size = new Size(223, 24);
            ubahStatusPenerbanganToolStripMenuItem.Text = "Ubah Status Penerbangan";
            ubahStatusPenerbanganToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.BackgroundImage = Properties.Resources.log_out_unselected_72;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(2, 527);
            button2.Name = "button2";
            button2.Size = new Size(29, 31);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(330, 89);
            label2.Name = "label2";
            label2.Size = new Size(162, 28);
            label2.TabIndex = 6;
            label2.Text = "Master Bandara";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 117);
            label3.Name = "label3";
            label3.Size = new Size(341, 20);
            label3.TabIndex = 7;
            label3.Text = "Semua bandara yang terdaftar akan muncul di sini";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 325);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 9;
            label4.Text = "Nama ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(330, 360);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 10;
            label5.Text = "Kode IATA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 407);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 11;
            label6.Text = "Kota";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(330, 448);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 12;
            label7.Text = "Negara";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(714, 318);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 13;
            label8.Text = "Jumlah Terminal";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(714, 357);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 14;
            label9.Text = "Alamat";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(429, 318);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 27);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(429, 357);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 27);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(429, 400);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(259, 27);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(836, 354);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 122);
            textBox4.TabIndex = 18;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(836, 316);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(250, 27);
            numericUpDown1.TabIndex = 19;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(429, 448);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 20;
            // 
            // button3
            // 
            button3.Location = new Point(892, 502);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 21;
            button3.Text = "Batal";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(992, 502);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 22;
            button4.Text = "Simpan";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(34, 531);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 23;
            label1.Text = "Logout";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(330, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(749, 148);
            dataGridView1.TabIndex = 24;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nama";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "KodeIATA";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Kota";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Negara";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Jumlah Terminal";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Alamat";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 558);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form4";
            Text = "=";
            Load += Form4_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem masterBandaraToolStripMenuItem;
        private ToolStripMenuItem masterMaskapaiToolStripMenuItem;
        private ToolStripMenuItem masterJadwalPenerbanganToolStripMenuItem;
        private ToolStripMenuItem masterKodePromoToolStripMenuItem;
        private ToolStripMenuItem ubahStatusPenerbanganToolStripMenuItem;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label10;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}