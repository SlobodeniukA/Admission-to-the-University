namespace Introduction
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Guest_checkbox = new System.Windows.Forms.CheckBox();
            this.Login_textbox = new System.Windows.Forms.TextBox();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Enter_button = new System.Windows.Forms.Button();
            this.SingUp_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Guest_checkbox
            // 
            this.Guest_checkbox.AutoSize = true;
            this.Guest_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.Guest_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Guest_checkbox.ForeColor = System.Drawing.Color.Black;
            this.Guest_checkbox.Location = new System.Drawing.Point(135, 144);
            this.Guest_checkbox.Name = "Guest_checkbox";
            this.Guest_checkbox.Size = new System.Drawing.Size(121, 21);
            this.Guest_checkbox.TabIndex = 0;
            this.Guest_checkbox.Text = "Увійти як гість";
            this.Guest_checkbox.UseVisualStyleBackColor = false;
            this.Guest_checkbox.CheckedChanged += new System.EventHandler(this.Guest_checkbox_CheckedChanged);
            // 
            // Login_textbox
            // 
            this.Login_textbox.Location = new System.Drawing.Point(135, 34);
            this.Login_textbox.Name = "Login_textbox";
            this.Login_textbox.Size = new System.Drawing.Size(197, 20);
            this.Login_textbox.TabIndex = 1;
            this.Login_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_textbox_KeyPress);
            // 
            // Password_textbox
            // 
            this.Password_textbox.Location = new System.Drawing.Point(135, 93);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.PasswordChar = '*';
            this.Password_textbox.Size = new System.Drawing.Size(197, 20);
            this.Password_textbox.TabIndex = 2;
            this.Password_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_textbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логін";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль";
            // 
            // Enter_button
            // 
            this.Enter_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Enter_button.FlatAppearance.BorderSize = 2;
            this.Enter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_button.Location = new System.Drawing.Point(19, 195);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(176, 60);
            this.Enter_button.TabIndex = 9;
            this.Enter_button.Text = "Увійти";
            this.Enter_button.UseVisualStyleBackColor = false;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // SingUp_button
            // 
            this.SingUp_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SingUp_button.FlatAppearance.BorderSize = 2;
            this.SingUp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingUp_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SingUp_button.Location = new System.Drawing.Point(206, 195);
            this.SingUp_button.Name = "SingUp_button";
            this.SingUp_button.Size = new System.Drawing.Size(175, 60);
            this.SingUp_button.TabIndex = 10;
            this.SingUp_button.Text = "Зареєструватися";
            this.SingUp_button.UseVisualStyleBackColor = false;
            this.SingUp_button.Click += new System.EventHandler(this.SingUp_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Exit_button.FlatAppearance.BorderSize = 2;
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(395, 195);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(175, 61);
            this.Exit_button.TabIndex = 11;
            this.Exit_button.Text = "Вийти";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(349, -45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(589, 266);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.SingUp_button);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.Login_textbox);
            this.Controls.Add(this.Guest_checkbox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Guest_checkbox;
        private System.Windows.Forms.TextBox Login_textbox;
        private System.Windows.Forms.TextBox Password_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Enter_button;
        private System.Windows.Forms.Button SingUp_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}