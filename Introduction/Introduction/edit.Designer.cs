﻿namespace Introduction
{
    partial class edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit));
            this.privilegie_comboBox = new System.Windows.Forms.ComboBox();
            this.atestat_textBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.privilegie_checkBox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.city_textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_button = new System.Windows.Forms.Button();
            this.exam1_textBox = new System.Windows.Forms.TextBox();
            this.average_textBox = new System.Windows.Forms.TextBox();
            this.specialty_combobox3 = new System.Windows.Forms.ComboBox();
            this.specialty_combobox2 = new System.Windows.Forms.ComboBox();
            this.specialty_combobox1 = new System.Windows.Forms.ComboBox();
            this.In_kode_textBox = new System.Windows.Forms.TextBox();
            this.exam2_textBox = new System.Windows.Forms.TextBox();
            this.num_pasport_textBox = new System.Windows.Forms.TextBox();
            this.birthday_date = new System.Windows.Forms.DateTimePicker();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // privilegie_comboBox
            // 
            this.privilegie_comboBox.FormattingEnabled = true;
            this.privilegie_comboBox.Items.AddRange(new object[] {
            "Дитина - сирота",
            "учасник бойових дій(АТО)",
            "Інвалідність",
            "Військовослужбовець"});
            this.privilegie_comboBox.Location = new System.Drawing.Point(175, 312);
            this.privilegie_comboBox.Name = "privilegie_comboBox";
            this.privilegie_comboBox.Size = new System.Drawing.Size(219, 21);
            this.privilegie_comboBox.TabIndex = 63;
            this.privilegie_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.privilegie_comboBox_KeyPress);
            // 
            // atestat_textBox
            // 
            this.atestat_textBox.Location = new System.Drawing.Point(175, 240);
            this.atestat_textBox.MaxLength = 10;
            this.atestat_textBox.Name = "atestat_textBox";
            this.atestat_textBox.Size = new System.Drawing.Size(219, 20);
            this.atestat_textBox.TabIndex = 62;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(25, 350);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 17);
            this.label15.TabIndex = 61;
            this.label15.Text = "Номер телефону";
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(175, 350);
            this.phone_textBox.MaxLength = 10;
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(219, 20);
            this.phone_textBox.TabIndex = 60;
            this.phone_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_textBox_KeyPress);
            // 
            // privilegie_checkBox
            // 
            this.privilegie_checkBox.AutoSize = true;
            this.privilegie_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privilegie_checkBox.Location = new System.Drawing.Point(175, 282);
            this.privilegie_checkBox.Name = "privilegie_checkBox";
            this.privilegie_checkBox.Size = new System.Drawing.Size(51, 21);
            this.privilegie_checkBox.TabIndex = 59;
            this.privilegie_checkBox.Text = "Так";
            this.privilegie_checkBox.UseVisualStyleBackColor = true;
            this.privilegie_checkBox.CheckedChanged += new System.EventHandler(this.privilegie_checkBox_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(25, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 58;
            this.label14.Text = "Тип пільг";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(25, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 17);
            this.label13.TabIndex = 57;
            this.label13.Text = "Місце народження";
            // 
            // city_textBox
            // 
            this.city_textBox.Location = new System.Drawing.Point(175, 165);
            this.city_textBox.Name = "city_textBox";
            this.city_textBox.Size = new System.Drawing.Size(219, 20);
            this.city_textBox.TabIndex = 56;
            this.city_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.city_textBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(439, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 17);
            this.label12.TabIndex = 55;
            this.label12.Text = "Бал за екзамен №2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(439, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "Бал за екзамен №1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(439, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 17);
            this.label10.TabIndex = 53;
            this.label10.Text = "Середній бал атестату";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(439, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Спеціальність №3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(439, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 51;
            this.label8.Text = "Спеціальність №2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(439, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Спеціальність №1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Пільги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Номер атестату";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Іденфікаційний код";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Номер паспорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Дата народження";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "ПІБ абітурієнта";
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.edit_button.FlatAppearance.BorderSize = 2;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_button.Location = new System.Drawing.Point(373, 414);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(176, 60);
            this.edit_button.TabIndex = 43;
            this.edit_button.Text = "Редагувати";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // exam1_textBox
            // 
            this.exam1_textBox.Location = new System.Drawing.Point(610, 203);
            this.exam1_textBox.Name = "exam1_textBox";
            this.exam1_textBox.Size = new System.Drawing.Size(219, 20);
            this.exam1_textBox.TabIndex = 42;
            this.exam1_textBox.TextChanged += new System.EventHandler(this.exam1_textBox_TextChanged);
            this.exam1_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exam1_textBox_KeyPress);
            // 
            // average_textBox
            // 
            this.average_textBox.Location = new System.Drawing.Point(610, 165);
            this.average_textBox.MaxLength = 4;
            this.average_textBox.Name = "average_textBox";
            this.average_textBox.Size = new System.Drawing.Size(219, 20);
            this.average_textBox.TabIndex = 41;
            this.average_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.average_textBox_KeyPress);
            // 
            // specialty_combobox3
            // 
            this.specialty_combobox3.FormattingEnabled = true;
            this.specialty_combobox3.Location = new System.Drawing.Point(610, 117);
            this.specialty_combobox3.Name = "specialty_combobox3";
            this.specialty_combobox3.Size = new System.Drawing.Size(219, 21);
            this.specialty_combobox3.TabIndex = 40;
            this.specialty_combobox3.SelectedIndexChanged += new System.EventHandler(this.specialty_combobox3_SelectedIndexChanged);
            this.specialty_combobox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.specialty_combobox3_KeyPress);
            // 
            // specialty_combobox2
            // 
            this.specialty_combobox2.FormattingEnabled = true;
            this.specialty_combobox2.Items.AddRange(new object[] {
            "Відсутня"});
            this.specialty_combobox2.Location = new System.Drawing.Point(610, 75);
            this.specialty_combobox2.Name = "specialty_combobox2";
            this.specialty_combobox2.Size = new System.Drawing.Size(219, 21);
            this.specialty_combobox2.TabIndex = 39;
            this.specialty_combobox2.SelectedIndexChanged += new System.EventHandler(this.specialty_combobox2_SelectedIndexChanged);
            this.specialty_combobox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.specialty_combobox2_KeyPress);
            // 
            // specialty_combobox1
            // 
            this.specialty_combobox1.FormattingEnabled = true;
            this.specialty_combobox1.Location = new System.Drawing.Point(610, 33);
            this.specialty_combobox1.Name = "specialty_combobox1";
            this.specialty_combobox1.Size = new System.Drawing.Size(219, 21);
            this.specialty_combobox1.TabIndex = 38;
            this.specialty_combobox1.SelectedIndexChanged += new System.EventHandler(this.specialty_combobox1_SelectedIndexChanged);
            this.specialty_combobox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.specialty_combobox1_KeyPress);
            // 
            // In_kode_textBox
            // 
            this.In_kode_textBox.Location = new System.Drawing.Point(175, 201);
            this.In_kode_textBox.MaxLength = 10;
            this.In_kode_textBox.Name = "In_kode_textBox";
            this.In_kode_textBox.Size = new System.Drawing.Size(219, 20);
            this.In_kode_textBox.TabIndex = 37;
            // 
            // exam2_textBox
            // 
            this.exam2_textBox.Location = new System.Drawing.Point(610, 242);
            this.exam2_textBox.Name = "exam2_textBox";
            this.exam2_textBox.Size = new System.Drawing.Size(219, 20);
            this.exam2_textBox.TabIndex = 36;
            this.exam2_textBox.TextChanged += new System.EventHandler(this.exam2_textBox_TextChanged);
            this.exam2_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exam2_textBox_KeyPress);
            // 
            // num_pasport_textBox
            // 
            this.num_pasport_textBox.Location = new System.Drawing.Point(175, 117);
            this.num_pasport_textBox.MaxLength = 10;
            this.num_pasport_textBox.Name = "num_pasport_textBox";
            this.num_pasport_textBox.Size = new System.Drawing.Size(219, 20);
            this.num_pasport_textBox.TabIndex = 35;
            this.num_pasport_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_pasport_textBox_KeyPress);
            // 
            // birthday_date
            // 
            this.birthday_date.CustomFormat = "dd.MM.yyyy";
            this.birthday_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthday_date.Location = new System.Drawing.Point(175, 75);
            this.birthday_date.Name = "birthday_date";
            this.birthday_date.Size = new System.Drawing.Size(219, 20);
            this.birthday_date.TabIndex = 34;
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(175, 34);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(219, 20);
            this.Name_textbox.TabIndex = 33;
            this.Name_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_textbox_KeyPress);
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(854, 502);
            this.Controls.Add(this.privilegie_comboBox);
            this.Controls.Add(this.atestat_textBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.privilegie_checkBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.city_textBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.exam1_textBox);
            this.Controls.Add(this.average_textBox);
            this.Controls.Add(this.specialty_combobox3);
            this.Controls.Add(this.specialty_combobox2);
            this.Controls.Add(this.specialty_combobox1);
            this.Controls.Add(this.In_kode_textBox);
            this.Controls.Add(this.exam2_textBox);
            this.Controls.Add(this.num_pasport_textBox);
            this.Controls.Add(this.birthday_date);
            this.Controls.Add(this.Name_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагування";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edit_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox privilegie_comboBox;
        private System.Windows.Forms.TextBox atestat_textBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.CheckBox privilegie_checkBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox city_textBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.TextBox exam1_textBox;
        private System.Windows.Forms.TextBox average_textBox;
        private System.Windows.Forms.ComboBox specialty_combobox3;
        private System.Windows.Forms.ComboBox specialty_combobox2;
        private System.Windows.Forms.ComboBox specialty_combobox1;
        private System.Windows.Forms.TextBox In_kode_textBox;
        private System.Windows.Forms.TextBox exam2_textBox;
        private System.Windows.Forms.TextBox num_pasport_textBox;
        private System.Windows.Forms.DateTimePicker birthday_date;
        private System.Windows.Forms.TextBox Name_textbox;
    }
}