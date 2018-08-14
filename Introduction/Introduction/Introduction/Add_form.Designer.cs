namespace Introduction
{
    partial class Add_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_form));
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.birthday_date = new System.Windows.Forms.DateTimePicker();
            this.num_pasport_textBox = new System.Windows.Forms.TextBox();
            this.exam2_textBox = new System.Windows.Forms.TextBox();
            this.In_kode_textBox = new System.Windows.Forms.TextBox();
            this.specialty_combobox1 = new System.Windows.Forms.ComboBox();
            this.specialty_combobox2 = new System.Windows.Forms.ComboBox();
            this.specialty_combobox3 = new System.Windows.Forms.ComboBox();
            this.average_textBox = new System.Windows.Forms.TextBox();
            this.exam1_textBox = new System.Windows.Forms.TextBox();
            this.ADD_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.city_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.privilegie_checkBox = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.atestat_textBox = new System.Windows.Forms.TextBox();
            this.privilegie_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(153, 38);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(219, 20);
            this.Name_textbox.TabIndex = 0;
            this.Name_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_textbox_KeyPress);
            // 
            // birthday_date
            // 
            this.birthday_date.CustomFormat = "dd.MM.yyyy";
            this.birthday_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthday_date.Location = new System.Drawing.Point(153, 79);
            this.birthday_date.Name = "birthday_date";
            this.birthday_date.Size = new System.Drawing.Size(219, 20);
            this.birthday_date.TabIndex = 1;
            // 
            // num_pasport_textBox
            // 
            this.num_pasport_textBox.Location = new System.Drawing.Point(153, 121);
            this.num_pasport_textBox.MaxLength = 10;
            this.num_pasport_textBox.Name = "num_pasport_textBox";
            this.num_pasport_textBox.Size = new System.Drawing.Size(219, 20);
            this.num_pasport_textBox.TabIndex = 2;
            this.num_pasport_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_pasport_textBox_KeyPress);
            // 
            // exam2_textBox
            // 
            this.exam2_textBox.Location = new System.Drawing.Point(588, 246);
            this.exam2_textBox.Name = "exam2_textBox";
            this.exam2_textBox.Size = new System.Drawing.Size(219, 20);
            this.exam2_textBox.TabIndex = 3;
            this.exam2_textBox.TextChanged += new System.EventHandler(this.exam2_textBox_TextChanged);
            this.exam2_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exam2_textBox_KeyPress);
            // 
            // In_kode_textBox
            // 
            this.In_kode_textBox.Location = new System.Drawing.Point(153, 205);
            this.In_kode_textBox.MaxLength = 10;
            this.In_kode_textBox.Name = "In_kode_textBox";
            this.In_kode_textBox.Size = new System.Drawing.Size(219, 20);
            this.In_kode_textBox.TabIndex = 4;
            this.In_kode_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.In_kode_textBox_KeyPress);
            // 
            // specialty_combobox1
            // 
            this.specialty_combobox1.FormattingEnabled = true;
            this.specialty_combobox1.Location = new System.Drawing.Point(588, 37);
            this.specialty_combobox1.Name = "specialty_combobox1";
            this.specialty_combobox1.Size = new System.Drawing.Size(219, 21);
            this.specialty_combobox1.TabIndex = 7;
            this.specialty_combobox1.SelectedIndexChanged += new System.EventHandler(this.specialty_combobox1_SelectedIndexChanged);
            this.specialty_combobox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.specialty_combobox1_KeyPress);
            // 
            // specialty_combobox2
            // 
            this.specialty_combobox2.FormattingEnabled = true;
            this.specialty_combobox2.Items.AddRange(new object[] {
            "Відсутня"});
            this.specialty_combobox2.Location = new System.Drawing.Point(588, 79);
            this.specialty_combobox2.Name = "specialty_combobox2";
            this.specialty_combobox2.Size = new System.Drawing.Size(219, 21);
            this.specialty_combobox2.TabIndex = 8;
            this.specialty_combobox2.SelectedIndexChanged += new System.EventHandler(this.specialty_combobox2_SelectedIndexChanged);
            this.specialty_combobox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.specialty_combobox2_KeyPress);
            // 
            // specialty_combobox3
            // 
            this.specialty_combobox3.FormattingEnabled = true;
            this.specialty_combobox3.Location = new System.Drawing.Point(588, 121);
            this.specialty_combobox3.Name = "specialty_combobox3";
            this.specialty_combobox3.Size = new System.Drawing.Size(219, 21);
            this.specialty_combobox3.TabIndex = 9;
            this.specialty_combobox3.SelectedIndexChanged += new System.EventHandler(this.specialty_combobox3_SelectedIndexChanged);
            this.specialty_combobox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.specialty_combobox3_KeyPress);
            // 
            // average_textBox
            // 
            this.average_textBox.Location = new System.Drawing.Point(588, 169);
            this.average_textBox.MaxLength = 4;
            this.average_textBox.Name = "average_textBox";
            this.average_textBox.Size = new System.Drawing.Size(219, 20);
            this.average_textBox.TabIndex = 10;
            this.average_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.average_textBox_KeyPress);
            // 
            // exam1_textBox
            // 
            this.exam1_textBox.Location = new System.Drawing.Point(588, 207);
            this.exam1_textBox.Name = "exam1_textBox";
            this.exam1_textBox.Size = new System.Drawing.Size(219, 20);
            this.exam1_textBox.TabIndex = 11;
            this.exam1_textBox.TextChanged += new System.EventHandler(this.exam1_textBox_TextChanged);
            this.exam1_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exam1_textBox_KeyPress);
            // 
            // ADD_button
            // 
            this.ADD_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ADD_button.FlatAppearance.BorderSize = 2;
            this.ADD_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADD_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADD_button.Location = new System.Drawing.Point(351, 413);
            this.ADD_button.Name = "ADD_button";
            this.ADD_button.Size = new System.Drawing.Size(176, 60);
            this.ADD_button.TabIndex = 12;
            this.ADD_button.Text = "Додати";
            this.ADD_button.UseVisualStyleBackColor = false;
            this.ADD_button.Click += new System.EventHandler(this.ADD_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ПІБ абітурієнта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Дата народження";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Номер паспорта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Іденфікаційний код";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Номер атестату";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Пільги";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(417, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Спеціальність №1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(417, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Спеціальність №2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(417, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Спеціальність №3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(417, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Середній бал атестату";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(417, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Бал за екзамен №1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(417, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Бал за екзамен №2";
            // 
            // city_textBox
            // 
            this.city_textBox.Location = new System.Drawing.Point(153, 169);
            this.city_textBox.Name = "city_textBox";
            this.city_textBox.Size = new System.Drawing.Size(219, 20);
            this.city_textBox.TabIndex = 25;
            this.city_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.city_textBox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(3, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Місце народження";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(3, 320);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Тип пільг";
            // 
            // privilegie_checkBox
            // 
            this.privilegie_checkBox.AutoSize = true;
            this.privilegie_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privilegie_checkBox.Location = new System.Drawing.Point(153, 286);
            this.privilegie_checkBox.Name = "privilegie_checkBox";
            this.privilegie_checkBox.Size = new System.Drawing.Size(51, 21);
            this.privilegie_checkBox.TabIndex = 28;
            this.privilegie_checkBox.Text = "Так";
            this.privilegie_checkBox.UseVisualStyleBackColor = true;
            this.privilegie_checkBox.CheckedChanged += new System.EventHandler(this.privilegie_checkBox_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(3, 354);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "Номер телефону";
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(153, 354);
            this.phone_textBox.MaxLength = 10;
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(219, 20);
            this.phone_textBox.TabIndex = 29;
            this.phone_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_textBox_KeyPress);
            // 
            // atestat_textBox
            // 
            this.atestat_textBox.Location = new System.Drawing.Point(153, 244);
            this.atestat_textBox.MaxLength = 10;
            this.atestat_textBox.Name = "atestat_textBox";
            this.atestat_textBox.Size = new System.Drawing.Size(219, 20);
            this.atestat_textBox.TabIndex = 31;
            this.atestat_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.atestat_textBox_KeyPress);
            // 
            // privilegie_comboBox
            // 
            this.privilegie_comboBox.FormattingEnabled = true;
            this.privilegie_comboBox.Items.AddRange(new object[] {
            "Дитина - сирота",
            "учасник бойових дій(АТО)",
            "Інвалідність",
            "Військовослужбовець"});
            this.privilegie_comboBox.Location = new System.Drawing.Point(153, 316);
            this.privilegie_comboBox.Name = "privilegie_comboBox";
            this.privilegie_comboBox.Size = new System.Drawing.Size(219, 21);
            this.privilegie_comboBox.TabIndex = 32;
            this.privilegie_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.privilegie_comboBox_KeyPress);
            // 
            // Add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(856, 485);
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
            this.Controls.Add(this.ADD_button);
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
            this.Name = "Add_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вікно додавання";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.DateTimePicker birthday_date;
        private System.Windows.Forms.TextBox num_pasport_textBox;
        private System.Windows.Forms.TextBox exam2_textBox;
        private System.Windows.Forms.TextBox In_kode_textBox;
        private System.Windows.Forms.ComboBox specialty_combobox1;
        private System.Windows.Forms.ComboBox specialty_combobox2;
        private System.Windows.Forms.ComboBox specialty_combobox3;
        private System.Windows.Forms.TextBox average_textBox;
        private System.Windows.Forms.TextBox exam1_textBox;
        private System.Windows.Forms.Button ADD_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox city_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox privilegie_checkBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox atestat_textBox;
        private System.Windows.Forms.ComboBox privilegie_comboBox;
    }
}