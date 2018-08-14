namespace Introduction
{
    partial class change_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_password));
            this.change_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Password1_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.old_password_textbox = new System.Windows.Forms.TextBox();
            this.Login_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password2_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // change_button
            // 
            this.change_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.change_button.FlatAppearance.BorderSize = 2;
            this.change_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_button.Location = new System.Drawing.Point(31, 331);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(276, 53);
            this.change_button.TabIndex = 21;
            this.change_button.Text = "Змінити пароль";
            this.change_button.UseVisualStyleBackColor = false;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Новий пароль";
            // 
            // Password1_textbox
            // 
            this.Password1_textbox.Location = new System.Drawing.Point(110, 213);
            this.Password1_textbox.Name = "Password1_textbox";
            this.Password1_textbox.PasswordChar = '*';
            this.Password1_textbox.Size = new System.Drawing.Size(197, 20);
            this.Password1_textbox.TabIndex = 19;
            this.Password1_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password1_textbox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Старий пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Логін";
            // 
            // old_password_textbox
            // 
            this.old_password_textbox.Location = new System.Drawing.Point(110, 140);
            this.old_password_textbox.Name = "old_password_textbox";
            this.old_password_textbox.PasswordChar = '*';
            this.old_password_textbox.Size = new System.Drawing.Size(197, 20);
            this.old_password_textbox.TabIndex = 16;
            this.old_password_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.old_password_textbox_KeyPress);
            // 
            // Login_textbox
            // 
            this.Login_textbox.Location = new System.Drawing.Point(110, 70);
            this.Login_textbox.Name = "Login_textbox";
            this.Login_textbox.Size = new System.Drawing.Size(197, 20);
            this.Login_textbox.TabIndex = 15;
            this.Login_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_textbox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Повторіть новий пароль";
            // 
            // Password2_textbox
            // 
            this.Password2_textbox.Location = new System.Drawing.Point(110, 289);
            this.Password2_textbox.Name = "Password2_textbox";
            this.Password2_textbox.PasswordChar = '*';
            this.Password2_textbox.Size = new System.Drawing.Size(197, 20);
            this.Password2_textbox.TabIndex = 22;
            // 
            // change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(352, 404);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password2_textbox);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password1_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.old_password_textbox);
            this.Controls.Add(this.Login_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "change_password";
            this.Text = "Зміна паролю";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.change_password_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password1_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox old_password_textbox;
        private System.Windows.Forms.TextBox Login_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password2_textbox;
    }
}