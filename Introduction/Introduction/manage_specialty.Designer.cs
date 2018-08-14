namespace Introduction
{
    partial class manage_specialty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manage_specialty));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.del_textBox = new System.Windows.Forms.TextBox();
            this.del_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kontract_textBox = new System.Windows.Forms.TextBox();
            this.privilegie_textBox = new System.Windows.Forms.TextBox();
            this.budget_textBox = new System.Windows.Forms.TextBox();
            this.code_textBox = new System.Windows.Forms.TextBox();
            this.full_textBox = new System.Windows.Forms.TextBox();
            this.ab_spec_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.абревіатураспеціальностіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.повнаназваспеціальностіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодспеціальностіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьбюджетнихмісцьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьпільговихмісцьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьмісцьдляконтрактниківDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.спеціальностіBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.introductionDatabaseDataSet = new Introduction.IntroductionDatabaseDataSet();
            this.спеціальностіTableAdapter = new Introduction.IntroductionDatabaseDataSetTableAdapters.СпеціальностіTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спеціальностіBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.introductionDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.edit_button);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(this.del_textBox);
            this.panel1.Controls.Add(this.del_button);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.kontract_textBox);
            this.panel1.Controls.Add(this.privilegie_textBox);
            this.panel1.Controls.Add(this.budget_textBox);
            this.panel1.Controls.Add(this.code_textBox);
            this.panel1.Controls.Add(this.full_textBox);
            this.panel1.Controls.Add(this.ab_spec_textBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 316);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(473, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 34);
            this.label9.TabIndex = 20;
            this.label9.Text = "Введіть абревіатуру спеціальності, \r\nщоб видалити";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(451, 5);
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
            this.label8.Location = new System.Drawing.Point(464, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(338, 46);
            this.label8.TabIndex = 19;
            this.label8.Text = "═ ═ ═ ═ ═ ═ ═ ═ ═ ═ ═\r\n";
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.edit_button.FlatAppearance.BorderSize = 2;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_button.Location = new System.Drawing.Point(543, 235);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(176, 60);
            this.edit_button.TabIndex = 18;
            this.edit_button.Text = "Редагувати";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.add_button.FlatAppearance.BorderSize = 2;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(169, 245);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(176, 60);
            this.add_button.TabIndex = 17;
            this.add_button.Text = "Додати";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // del_textBox
            // 
            this.del_textBox.Location = new System.Drawing.Point(543, 57);
            this.del_textBox.Name = "del_textBox";
            this.del_textBox.Size = new System.Drawing.Size(172, 20);
            this.del_textBox.TabIndex = 16;
            this.del_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.del_textBox_KeyPress);
            // 
            // del_button
            // 
            this.del_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.del_button.FlatAppearance.BorderSize = 2;
            this.del_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_button.Location = new System.Drawing.Point(543, 98);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(176, 60);
            this.del_button.TabIndex = 11;
            this.del_button.Text = "Видалити";
            this.del_button.UseVisualStyleBackColor = false;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(24, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Кількість місць для контрактників";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Кількість пільгових місць";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Кількість бюджетних місць";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Код спеціальності";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Повна назва спеціальності";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Абревіатура спеціальності";
            // 
            // kontract_textBox
            // 
            this.kontract_textBox.Location = new System.Drawing.Point(264, 209);
            this.kontract_textBox.MaxLength = 3;
            this.kontract_textBox.Name = "kontract_textBox";
            this.kontract_textBox.Size = new System.Drawing.Size(172, 20);
            this.kontract_textBox.TabIndex = 5;
            this.kontract_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kontract_textBox_KeyPress);
            // 
            // privilegie_textBox
            // 
            this.privilegie_textBox.Location = new System.Drawing.Point(264, 171);
            this.privilegie_textBox.MaxLength = 3;
            this.privilegie_textBox.Name = "privilegie_textBox";
            this.privilegie_textBox.Size = new System.Drawing.Size(172, 20);
            this.privilegie_textBox.TabIndex = 4;
            this.privilegie_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.privilegie_textBox_KeyPress);
            // 
            // budget_textBox
            // 
            this.budget_textBox.Location = new System.Drawing.Point(264, 134);
            this.budget_textBox.MaxLength = 3;
            this.budget_textBox.Name = "budget_textBox";
            this.budget_textBox.Size = new System.Drawing.Size(172, 20);
            this.budget_textBox.TabIndex = 3;
            this.budget_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.budget_textBox_KeyPress);
            // 
            // code_textBox
            // 
            this.code_textBox.Location = new System.Drawing.Point(264, 98);
            this.code_textBox.MaxLength = 8;
            this.code_textBox.Name = "code_textBox";
            this.code_textBox.Size = new System.Drawing.Size(172, 20);
            this.code_textBox.TabIndex = 2;
            this.code_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.code_textBox_KeyPress);
            // 
            // full_textBox
            // 
            this.full_textBox.Location = new System.Drawing.Point(264, 60);
            this.full_textBox.Name = "full_textBox";
            this.full_textBox.Size = new System.Drawing.Size(172, 20);
            this.full_textBox.TabIndex = 1;
            this.full_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.full_textBox_KeyPress);
            // 
            // ab_spec_textBox
            // 
            this.ab_spec_textBox.Location = new System.Drawing.Point(264, 19);
            this.ab_spec_textBox.MaxLength = 10;
            this.ab_spec_textBox.Name = "ab_spec_textBox";
            this.ab_spec_textBox.Size = new System.Drawing.Size(172, 20);
            this.ab_spec_textBox.TabIndex = 0;
            this.ab_spec_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ab_spec_textBox_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.абревіатураспеціальностіDataGridViewTextBoxColumn,
            this.повнаназваспеціальностіDataGridViewTextBoxColumn,
            this.кодспеціальностіDataGridViewTextBoxColumn,
            this.кількістьбюджетнихмісцьDataGridViewTextBoxColumn,
            this.кількістьпільговихмісцьDataGridViewTextBoxColumn,
            this.кількістьмісцьдляконтрактниківDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.спеціальностіBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(765, 256);
            this.dataGridView1.TabIndex = 1;
            // 
            // абревіатураспеціальностіDataGridViewTextBoxColumn
            // 
            this.абревіатураспеціальностіDataGridViewTextBoxColumn.DataPropertyName = "Абревіатура_спеціальності";
            this.абревіатураспеціальностіDataGridViewTextBoxColumn.HeaderText = "Абревіатура_спеціальності";
            this.абревіатураспеціальностіDataGridViewTextBoxColumn.Name = "абревіатураспеціальностіDataGridViewTextBoxColumn";
            this.абревіатураспеціальностіDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // повнаназваспеціальностіDataGridViewTextBoxColumn
            // 
            this.повнаназваспеціальностіDataGridViewTextBoxColumn.DataPropertyName = "Повна_назва_спеціальності";
            this.повнаназваспеціальностіDataGridViewTextBoxColumn.HeaderText = "Повна_назва_спеціальності";
            this.повнаназваспеціальностіDataGridViewTextBoxColumn.Name = "повнаназваспеціальностіDataGridViewTextBoxColumn";
            this.повнаназваспеціальностіDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодспеціальностіDataGridViewTextBoxColumn
            // 
            this.кодспеціальностіDataGridViewTextBoxColumn.DataPropertyName = "Код_спеціальності";
            this.кодспеціальностіDataGridViewTextBoxColumn.HeaderText = "Код_спеціальності";
            this.кодспеціальностіDataGridViewTextBoxColumn.Name = "кодспеціальностіDataGridViewTextBoxColumn";
            this.кодспеціальностіDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кількістьбюджетнихмісцьDataGridViewTextBoxColumn
            // 
            this.кількістьбюджетнихмісцьDataGridViewTextBoxColumn.DataPropertyName = "Кількість_бюджетних_місць";
            this.кількістьбюджетнихмісцьDataGridViewTextBoxColumn.HeaderText = "Кількість_бюджетних_місць";
            this.кількістьбюджетнихмісцьDataGridViewTextBoxColumn.Name = "кількістьбюджетнихмісцьDataGridViewTextBoxColumn";
            this.кількістьбюджетнихмісцьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кількістьпільговихмісцьDataGridViewTextBoxColumn
            // 
            this.кількістьпільговихмісцьDataGridViewTextBoxColumn.DataPropertyName = "Кількість_пільгових_місць";
            this.кількістьпільговихмісцьDataGridViewTextBoxColumn.HeaderText = "Кількість_пільгових_місць";
            this.кількістьпільговихмісцьDataGridViewTextBoxColumn.Name = "кількістьпільговихмісцьDataGridViewTextBoxColumn";
            this.кількістьпільговихмісцьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кількістьмісцьдляконтрактниківDataGridViewTextBoxColumn
            // 
            this.кількістьмісцьдляконтрактниківDataGridViewTextBoxColumn.DataPropertyName = "Кількість_місць_для_контрактників";
            this.кількістьмісцьдляконтрактниківDataGridViewTextBoxColumn.HeaderText = "Кількість_місць_для_контрактників";
            this.кількістьмісцьдляконтрактниківDataGridViewTextBoxColumn.Name = "кількістьмісцьдляконтрактниківDataGridViewTextBoxColumn";
            this.кількістьмісцьдляконтрактниківDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // спеціальностіBindingSource
            // 
            this.спеціальностіBindingSource.DataMember = "Спеціальності";
            this.спеціальностіBindingSource.DataSource = this.introductionDatabaseDataSet;
            // 
            // introductionDatabaseDataSet
            // 
            this.introductionDatabaseDataSet.DataSetName = "IntroductionDatabaseDataSet";
            this.introductionDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // спеціальностіTableAdapter
            // 
            this.спеціальностіTableAdapter.ClearBeforeFill = true;
            // 
            // manage_specialty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(765, 572);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "manage_specialty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управління спеціальностями";
            this.Load += new System.EventHandler(this.manage_specialty_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спеціальностіBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.introductionDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ab_spec_textBox;
        private System.Windows.Forms.TextBox kontract_textBox;
        private System.Windows.Forms.TextBox privilegie_textBox;
        private System.Windows.Forms.TextBox code_textBox;
        private System.Windows.Forms.TextBox full_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IntroductionDatabaseDataSet introductionDatabaseDataSet;
        private System.Windows.Forms.BindingSource спеціальностіBindingSource;
        private IntroductionDatabaseDataSetTableAdapters.СпеціальностіTableAdapter спеціальностіTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn абревіатураспеціальностіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn повнаназваспеціальностіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодспеціальностіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьбюджетнихмісцьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьпільговихмісцьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьмісцьдляконтрактниківDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox del_textBox;
        private System.Windows.Forms.TextBox budget_textBox;
        private System.Windows.Forms.Label label9;
    }
}