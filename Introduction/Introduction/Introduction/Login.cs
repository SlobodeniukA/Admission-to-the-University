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
using System.Threading;
namespace Introduction
{
    public partial class Login : Form
    {
        SqlConnection connect_sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + @"\IntroductionDatabase.mdf;Integrated Security=True");
        public Login()
        {
            Thread splash_thread = new Thread(new ThreadStart(SplashStart));
            splash_thread.Start();
            Thread.Sleep(5000);
            splash_thread.Abort();
            InitializeComponent();
            connect_sql.Open();
        }
        public void SplashStart()
        {
            Application.Run(new splash_screen());
        }
        private void Enter_button_Click(object sender, EventArgs e)
        {
            if (Guest_checkbox.Checked == true)
            {
                Add_form add = new Add_form(connect_sql);
                add.ShowDialog();
                Guest_checkbox.Checked = false;
            }
            else if (Guest_checkbox.Checked == false)
            {
                if (Login_textbox.Text.Length == 0 && Password_textbox.Text.Length != 0)
                {
                    MessageBox.Show("Поле 'Логін' не заповнено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Login_textbox.Text.Length != 0 && Password_textbox.Text.Length == 0)
                {
                    MessageBox.Show("Поле 'Пароль' не заповнено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Login_textbox.Text.Length == 0 && Password_textbox.Text.Length == 0)
                {
                    MessageBox.Show("Поля 'Логін' і 'Пароль' не заповнено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Password_textbox.Text.Length != 0 && Login_textbox.Text.Length != 0)
                {
                    SqlCommand command_sql = connect_sql.CreateCommand();
                    command_sql.CommandType = CommandType.Text;
                    string access;
                    command_sql.CommandText = "SELECT COUNT(*) FROM Таблиця_входу WHERE Логін = '" + Login_textbox.Text + "'and Пароль =  '" + Password_textbox.Text + "';";
                    command_sql.ExecuteNonQuery();
                    string res = command_sql.ExecuteScalar().ToString();
                    int count = Convert.ToInt32(res);
                    if (count == 1)
                    {
                        command_sql.CommandText = "SELECT Рівень_доступу FROM Таблиця_входу WHERE Логін = '" + Login_textbox.Text + "'and Пароль =  '" + Password_textbox.Text + "';";
                        access = command_sql.ExecuteScalar().ToString();
                        main_menu menu = new main_menu(connect_sql);
                        MainForm main = new MainForm(connect_sql);
                        Add_form add = new Add_form(connect_sql);
                        if (access == "Високий")
                        {
                            menu.enter_level(access);
                            main.enter_level(access);
                            menu.ShowDialog();
                        }
                        if (access == "Середній")
                        {
                            menu.enter_level(access);
                            main.enter_level(access);
                            menu.ShowDialog();
                        }
                        if (access == "Низький")
                        {
                            menu.enter_level(access);
                            main.enter_level(access);
                            add.ShowDialog();
                        }
                        Login_textbox.Clear();
                        Password_textbox.Clear();
                    }
                    else
                    {
                        Password_textbox.Clear();
                        MessageBox.Show("Невірний логін чи пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void SingUp_button_Click(object sender, EventArgs e)
        {
            Login_textbox.Clear();
            Password_textbox.Clear();
            Guest_checkbox.Checked = false;
            Regestration reg = new Regestration(connect_sql);
            reg.ShowDialog();
        }
        private void Exit_button_Click(object sender, EventArgs e)
        {
            connect_sql.Close();
            this.Close();
        }
        private void Guest_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Guest_checkbox.Checked == true)
            {
                Login_textbox.Clear();
                Password_textbox.Clear();
                Login_textbox.Enabled = false;
                Password_textbox.Enabled = false;
            }
            else
            {
                Login_textbox.Enabled = true;
                Password_textbox.Enabled = true;
            }
        }
        private void Login_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if(Login_textbox.Text.Length < 2)
            { 
                if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' )
                {
                    e.Handled = true;
                }
            }
             else if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && (l < '0' || l > '9') && l != '\b')
                e.Handled = true;
        }

        private void Password_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && (l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
