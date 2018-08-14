namespace Introduction
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh_button = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.find_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.find_textBox = new System.Windows.Forms.TextBox();
            this.find_comboBox = new System.Windows.Forms.ComboBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.del_textBox = new System.Windows.Forms.TextBox();
            this.del_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пІБDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датанародженняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерпаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.місценародженняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.іденфікаційнийкодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номератестатуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пільгиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типпільгDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.спеціальність1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.спеціальність2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.спеціальність3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.середнійбалатестатуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.балзаекзамен1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.балзаекзамен2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рейтигновийбалвступуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.абітурієнтBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.introductionDatabaseDataSet = new Introduction.IntroductionDatabaseDataSet();
            this.абітурієнтTableAdapter = new Introduction.IntroductionDatabaseDataSetTableAdapters.АбітурієнтTableAdapter();
            this.ADD_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.абітурієнтBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.introductionDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ADD_button);
            this.panel1.Controls.Add(this.refresh_button);
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.find_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.find_textBox);
            this.panel1.Controls.Add(this.find_comboBox);
            this.panel1.Controls.Add(this.edit_btn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.del_textBox);
            this.panel1.Controls.Add(this.del_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 136);
            this.panel1.TabIndex = 0;
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.refresh_button.FlatAppearance.BorderSize = 2;
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh_button.Location = new System.Drawing.Point(830, 75);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(211, 48);
            this.refresh_button.TabIndex = 21;
            this.refresh_button.Text = "Оновити";
            this.refresh_button.UseVisualStyleBackColor = false;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exit_btn.FlatAppearance.BorderSize = 2;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_btn.Location = new System.Drawing.Point(1112, 45);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(211, 48);
            this.exit_btn.TabIndex = 20;
            this.exit_btn.Text = "Вийти";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // find_button
            // 
            this.find_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.find_button.FlatAppearance.BorderSize = 2;
            this.find_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_button.Location = new System.Drawing.Point(830, 15);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(211, 48);
            this.find_button.TabIndex = 19;
            this.find_button.Text = "Фільтрувати";
            this.find_button.UseVisualStyleBackColor = false;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1059, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 120);
            this.label1.TabIndex = 18;
            this.label1.Text = "||\r\n||\r\n||\r\n||\r\n||\r\n||";
            // 
            // find_textBox
            // 
            this.find_textBox.Location = new System.Drawing.Point(590, 87);
            this.find_textBox.Name = "find_textBox";
            this.find_textBox.Size = new System.Drawing.Size(211, 26);
            this.find_textBox.TabIndex = 17;
            this.find_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.find_textBox_KeyPress);
            // 
            // find_comboBox
            // 
            this.find_comboBox.FormattingEnabled = true;
            this.find_comboBox.Items.AddRange(new object[] {
            "ПІБ",
            "Номер паспорту",
            "Ідентифікаційний код",
            "Атестат",
            "Спеціальність",
            "Місце народження",
            "Номер телефону"});
            this.find_comboBox.Location = new System.Drawing.Point(590, 25);
            this.find_comboBox.Name = "find_comboBox";
            this.find_comboBox.Size = new System.Drawing.Size(211, 28);
            this.find_comboBox.TabIndex = 16;
            this.find_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.find_comboBox_KeyPress);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.edit_btn.FlatAppearance.BorderSize = 2;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_btn.Location = new System.Drawing.Point(312, 75);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(211, 48);
            this.edit_btn.TabIndex = 15;
            this.edit_btn.Text = "Редагувати";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(547, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 120);
            this.label3.TabIndex = 14;
            this.label3.Text = "||\r\n||\r\n||\r\n||\r\n||\r\n||";
            // 
            // del_textBox
            // 
            this.del_textBox.Location = new System.Drawing.Point(33, 37);
            this.del_textBox.Name = "del_textBox";
            this.del_textBox.Size = new System.Drawing.Size(211, 26);
            this.del_textBox.TabIndex = 13;
            this.del_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.del_textBox_KeyPress);
            // 
            // del_button
            // 
            this.del_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.del_button.FlatAppearance.BorderSize = 2;
            this.del_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_button.Location = new System.Drawing.Point(33, 77);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(211, 48);
            this.del_button.TabIndex = 12;
            this.del_button.Text = "Видалити";
            this.del_button.UseVisualStyleBackColor = false;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(269, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 120);
            this.label2.TabIndex = 11;
            this.label2.Text = "||\r\n||\r\n||\r\n||\r\n||\r\n||";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.пІБDataGridViewTextBoxColumn,
            this.датанародженняDataGridViewTextBoxColumn,
            this.номерпаспортаDataGridViewTextBoxColumn,
            this.місценародженняDataGridViewTextBoxColumn,
            this.іденфікаційнийкодDataGridViewTextBoxColumn,
            this.номератестатуDataGridViewTextBoxColumn,
            this.пільгиDataGridViewTextBoxColumn,
            this.типпільгDataGridViewTextBoxColumn,
            this.номертелефонуDataGridViewTextBoxColumn,
            this.спеціальність1DataGridViewTextBoxColumn,
            this.спеціальність2DataGridViewTextBoxColumn,
            this.спеціальність3DataGridViewTextBoxColumn,
            this.середнійбалатестатуDataGridViewTextBoxColumn,
            this.балзаекзамен1DataGridViewTextBoxColumn,
            this.балзаекзамен2DataGridViewTextBoxColumn,
            this.рейтигновийбалвступуDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.абітурієнтBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1370, 412);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // пІБDataGridViewTextBoxColumn
            // 
            this.пІБDataGridViewTextBoxColumn.DataPropertyName = "ПІБ";
            this.пІБDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.пІБDataGridViewTextBoxColumn.Name = "пІБDataGridViewTextBoxColumn";
            this.пІБDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датанародженняDataGridViewTextBoxColumn
            // 
            this.датанародженняDataGridViewTextBoxColumn.DataPropertyName = "Дата_народження";
            this.датанародженняDataGridViewTextBoxColumn.HeaderText = "Дата_народження";
            this.датанародженняDataGridViewTextBoxColumn.Name = "датанародженняDataGridViewTextBoxColumn";
            this.датанародженняDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерпаспортаDataGridViewTextBoxColumn
            // 
            this.номерпаспортаDataGridViewTextBoxColumn.DataPropertyName = "Номер_паспорта";
            this.номерпаспортаDataGridViewTextBoxColumn.HeaderText = "Номер_паспорта";
            this.номерпаспортаDataGridViewTextBoxColumn.Name = "номерпаспортаDataGridViewTextBoxColumn";
            this.номерпаспортаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // місценародженняDataGridViewTextBoxColumn
            // 
            this.місценародженняDataGridViewTextBoxColumn.DataPropertyName = "Місце_народження";
            this.місценародженняDataGridViewTextBoxColumn.HeaderText = "Місце_народження";
            this.місценародженняDataGridViewTextBoxColumn.Name = "місценародженняDataGridViewTextBoxColumn";
            this.місценародженняDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // іденфікаційнийкодDataGridViewTextBoxColumn
            // 
            this.іденфікаційнийкодDataGridViewTextBoxColumn.DataPropertyName = "Іденфікаційний_код";
            this.іденфікаційнийкодDataGridViewTextBoxColumn.HeaderText = "Іденфікаційний_код";
            this.іденфікаційнийкодDataGridViewTextBoxColumn.Name = "іденфікаційнийкодDataGridViewTextBoxColumn";
            this.іденфікаційнийкодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номератестатуDataGridViewTextBoxColumn
            // 
            this.номератестатуDataGridViewTextBoxColumn.DataPropertyName = "Номер_атестату";
            this.номератестатуDataGridViewTextBoxColumn.HeaderText = "Номер_атестату";
            this.номератестатуDataGridViewTextBoxColumn.Name = "номератестатуDataGridViewTextBoxColumn";
            this.номератестатуDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // пільгиDataGridViewTextBoxColumn
            // 
            this.пільгиDataGridViewTextBoxColumn.DataPropertyName = "Пільги";
            this.пільгиDataGridViewTextBoxColumn.HeaderText = "Пільги";
            this.пільгиDataGridViewTextBoxColumn.Name = "пільгиDataGridViewTextBoxColumn";
            this.пільгиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // типпільгDataGridViewTextBoxColumn
            // 
            this.типпільгDataGridViewTextBoxColumn.DataPropertyName = "Тип_пільг";
            this.типпільгDataGridViewTextBoxColumn.HeaderText = "Тип_пільг";
            this.типпільгDataGridViewTextBoxColumn.Name = "типпільгDataGridViewTextBoxColumn";
            this.типпільгDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номертелефонуDataGridViewTextBoxColumn
            // 
            this.номертелефонуDataGridViewTextBoxColumn.DataPropertyName = "Номер_телефону";
            this.номертелефонуDataGridViewTextBoxColumn.HeaderText = "Номер_телефону";
            this.номертелефонуDataGridViewTextBoxColumn.Name = "номертелефонуDataGridViewTextBoxColumn";
            this.номертелефонуDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // спеціальність1DataGridViewTextBoxColumn
            // 
            this.спеціальність1DataGridViewTextBoxColumn.DataPropertyName = "Спеціальність №1";
            this.спеціальність1DataGridViewTextBoxColumn.HeaderText = "Спеціальність №1";
            this.спеціальність1DataGridViewTextBoxColumn.Name = "спеціальність1DataGridViewTextBoxColumn";
            this.спеціальність1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // спеціальність2DataGridViewTextBoxColumn
            // 
            this.спеціальність2DataGridViewTextBoxColumn.DataPropertyName = "Спеціальність №2";
            this.спеціальність2DataGridViewTextBoxColumn.HeaderText = "Спеціальність №2";
            this.спеціальність2DataGridViewTextBoxColumn.Name = "спеціальність2DataGridViewTextBoxColumn";
            this.спеціальність2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // спеціальність3DataGridViewTextBoxColumn
            // 
            this.спеціальність3DataGridViewTextBoxColumn.DataPropertyName = "Спеціальність №3";
            this.спеціальність3DataGridViewTextBoxColumn.HeaderText = "Спеціальність №3";
            this.спеціальність3DataGridViewTextBoxColumn.Name = "спеціальність3DataGridViewTextBoxColumn";
            this.спеціальність3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // середнійбалатестатуDataGridViewTextBoxColumn
            // 
            this.середнійбалатестатуDataGridViewTextBoxColumn.DataPropertyName = "Середній_бал_атестату";
            this.середнійбалатестатуDataGridViewTextBoxColumn.HeaderText = "Середній_бал_атестату";
            this.середнійбалатестатуDataGridViewTextBoxColumn.Name = "середнійбалатестатуDataGridViewTextBoxColumn";
            this.середнійбалатестатуDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // балзаекзамен1DataGridViewTextBoxColumn
            // 
            this.балзаекзамен1DataGridViewTextBoxColumn.DataPropertyName = "Бал_за_екзамен_№1";
            this.балзаекзамен1DataGridViewTextBoxColumn.HeaderText = "Бал_за_екзамен_№1";
            this.балзаекзамен1DataGridViewTextBoxColumn.Name = "балзаекзамен1DataGridViewTextBoxColumn";
            this.балзаекзамен1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // балзаекзамен2DataGridViewTextBoxColumn
            // 
            this.балзаекзамен2DataGridViewTextBoxColumn.DataPropertyName = "Бал_за_екзамен_№2";
            this.балзаекзамен2DataGridViewTextBoxColumn.HeaderText = "Бал_за_екзамен_№2";
            this.балзаекзамен2DataGridViewTextBoxColumn.Name = "балзаекзамен2DataGridViewTextBoxColumn";
            this.балзаекзамен2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // рейтигновийбалвступуDataGridViewTextBoxColumn
            // 
            this.рейтигновийбалвступуDataGridViewTextBoxColumn.DataPropertyName = "Рейтигновий_бал_вступу";
            this.рейтигновийбалвступуDataGridViewTextBoxColumn.HeaderText = "Рейтигновий_бал_вступу";
            this.рейтигновийбалвступуDataGridViewTextBoxColumn.Name = "рейтигновийбалвступуDataGridViewTextBoxColumn";
            this.рейтигновийбалвступуDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // абітурієнтBindingSource
            // 
            this.абітурієнтBindingSource.DataMember = "Абітурієнт";
            this.абітурієнтBindingSource.DataSource = this.introductionDatabaseDataSet;
            // 
            // introductionDatabaseDataSet
            // 
            this.introductionDatabaseDataSet.DataSetName = "IntroductionDatabaseDataSet";
            this.introductionDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // абітурієнтTableAdapter
            // 
            this.абітурієнтTableAdapter.ClearBeforeFill = true;
            // 
            // ADD_button
            // 
            this.ADD_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ADD_button.FlatAppearance.BorderSize = 2;
            this.ADD_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADD_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ADD_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ADD_button.Location = new System.Drawing.Point(312, 14);
            this.ADD_button.Name = "ADD_button";
            this.ADD_button.Size = new System.Drawing.Size(211, 49);
            this.ADD_button.TabIndex = 22;
            this.ADD_button.Text = "Додати абітурієнта";
            this.ADD_button.UseVisualStyleBackColor = false;
            this.ADD_button.Click += new System.EventHandler(this.ADD_button_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Введіть ID абітурієнта";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1370, 548);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Управління абітурієнтами";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.абітурієнтBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.introductionDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox del_textBox;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Label label3;
        private IntroductionDatabaseDataSet introductionDatabaseDataSet;
        private System.Windows.Forms.BindingSource абітурієнтBindingSource;
        private IntroductionDatabaseDataSetTableAdapters.АбітурієнтTableAdapter абітурієнтTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пІБDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датанародженняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерпаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn місценародженняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn іденфікаційнийкодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номератестатуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пільгиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типпільгDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn спеціальність1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn спеціальність2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn спеціальність3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn середнійбалатестатуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn балзаекзамен1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn балзаекзамен2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рейтигновийбалвступуDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox find_comboBox;
        private System.Windows.Forms.TextBox find_textBox;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button ADD_button;
        private System.Windows.Forms.Label label4;
    }
}