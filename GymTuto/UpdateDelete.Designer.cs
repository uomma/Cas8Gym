﻿namespace GymTuto
{
    partial class UpdateDelete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TimeCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AmountTb = new System.Windows.Forms.TextBox();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AgeTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MemberSDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemberSDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 16.2F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(364, 696);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(447, 33);
            this.label10.TabIndex = 43;
            this.label10.Text = "Developed by Marcello Leone";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(774, 608);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 46);
            this.button4.TabIndex = 42;
            this.button4.Text = "BACK";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(67, 661);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 46);
            this.button3.TabIndex = 41;
            this.button3.Text = "RESET";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Sans Serif Collection", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(67, 618);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 33);
            this.button2.TabIndex = 40;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TimeCb
            // 
            this.TimeCb.FormattingEnabled = true;
            this.TimeCb.Items.AddRange(new object[] {
            "6:00-8:00",
            "8:00-10:00",
            "18:00-20:00",
            "20:00-22:00"});
            this.TimeCb.Location = new System.Drawing.Point(67, 501);
            this.TimeCb.Margin = new System.Windows.Forms.Padding(2);
            this.TimeCb.Name = "TimeCb";
            this.TimeCb.Size = new System.Drawing.Size(139, 21);
            this.TimeCb.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Orange;
            this.label9.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(101, 449);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 49);
            this.label9.TabIndex = 38;
            this.label9.Text = "Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Orange;
            this.label8.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(50, 365);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 49);
            this.label8.TabIndex = 37;
            this.label8.Text = "Monthly Amount";
            // 
            // AmountTb
            // 
            this.AmountTb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AmountTb.Location = new System.Drawing.Point(67, 416);
            this.AmountTb.Margin = new System.Windows.Forms.Padding(2);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(139, 20);
            this.AmountTb.TabIndex = 36;
            // 
            // GenderCb
            // 
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCb.Location = new System.Drawing.Point(67, 581);
            this.GenderCb.Margin = new System.Windows.Forms.Padding(2);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(139, 21);
            this.GenderCb.TabIndex = 35;
            this.GenderCb.SelectedIndexChanged += new System.EventHandler(this.GenderCb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Orange;
            this.label7.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(101, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 49);
            this.label7.TabIndex = 34;
            this.label7.Text = "Age";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgeTb
            // 
            this.AgeTb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AgeTb.Location = new System.Drawing.Point(67, 323);
            this.AgeTb.Margin = new System.Windows.Forms.Padding(2);
            this.AgeTb.Name = "AgeTb";
            this.AgeTb.Size = new System.Drawing.Size(139, 20);
            this.AgeTb.TabIndex = 33;
            this.AgeTb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Orange;
            this.label6.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(92, 531);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 49);
            this.label6.TabIndex = 32;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Orange;
            this.label5.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(50, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 49);
            this.label5.TabIndex = 31;
            this.label5.Text = "Phone Number";
            // 
            // PhoneTb
            // 
            this.PhoneTb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PhoneTb.Location = new System.Drawing.Point(67, 249);
            this.PhoneTb.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(139, 20);
            this.PhoneTb.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Orange;
            this.label4.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(50, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 49);
            this.label4.TabIndex = 29;
            this.label4.Text = "Member Name";
            // 
            // NameTb
            // 
            this.NameTb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NameTb.Location = new System.Drawing.Point(67, 163);
            this.NameTb.Margin = new System.Windows.Forms.Padding(2);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(139, 20);
            this.NameTb.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(469, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "UPDATE OR DELETE MEMBER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(544, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 40);
            this.label1.TabIndex = 25;
            this.label1.Text = "CAS8GYM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(912, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 83);
            this.label3.TabIndex = 45;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(322, 722);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(550, 33);
            this.label12.TabIndex = 47;
            this.label12.Text = "email: marcelloleone975@gmail.com";
            // 
            // MemberSDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.MemberSDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.MemberSDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MemberSDGV.BackgroundColor = System.Drawing.Color.White;
            this.MemberSDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MemberSDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MemberSDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberSDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.MemberSDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MemberSDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.MemberSDGV.EnableHeadersVisualStyles = false;
            this.MemberSDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MemberSDGV.Location = new System.Drawing.Point(307, 107);
            this.MemberSDGV.Margin = new System.Windows.Forms.Padding(2);
            this.MemberSDGV.Name = "MemberSDGV";
            this.MemberSDGV.RowHeadersVisible = false;
            this.MemberSDGV.RowHeadersWidth = 51;
            this.MemberSDGV.RowTemplate.Height = 20;
            this.MemberSDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MemberSDGV.Size = new System.Drawing.Size(618, 460);
            this.MemberSDGV.TabIndex = 48;
            this.MemberSDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.MemberSDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MemberSDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MemberSDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MemberSDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MemberSDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MemberSDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MemberSDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MemberSDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MemberSDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MemberSDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MemberSDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MemberSDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MemberSDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.MemberSDGV.ThemeStyle.ReadOnly = false;
            this.MemberSDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MemberSDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MemberSDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberSDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MemberSDGV.ThemeStyle.RowsStyle.Height = 20;
            this.MemberSDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.MemberSDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.MemberSDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberSDGV_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(67, 714);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 46);
            this.button5.TabIndex = 49;
            this.button5.Text = "DELETE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // UpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 717);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.MemberSDGV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TimeCb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AgeTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDelete";
            this.Load += new System.EventHandler(this.UpdateDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemberSDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox TimeCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AmountTb;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AgeTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaDataGridView MemberSDGV;
        private System.Windows.Forms.Button button5;
    }
}