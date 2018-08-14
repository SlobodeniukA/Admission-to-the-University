namespace Introduction
{
    partial class Regestration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regestration));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Password1_textbox = new System.Windows.Forms.TextBox();
            this.Login_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Password2_textbox = new System.Windows.Forms.TextBox();
            this.SingUp_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Логін";
            // 
            // Password1_textbox
            // 
            this.Password1_textbox.Location = new System.Drawing.Point(57, 130);
            this.Password1_textbox.Name = "Password1_textbox";
            this.Password1_textbox.PasswordChar = '*';
            this.Password1_textbox.Size = new System.Drawing.Size(197, 20);
            this.Password1_textbox.TabIndex = 9;
            this.Password1_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password1_textbox_KeyPress);
            // 
            // Login_textbox
            // 
            this.Login_textbox.Location = new System.Drawing.Point(57, 62);
            this.Login_textbox.Name = "Login_textbox";
            this.Login_textbox.Size = new System.Drawing.Size(197, 20);
            this.Login_textbox.TabIndex = 8;
            this.Login_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_textbox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Повторіть пароль";
            // 
            // Password2_textbox
            // 
            this.Password2_textbox.Location = new System.Drawing.Point(57, 195);
            this.Password2_textbox.Name = "Password2_textbox";
            this.Password2_textbox.PasswordChar = '*';
            this.Password2_textbox.Size = new System.Drawing.Size(197, 20);
            this.Password2_textbox.TabIndex = 12;
            this.Password2_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password2_textbox_KeyPress);
            // 
            // SingUp_button
            // 
            this.SingUp_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SingUp_button.FlatAppearance.BorderSize = 2;
            this.SingUp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingUp_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingUp_button.Location = new System.Drawing.Point(17, 238);
            this.SingUp_button.Name = "SingUp_button";
            this.SingUp_button.Size = new System.Drawing.Size(237, 53);
            this.SingUp_button.TabIndex = 14;
            this.SingUp_button.Text = "Зареєструватися";
            this.SingUp_button.UseVisualStyleBackColor = false;
            this.SingUp_button.Click += new System.EventHandler(this.SingUp_button_Click);
            // 
            // Regestration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(278, 316);
            this.Controls.Add(this.SingUp_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password2_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password1_textbox);
            this.Controls.Add(this.Login_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Regestration";
            this.Text = "Реєстрація";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password1_textbox;
        private System.Windows.Forms.TextBox Login_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password2_textbox;
        private System.Windows.Forms.Button SingUp_button;
    }
}