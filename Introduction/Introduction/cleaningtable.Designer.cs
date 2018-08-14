namespace Introduction
{
    partial class cleaning_table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cleaning_table));
            this.clean_button = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // clean_button
            // 
            this.clean_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clean_button.FlatAppearance.BorderSize = 2;
            this.clean_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clean_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clean_button.Location = new System.Drawing.Point(30, 125);
            this.clean_button.Name = "clean_button";
            this.clean_button.Size = new System.Drawing.Size(281, 153);
            this.clean_button.TabIndex = 10;
            this.clean_button.Text = "Видалити всі дані з таблиці \'Абітурієнти\'";
            this.clean_button.UseVisualStyleBackColor = false;
            this.clean_button.Click += new System.EventHandler(this.clean_button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(14, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(332, 64);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = " Натистувши на кнопку \r\n\"Видалити всі дані з таблиці \'Абітурієнти\'\"\r\n Ви видалите" +
    " всі дані без можливості їх повернення!\r\n Ви впевнені, що хочете це зробити?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cleaning_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(355, 312);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.clean_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cleaning_table";
            this.Text = "Повне очищення таблиці";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clean_button;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}