namespace BromoAirlane
{
    partial class Form6
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            button3 = new Button();
            button4 = new Button();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewButtonColumn();
            Column10 = new DataGridViewButtonColumn();
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
            panel2.Size = new Size(979, 86);
            panel2.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(71, 29);
            label10.Name = "label10";
            label10.Size = new Size(108, 28);
            label10.TabIndex = 2;
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
            menuStrip1.Size = new Size(230, 448);
            menuStrip1.TabIndex = 5;
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
            masterBandaraToolStripMenuItem.Click += masterBandaraToolStripMenuItem_Click;
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
            masterJadwalPenerbanganToolStripMenuItem.Image = Properties.Resources.calendar_selected_72;
            masterJadwalPenerbanganToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            masterJadwalPenerbanganToolStripMenuItem.Name = "masterJadwalPenerbanganToolStripMenuItem";
            masterJadwalPenerbanganToolStripMenuItem.Size = new Size(223, 24);
            masterJadwalPenerbanganToolStripMenuItem.Text = "Master Jadwal Penerbangan";
            masterJadwalPenerbanganToolStripMenuItem.Click += masterJadwalPenerbanganToolStripMenuItem_Click;
            // 
            // masterKodePromoToolStripMenuItem
            // 
            masterKodePromoToolStripMenuItem.Image = Properties.Resources.purchase_tag_alt_unselected_72;
            masterKodePromoToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            masterKodePromoToolStripMenuItem.Name = "masterKodePromoToolStripMenuItem";
            masterKodePromoToolStripMenuItem.Size = new Size(223, 24);
            masterKodePromoToolStripMenuItem.Text = "Master Kode Promo";
            masterKodePromoToolStripMenuItem.Click += masterKodePromoToolStripMenuItem_Click;
            // 
            // ubahStatusPenerbanganToolStripMenuItem
            // 
            ubahStatusPenerbanganToolStripMenuItem.Image = Properties.Resources.notepad_unselected_72;
            ubahStatusPenerbanganToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            ubahStatusPenerbanganToolStripMenuItem.Name = "ubahStatusPenerbanganToolStripMenuItem";
            ubahStatusPenerbanganToolStripMenuItem.Size = new Size(223, 24);
            ubahStatusPenerbanganToolStripMenuItem.Text = "Ubah Status Penerbangan";
            ubahStatusPenerbanganToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            ubahStatusPenerbanganToolStripMenuItem.Click += ubahStatusPenerbanganToolStripMenuItem_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.BackgroundImage = Properties.Resources.log_out_unselected_72;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(-3, 503);
            button2.Name = "button2";
            button2.Size = new Size(29, 31);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(25, 509);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 7;
            label1.Text = "Logout";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(245, 86);
            label2.Name = "label2";
            label2.Size = new Size(278, 28);
            label2.TabIndex = 17;
            label2.Text = "Master Jadwal Penerbangan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 114);
            label3.Name = "label3";
            label3.Size = new Size(324, 20);
            label3.TabIndex = 18;
            label3.Text = "Semua jadwal penerbangan akan muncul di sini";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 320);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 20;
            label4.Text = "Kode Penerbangan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 362);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 21;
            label5.Text = "Dari";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(245, 407);
            label6.Name = "label6";
            label6.Size = new Size(26, 20);
            label6.TabIndex = 22;
            label6.Text = "Ke";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(245, 451);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 23;
            label7.Text = "Maskapai";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(547, 320);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 24;
            label8.Text = "Tanggal";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(547, 362);
            label9.Name = "label9";
            label9.Size = new Size(140, 20);
            label9.TabIndex = 25;
            label9.Text = "Waktu Penerbangan";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(546, 407);
            label11.Name = "label11";
            label11.Size = new Size(141, 20);
            label11.TabIndex = 26;
            label11.Text = "Durasi Penerbangan";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(546, 451);
            label12.Name = "label12";
            label12.Size = new Size(112, 20);
            label12.TabIndex = 27;
            label12.Text = "Harga per Tiket";
            // 
            // button3
            // 
            button3.Location = new Point(773, 493);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 28;
            button3.Text = "Batal";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(873, 493);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 29;
            button4.Text = "Simpan";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(719, 444);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(248, 27);
            numericUpDown1.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(719, 320);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(719, 359);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(719, 404);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 33;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(399, 317);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 34;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Abdulrachman Saleh", "Adisucipto", "Ahmad Yani" });
            comboBox1.Location = new Point(373, 359);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 35;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Abdulrachman Saleh", "Adisucipto", "Ahmad Yani" });
            comboBox2.Location = new Point(373, 403);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 36;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Batik Air", "Citlink", "Garuda Indonesia" });
            comboBox3.Location = new Point(373, 444);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 37;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView1.Location = new Point(245, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(724, 174);
            dataGridView1.TabIndex = 38;
            // 
            // Column1
            // 
            Column1.HeaderText = "Kode Penerbangan";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Bandara Keberangkatan";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Bandara Tujuan";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Maskapai";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Tanggal Keberangkatan";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Waktu Keberangkatan";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Durasi Penerbangan";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Harga per Tiket";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 534);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            Name = "Form6";
            Text = "Form6";
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
        private Label label10;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem masterBandaraToolStripMenuItem;
        private ToolStripMenuItem masterMaskapaiToolStripMenuItem;
        private ToolStripMenuItem masterJadwalPenerbanganToolStripMenuItem;
        private ToolStripMenuItem masterKodePromoToolStripMenuItem;
        private ToolStripMenuItem ubahStatusPenerbanganToolStripMenuItem;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private Button button3;
        private Button button4;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewButtonColumn Column9;
        private DataGridViewButtonColumn Column10;
    }
}