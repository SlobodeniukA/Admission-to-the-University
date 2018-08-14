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
    public partial class edit_specialty : Form
    {
        SqlConnection connect_sql;
        string id;

        public edit_specialty(SqlConnection transfer_sql, string id_edit)
        {
            InitializeComponent();
            connect_sql = transfer_sql;
            id = id_edit;
            init_boxs();
            ab_spec_textBox.Enabled = false;
            full_textBox.Enabled = false;
            code_textBox.Enabled = false;
        }

        private void init_boxs()
        {
            string q = "SELECT [Абревіатура_спеціальності]  FROM [Спеціальності]  WHERE [Код_спеціальності] = '" + id + "'";
            SqlCommand command = new SqlCommand(q, connect_sql);
            ab_spec_textBox.Text = command.ExecuteScalar().ToString();

            q = "SELECT [Повна_назва_спеціальності]  FROM [Спеціальності]  WHERE [Код_спеціальності] = '" + id + "'";
            command = new SqlCommand(q, connect_sql);
            full_textBox.Text = command.ExecuteScalar().ToString();

            q = "SELECT [Код_спеціальності]   FROM [Спеціальності]  WHERE [Код_спеціальності] = '" + id + "'";
            command = new SqlCommand(q, connect_sql);
            code_textBox.Text = command.ExecuteScalar().ToString();

            q = "SELECT [Кількість_бюджетних_місць]   FROM [Спеціальності]  WHERE [Код_спеціальності] = '" + id + "'";
            command = new SqlCommand(q, connect_sql);
            budget_textBox.Text = command.ExecuteScalar().ToString();

            q = "SELECT [Кількість_пільгових_місць]   FROM [Спеціальності]  WHERE [Код_спеціальності] = '" + id + "'";
             command = new SqlCommand(q, connect_sql);
             privilegie_textBox.Text = command.ExecuteScalar().ToString();

            q = "SELECT [Кількість_місць_для_контрактників]   FROM [Спеціальності]  WHERE [Код_спеціальності] = '" + id + "'";  
            command = new SqlCommand(q, connect_sql);
            kontract_textBox.Text = command.ExecuteScalar().ToString();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (ab_spec_textBox.Text.Length != 0 && full_textBox.Text.Length != 0 && code_textBox.Text.Length != 0 &&
                budget_textBox.Text.Length != 0 && privilegie_textBox.Text.Length != 0 && kontract_textBox.Text.Length != 0)
            {
                string q;
                string full_name = full_textBox.Text;

                q = "UPDATE Спеціальності SET  [Кількість_бюджетних_місць] = N'" + budget_textBox.Text +
                    "' , [Кількість_пільгових_місць] = N'" + privilegie_textBox.Text + "', [Кількість_місць_для_контрактників] = N'" + kontract_textBox.Text + "' Where Код_спеціальності = N'" + id + "'";
                SqlCommand command = new SqlCommand(q, connect_sql);
                command.ExecuteNonQuery();

                MessageBox.Show("Дані успішно редаговані!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Заповніть всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ab_spec_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            e.KeyChar = char.ToUpper(e.KeyChar);

            if ((l < 'А' || l > 'я') && l != '\b' && l != 'ї' && l != 'і' && l != 'Ї' && l != 'І')
            {
                e.Handled = true;
            }
        }

        private void full_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ' && l != 'ї' && l != 'і' && l != 'Ї' && l != 'І')
            {
                e.Handled = true;
            }
        }

        private void code_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';
            }

            if ((l < '0' || l > '9') && l != '.' && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void budget_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            if ((l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void privilegie_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            if ((l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void kontract_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            if ((l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void del_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            e.KeyChar = char.ToUpper(e.KeyChar);

            if ((l < 'А' || l > 'я') && l != '\b' && l != 'ї' && l != 'і' && l != 'Ї' && l != 'І')
            {
                e.Handled = true;
            }
        }
    }
}
