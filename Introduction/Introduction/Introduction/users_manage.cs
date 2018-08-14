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
    public partial class users_manage : Form
    {
        SqlConnection connect_sql;
        public users_manage(SqlConnection transfer_sql)
        {
            InitializeComponent();
            connect_sql = transfer_sql;
            name_textBox.Enabled = false;
            change_button.Enabled = false;
            del_textBox.Enabled = false;
            del_button.Enabled = false;
            reg_button.Enabled = true;
            pass_button.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            tab_refresh();
        }
        private void users_manage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'introductionDatabaseDataSet.Таблиця_входу' table. You can move, or remove it, as needed.
            this.таблиця_входуTableAdapter.Fill(this.introductionDatabaseDataSet.Таблиця_входу);
        }
        private void tab_refresh()
        {
            SqlCommand command = connect_sql.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Таблиця_входу";
            command.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(DT);
            dataGridView1.DataSource = DT;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1[0, row].Value.ToString();
            string q = "SELECT Логін FROM Таблиця_входу WHERE Логін = '" + id + "'";
            SqlCommand command = new SqlCommand(q, connect_sql);
            name_textBox.Text = command.ExecuteScalar().ToString();
            q = "SELECT Рівень_доступу FROM Таблиця_входу WHERE Логін = '" + id + "'";
            command = new SqlCommand(q, connect_sql);
            string access = command.ExecuteScalar().ToString();
            if (access == radioButton1.Text)
            {
                radioButton1.Checked = true;
            }
            else if (access == radioButton2.Text)
            {
                radioButton2.Checked = true;
            }
            else if (access == radioButton3.Text)
            {
                radioButton3.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }

        }
        private void change_button_Click(object sender, EventArgs e)
        {
            string q;
            SqlCommand command;

            if (name_textBox.Text != "programmer")
            {
                if (name_textBox.Text.Length != 0)
                {
                    if (radioButton1.Checked == true)
                    {
                        q = "Update Таблиця_входу Set Рівень_доступу = N'" + radioButton1.Text + "' Where Логін = N'" + name_textBox.Text + "';";
                        command = new SqlCommand(q, connect_sql);
                        command.ExecuteNonQuery();
                    }
                    else if (radioButton2.Checked == true)
                    {
                        q = "Update Таблиця_входу Set Рівень_доступу = N'" + radioButton2.Text + "' Where Логін = N'" + name_textBox.Text + "';";
                        command = new SqlCommand(q, connect_sql);
                        command.ExecuteNonQuery();
                    }

                    else if (radioButton3.Checked == true)
                    {
                        q = "Update Таблиця_входу Set Рівень_доступу = N'" + radioButton3.Text + "' Where Логін = N'" + name_textBox.Text + "';";
                        command = new SqlCommand(q, connect_sql);
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Ви не обрали користувача!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Рівень доступу користувача 'programmer' не можна змінити!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tab_refresh();
        }
        private void del_button_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text.Length == 0)
            {
                if (name_textBox.Text != "programmer")
                {
                    string q = "SELECT COUNT(*) FROM [Таблиця_входу]  WHERE [Логін]  = N'" + del_textBox.Text + "';";
                    SqlCommand command = new SqlCommand(q, connect_sql);
                    object res = command.ExecuteScalar();
                    int count = Convert.ToInt32(res);
                    if (count == 1)
                    {
                        q = "DELETE  FROM Таблиця_входу WHERE [Логін]= N'" + del_textBox.Text + "'";
                        command = new SqlCommand(q, connect_sql);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Користувач успішно видалений ", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        del_textBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Користувач - " + del_textBox.Text + "  не існує у таблиці користувачів ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        del_textBox.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Рівень доступу користувача 'programmer' не можна змінити!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Поле видалення пусте!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tab_refresh();
        }
        private void reg_button_Click(object sender, EventArgs e)
        {
            Regestration reg = new Regestration(connect_sql);
            reg.ShowDialog();
            tab_refresh();
        }
        private void pass_button_Click(object sender, EventArgs e)
        {
            if(name_textBox.Text.Length !=0)
            { 
            change_password chpass = new change_password(connect_sql, name_textBox.Text);
            chpass.ShowDialog();
                name_textBox.Text = "";
            }
            else
            {
                MessageBox.Show("Ви не обрали користувача! ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tab_refresh();
        }
        private void del_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;


            if ((l < 'A' || l > 'z') && (l < 'А' || l > 'я') && (l < '0' || l > '9')  && l != '\b' && l != 'ї' && l != 'і' && l != 'Ї' && l != 'І')
            {
                e.Handled = true;
            }
        }
        private void name_textBox_TextChanged(object sender, EventArgs e)
        {
            if (name_textBox.Text.Length == 0)
            {
                change_button.Enabled = false;
                del_textBox.Enabled = false;
                del_button.Enabled = false;
               
                pass_button.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
            }
            else
            {
                change_button.Enabled = true;
                del_textBox.Enabled = true;
                del_button.Enabled = true;
                reg_button.Enabled = true;
                pass_button.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
            }
        }
    }
}
