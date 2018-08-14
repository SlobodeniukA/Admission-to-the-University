namespace Introduction
{
    partial class edit_specialty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_specialty));
            this.edit_button = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.edit_button.FlatAppearance.BorderSize = 2;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_button.Location = new System.Drawing.Point(153, 274);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(176, 60);
            this.edit_button.TabIndex = 30;
            this.edit_button.Text = "Редагувати";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(33, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Кількість місць для контрактників";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(33, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Кількість пільгових місць";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Кількість бюджетних місць";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Код спеціальності";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Повна назва спеціальності";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Абревіатура спеціальності";
            // 
            // kontract_textBox
            // 
            this.kontract_textBox.Location = new System.Drawing.Point(273, 225);
            this.kontract_textBox.Name = "kontract_textBox";
            this.kontract_textBox.Size = new System.Drawing.Size(172, 20);
            this.kontract_textBox.TabIndex = 24;
            this.kontract_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kontract_textBox_KeyPress);
            // 
            // privilegie_textBox
            // 
            this.privilegie_textBox.Location = new System.Drawing.Point(273, 187);
            this.privilegie_textBox.Name = "privilegie_textBox";
            this.privilegie_textBox.Size = new System.Drawing.Size(172, 20);
            this.privilegie_textBox.TabIndex = 23;
            this.privilegie_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.privilegie_textBox_KeyPress);
            // 
            // budget_textBox
            // 
            this.budget_textBox.Location = new System.Drawing.Point(273, 150);
            this.budget_textBox.Name = "budget_textBox";
            this.budget_textBox.Size = new System.Drawing.Size(172, 20);
            this.budget_textBox.TabIndex = 22;
            this.budget_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.budget_textBox_KeyPress);
            // 
            // code_textBox
            // 
            this.code_textBox.Location = new System.Drawing.Point(273, 114);
            this.code_textBox.Name = "code_textBox";
            this.code_textBox.Size = new System.Drawing.Size(172, 20);
            this.code_textBox.TabIndex = 21;
            this.code_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.code_textBox_KeyPress);
            // 
            // full_textBox
            // 
            this.full_textBox.Location = new System.Drawing.Point(273, 76);
            this.full_textBox.Name = "full_textBox";
            this.full_textBox.Size = new System.Drawing.Size(172, 20);
            this.full_textBox.TabIndex = 19;
            // 
            // ab_spec_textBox
            // 
            this.ab_spec_textBox.Location = new System.Drawing.Point(273, 35);
            this.ab_spec_textBox.Name = "ab_spec_textBox";
            this.ab_spec_textBox.Size = new System.Drawing.Size(172, 20);
            this.ab_spec_textBox.TabIndex = 18;
            this.ab_spec_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ab_spec_textBox_KeyPress);
            // 
            // edit_specialty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(485, 348);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kontract_textBox);
            this.Controls.Add(this.privilegie_textBox);
            this.Controls.Add(this.budget_textBox);
            this.Controls.Add(this.code_textBox);
            this.Controls.Add(this.full_textBox);
            this.Controls.Add(this.ab_spec_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "edit_specialty";
            this.Text = "Редагування спеціальності";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kontract_textBox;
        private System.Windows.Forms.TextBox privilegie_textBox;
        private System.Windows.Forms.TextBox budget_textBox;
        private System.Windows.Forms.TextBox code_textBox;
        private System.Windows.Forms.TextBox full_textBox;
        private System.Windows.Forms.TextBox ab_spec_textBox;
    }
}