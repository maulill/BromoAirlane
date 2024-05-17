namespace BromoAirlane
{
    partial class Form7
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
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            label10 = new Label();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            masterBandaraToolStripMenuItem = new ToolStripMenuItem();
            masterMaskapaiToolStripMenuItem = new ToolStripMenuItem();
            masterJadwalPenerbanganToolStripMenuItem = new ToolStripMenuItem();
            masterKodePromoToolStripMenuItem = new ToolStripMenuItem();
            ubahStatusPenerbanganToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            textBox2 = new TextBox();
            notifyIcon1 = new NotifyIcon(components);
            button2 = new Button();
            label8 = new Label();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewButtonColumn();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
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
            panel2.Size = new Size(1084, 86);
            panel2.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(70, 28);
            label10.Name = "label10";
            label10.Size = new Size(108, 28);
            label10.TabIndex = 3;
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
            menuStrip1.Size = new Size(230, 440);
            menuStrip1.TabIndex = 6;
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
            masterJadwalPenerbanganToolStripMenuItem.Image = Properties.Resources.calendar_unselected_72;
            masterJadwalPenerbanganToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            masterJadwalPenerbanganToolStripMenuItem.Name = "masterJadwalPenerbanganToolStripMenuItem";
            masterJadwalPenerbanganToolStripMenuItem.Size = new Size(223, 24);
            masterJadwalPenerbanganToolStripMenuItem.Text = "Master Jadwal Penerbangan";
            masterJadwalPenerbanganToolStripMenuItem.Click += masterJadwalPenerbanganToolStripMenuItem_Click;
            // 
            // masterKodePromoToolStripMenuItem
            // 
            masterKodePromoToolStripMenuItem.Image = Properties.Resources.purchase_tag_alt_selected_722;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 89);
            label1.Name = "label1";
            label1.Size = new Size(198, 28);
            label1.TabIndex = 22;
            label1.Text = "Master kode promo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 117);
            label2.Name = "label2";
            label2.Size = new Size(364, 20);
            label2.TabIndex = 23;
            label2.Text = "Semua kode promo yang terdaftar akan muncul disini";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 309);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(92, 20);
            label3.TabIndex = 24;
            label3.Text = "Kode Promo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 342);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 25;
            label4.Text = "Berlaku Sampai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 375);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 26;
            label5.Text = "Persentase Diskon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 408);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 27;
            label6.Text = "Maksimum Diskon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(734, 295);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 28;
            label7.Text = "Deskripsi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(436, 302);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 27);
            textBox1.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(436, 335);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(278, 27);
            dateTimePicker1.TabIndex = 30;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(436, 368);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(278, 27);
            numericUpDown1.TabIndex = 31;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(436, 401);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(278, 27);
            numericUpDown2.TabIndex = 32;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(809, 292);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 136);
            textBox2.TabIndex = 33;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.BackgroundImage = Properties.Resources.log_out_unselected_72;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(-5, 498);
            button2.Name = "button2";
            button2.Size = new Size(29, 31);
            button2.TabIndex = 34;
            button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(24, 503);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 35;
            label8.Text = "Logout";
            label8.Click += label8_Click;
            // 
            // button3
            // 
            button3.Location = new Point(845, 454);
            button3.Name = "button3";
            button3.Size = new Size(94, 37);
            button3.TabIndex = 36;
            button3.Text = "Batal";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(945, 454);
            button4.Name = "button4";
            button4.Size = new Size(94, 37);
            button4.TabIndex = 37;
            button4.Text = "Simpan";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView1.Location = new Point(281, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(770, 135);
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
            Column7.HeaderText = "Durasi penerbangan";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Status Terakhir";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Terakhir Diubah";
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
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 526);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private TextBox textBox2;
        private NotifyIcon notifyIcon1;
        private Button button2;
        private Label label8;
        private Button button3;
        private Button button4;
        private Label label10;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewButtonColumn Column10;
    }
}