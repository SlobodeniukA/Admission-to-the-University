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
    public partial class Regestration : Form
    {
        SqlConnection connect_sql;
        public Regestration(SqlConnection transfer_sql)
        {
            InitializeComponent();
            connect_sql = transfer_sql;
        }
        private void SingUp_button_Click(object sender, EventArgs e)
        {
            if (Login_textbox.Text.Length == 0 || Password1_textbox.Text.Length == 0 || Password2_textbox.Text.Length == 0)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Password1_textbox.Text.Length != 0 && Password2_textbox.Text.Length != 0 && Password1_textbox.Text !=  Password2_textbox.Text)
            {
                Password1_textbox.Clear();
                Password2_textbox.Clear();
                MessageBox.Show("Повториний пароль не співпадає з паролем!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if ( Login_textbox.Text.Length != 0 && Password1_textbox.Text.Length != 0 && Password2_textbox.Text.Length != 0 && Password1_textbox.Text == Password2_textbox.Text)
            {
                    SqlCommand command_sql = connect_sql.CreateCommand();
                    command_sql.CommandType = CommandType.Text;
                    command_sql.CommandText = "SELECT COUNT(*) FROM Таблиця_входу WHERE Логін = '" + Login_textbox.Text + "'and Пароль =  '" + Password1_textbox.Text + "';";
                    command_sql.ExecuteNonQuery();
                    string res = command_sql.ExecuteScalar().ToString();

                    int count = Convert.ToInt32(res);


                    if (count == 1)
                    {
                        MessageBox.Show("Логін - " + Login_textbox.Text + "зайнятий\n Оберіть новий логін!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Login_textbox.Clear();
                        Password1_textbox.Clear();
                        Password2_textbox.Clear();
                    }
                    else
                    { 
                        command_sql.CommandText = "INSERT INTO Таблиця_входу ([Логін], [Пароль], [Рівень_доступу]) VALUES" + "(N'" + Login_textbox.Text + "', N'" + Password1_textbox.Text + "', N'" + "Низький" + "')";
                        command_sql.ExecuteNonQuery();
                        MessageBox.Show("Користувач - '" + Login_textbox.Text + "' зареєстрований в системі!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
        }
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
        }
        private void Password1_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && (l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }
        private void Password2_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && (l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
