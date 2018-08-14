using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Introduction
{
    public partial class change_password : Form
    {
        SqlConnection connect_sql;
        public change_password(SqlConnection transfer_sql, string name)
        {
            InitializeComponent();
            connect_sql = transfer_sql;
            Login_textbox.Text = name;
            Login_textbox.Enabled = false;
        }
        private void change_button_Click(object sender, EventArgs e)
        {
            if (Login_textbox.Text.Length == 0 || old_password_textbox.Text.Length == 0 || Password1_textbox.Text.Length == 0 || Password2_textbox.Text.Length == 0)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Password1_textbox.Text.Length != 0 && Password2_textbox.Text.Length != 0 && Password1_textbox.Text != Password2_textbox.Text)
            {
                Password1_textbox.Clear();
                Password2_textbox.Clear();
                MessageBox.Show("Повториний пароль не співпадає з паролем!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Password1_textbox.Text == Password2_textbox.Text)
            {
                string q = "SELECT COUNT(*) FROM [Таблиця_входу]  WHERE [Логін]  = N'" + Login_textbox.Text + "' and Пароль = N'" + old_password_textbox.Text + "' ;";
                SqlCommand command = new SqlCommand(q, connect_sql);
                object res = command.ExecuteScalar();
                int count = Convert.ToInt32(res);
                if (count == 1)
                {
                    q = "UPDATE  [Таблиця_входу]  SET Пароль = N'" + Password1_textbox.Text + "' WHERE [Логін]  = N'" + Login_textbox.Text + "' ;";
                    command = new SqlCommand(q, connect_sql);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Пароль успішно змінено", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ви ввели невірні дані в поле 'Старий пароль'", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Password1_textbox.Text = "";
                    Password2_textbox.Text = "";
                    old_password_textbox.Text = "";
                }
            }
            else
            MessageBox.Show("Поля 'Новий пароль' та 'Повторіть новий пароль' не співпадають ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Password1_textbox.Text = "";
            Password2_textbox.Text = "";
        }
        private void Login_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (Login_textbox.Text.Length < 2)
            {
                if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b')
                {
                    e.Handled = true;
                }
            }
            else if((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && (l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }
        private void old_password_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && (l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }
        private void Password1_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && (l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }
        private void change_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && (l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
