namespace BromoAirlane
{
    partial class Form9
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            textBox2 = new TextBox();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            button3 = new Button();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.log_out_alt_72;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(744, 55);
            button2.Name = "button2";
            button2.Size = new Size(35, 29);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.airplane_ticket;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(703, 51);
            button1.Name = "button1";
            button1.Size = new Size(35, 36);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Alt;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 149);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 1;
            label1.Text = "Halo!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 177);
            label2.Name = "label2";
            label2.Size = new Size(298, 20);
            label2.TabIndex = 2;
            label2.Text = "Mau terbang kemana hari ini, [Nama akun]?";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.plane_take_off_solid_72;
            pictureBox2.Location = new Point(37, 227);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 227);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 4;
            label3.Text = "Berangkat dari";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 250);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 27);
            textBox1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.calendar_selected_72;
            pictureBox3.Location = new Point(38, 299);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(64, 322);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(257, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 299);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 8;
            label4.Text = "Tanggal Berangkat";
            label4.Click += label4_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.plane_land_solid_72;
            pictureBox4.Location = new Point(404, 227);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 227);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 10;
            label5.Text = "Tujuan";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(431, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 27);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.group_solid_72;
            pictureBox5.Location = new Point(405, 299);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(431, 299);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 13;
            label6.Text = "Jumlah Penumpang";
            label6.Click += label6_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(431, 322);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(254, 27);
            numericUpDown1.TabIndex = 14;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button3
            // 
            button3.Location = new Point(64, 374);
            button3.Name = "button3";
            button3.Size = new Size(150, 29);
            button3.TabIndex = 15;
            button3.Text = "Cari Penerbangan";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.mountain;
            pictureBox6.Location = new Point(599, 341);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(265, 134);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(pictureBox5);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox6);
            Name = "Form9";
            Text = "Form9";
            Load += Form9_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label5;
        private TextBox textBox2;
        private PictureBox pictureBox5;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private Button button3;
        private PictureBox pictureBox6;
    }
}