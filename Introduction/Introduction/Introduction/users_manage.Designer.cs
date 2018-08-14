namespace Introduction
{
    partial class users_manage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users_manage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pass_button = new System.Windows.Forms.Button();
            this.reg_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.change_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.del_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.логінDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рівеньдоступуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.таблицявходуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.introductionDatabaseDataSet = new Introduction.IntroductionDatabaseDataSet();
            this.таблиця_входуTableAdapter = new Introduction.IntroductionDatabaseDataSetTableAdapters.Таблиця_входуTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицявходуBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.introductionDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.name_textBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pass_button);
            this.panel1.Controls.Add(this.reg_button);
            this.panel1.Controls.Add(this.del_button);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.change_button);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.del_textBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 361);
            this.panel1.TabIndex = 1;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(175, 16);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(172, 20);
            this.name_textBox.TabIndex = 20;
            this.name_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Активний користувач :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 46);
            this.label2.TabIndex = 27;
            this.label2.Text = "═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═\r\n";
            // 
            // pass_button
            // 
            this.pass_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pass_button.FlatAppearance.BorderSize = 2;
            this.pass_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pass_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_button.Location = new System.Drawing.Point(266, 289);
            this.pass_button.Name = "pass_button";
            this.pass_button.Size = new System.Drawing.Size(176, 60);
            this.pass_button.TabIndex = 25;
            this.pass_button.Text = "Змінити пароль";
            this.pass_button.UseVisualStyleBackColor = false;
            this.pass_button.Click += new System.EventHandler(this.pass_button_Click);
            // 
            // reg_button
            // 
            this.reg_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reg_button.FlatAppearance.BorderSize = 2;
            this.reg_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_button.Location = new System.Drawing.Point(12, 289);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(176, 60);
            this.reg_button.TabIndex = 24;
            this.reg_button.Text = "Зареєструвати нового користувача";
            this.reg_button.UseVisualStyleBackColor = false;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // del_button
            // 
            this.del_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.del_button.FlatAppearance.BorderSize = 2;
            this.del_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_button.Location = new System.Drawing.Point(266, 177);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(176, 60);
            this.del_button.TabIndex = 11;
            this.del_button.Text = "Видалити";
            this.del_button.UseVisualStyleBackColor = false;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(127, 111);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 21);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Середній";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(68, 138);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 21);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Високий";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(11, 111);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 21);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Низький";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // change_button
            // 
            this.change_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.change_button.FlatAppearance.BorderSize = 2;
            this.change_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_button.Location = new System.Drawing.Point(11, 177);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(176, 60);
            this.change_button.TabIndex = 17;
            this.change_button.Text = "Змінити рівень доступу";
            this.change_button.UseVisualStyleBackColor = false;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(219, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 300);
            this.label7.TabIndex = 15;
            this.label7.Text = "||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(458, 46);
            this.label8.TabIndex = 19;
            this.label8.Text = "═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═\r\n";
            // 
            // del_textBox
            // 
            this.del_textBox.Location = new System.Drawing.Point(266, 124);
            this.del_textBox.Name = "del_textBox";
            this.del_textBox.Size = new System.Drawing.Size(176, 20);
            this.del_textBox.TabIndex = 16;
            this.del_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.del_textBox_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.логінDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn,
            this.рівеньдоступуDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.таблицявходуBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(465, 218);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // логінDataGridViewTextBoxColumn
            // 
            this.логінDataGridViewTextBoxColumn.DataPropertyName = "Логін";
            this.логінDataGridViewTextBoxColumn.HeaderText = "Логін";
            this.логінDataGridViewTextBoxColumn.Name = "логінDataGridViewTextBoxColumn";
            this.логінDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            this.парольDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // рівеньдоступуDataGridViewTextBoxColumn
            // 
            this.рівеньдоступуDataGridViewTextBoxColumn.DataPropertyName = "Рівень_доступу";
            this.рівеньдоступуDataGridViewTextBoxColumn.HeaderText = "Рівень_доступу";
            this.рівеньдоступуDataGridViewTextBoxColumn.Name = "рівеньдоступуDataGridViewTextBoxColumn";
            this.рівеньдоступуDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // таблицявходуBindingSource
            // 
            this.таблицявходуBindingSource.DataMember = "Таблиця_входу";
            this.таблицявходуBindingSource.DataSource = this.introductionDatabaseDataSet;
            // 
            // introductionDatabaseDataSet
            // 
            this.introductionDatabaseDataSet.DataSetName = "IntroductionDatabaseDataSet";
            this.introductionDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // таблиця_входуTableAdapter
            // 
            this.таблиця_входуTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(259, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Введіть логін, щоб видалити";
            // 
            // users_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(465, 579);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "users_manage";
            this.Text = "Управління користувачами";
            this.Load += new System.EventHandler(this.users_manage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицявходуBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.introductionDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.TextBox del_textBox;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IntroductionDatabaseDataSet introductionDatabaseDataSet;
        private System.Windows.Forms.BindingSource таблицявходуBindingSource;
        private IntroductionDatabaseDataSetTableAdapters.Таблиця_входуTableAdapter таблиця_входуTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn логінDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рівеньдоступуDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Button pass_button;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
    }
}