﻿namespace BromoAirlane
{
    partial class Form8
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
            listView1 = new ListView();
            button2 = new Button();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
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
            panel2.Size = new Size(800, 86);
            panel2.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(70, 28);
            label10.Name = "label10";
            label10.Size = new Size(108, 28);
            label10.TabIndex = 4;
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
            menuStrip1.Size = new Size(230, 437);
            menuStrip1.TabIndex = 7;
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
            masterKodePromoToolStripMenuItem.Image = Properties.Resources.purchase_tag_alt_unselected_72;
            masterKodePromoToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            masterKodePromoToolStripMenuItem.Name = "masterKodePromoToolStripMenuItem";
            masterKodePromoToolStripMenuItem.Size = new Size(223, 24);
            masterKodePromoToolStripMenuItem.Text = "Master Kode Promo";
            masterKodePromoToolStripMenuItem.Click += masterKodePromoToolStripMenuItem_Click;
            // 
            // ubahStatusPenerbanganToolStripMenuItem
            // 
            ubahStatusPenerbanganToolStripMenuItem.Image = Properties.Resources.notepad_selected_72;
            ubahStatusPenerbanganToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            ubahStatusPenerbanganToolStripMenuItem.Name = "ubahStatusPenerbanganToolStripMenuItem";
            ubahStatusPenerbanganToolStripMenuItem.Size = new Size(223, 24);
            ubahStatusPenerbanganToolStripMenuItem.Text = "Ubah Status Penerbangan";
            ubahStatusPenerbanganToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            ubahStatusPenerbanganToolStripMenuItem.Click += ubahStatusPenerbanganToolStripMenuItem_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(243, 150);
            listView1.Name = "listView1";
            listView1.Size = new Size(532, 275);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.BackgroundImage = Properties.Resources.log_out_unselected_72;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(-2, 494);
            button2.Name = "button2";
            button2.Size = new Size(29, 31);
            button2.TabIndex = 35;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(21, 498);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 36;
            label8.Text = "Logout";
            label8.Click += label8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 89);
            label1.Name = "label1";
            label1.Size = new Size(255, 28);
            label1.TabIndex = 37;
            label1.Text = "Ubah Status Penerbangan";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 117);
            label2.Name = "label2";
            label2.Size = new Size(327, 20);
            label2.TabIndex = 38;
            label2.Text = "Anda bisa mengubah status penerbangan di sini";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 523);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private ListView listView1;
        private Button button2;
        private Label label8;
        private Label label1;
        private Label label2;
        private Label label10;
    }
}