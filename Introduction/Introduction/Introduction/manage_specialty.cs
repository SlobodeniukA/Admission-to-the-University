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
    public partial class manage_specialty : Form
    {
        SqlConnection connect_sql;

        public manage_specialty(SqlConnection transfer_sql)
        {
            InitializeComponent();
            connect_sql = transfer_sql;
        }
        private void manage_specialty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'introductionDatabaseDataSet.Спеціальності' table. You can move, or remove it, as needed.
            this.спеціальностіTableAdapter.Fill(this.introductionDatabaseDataSet.Спеціальності);
        }
        private void tab_refresh()
        {
            SqlCommand command = connect_sql.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Спеціальності";
            command.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(DT);
            dataGridView1.DataSource = DT;
        }
        private void add_button_Click(object sender, EventArgs e)
        {
                if (ab_spec_textBox.Text.Length != 0 && full_textBox.Text.Length != 0 && code_textBox.Text.Length != 0 &&
                    budget_textBox.Text.Length != 0 && privilegie_textBox.Text.Length != 0 && kontract_textBox.Text.Length != 0)
                {
                    string q = "SELECT COUNT(*) FROM [Спеціальності]  WHERE [Абревіатура_спеціальності]  = N'" + ab_spec_textBox.Text + "';";
                    SqlCommand command = new SqlCommand(q, connect_sql);
                    object res = command.ExecuteScalar();
                    int count = Convert.ToInt32(res);
                    if (count == 0)
                    {

                        q = "SELECT COUNT(*) FROM [Спеціальності]  WHERE [Повна_назва_спеціальності]   = N'" + full_textBox.Text + "';";
                        command = new SqlCommand(q, connect_sql);
                        res = command.ExecuteScalar();
                        count = Convert.ToInt32(res);
                        if (count == 0)
                        {

                            q = "SELECT COUNT(*) FROM [Спеціальності]  WHERE [Код_спеціальності]  = N'" + code_textBox.Text + "';";
                            command = new SqlCommand(q, connect_sql);
                            res = command.ExecuteScalar();
                            count = Convert.ToInt32(res);
                            if (count == 0)
                            {
                                q = "INSERT INTO Спеціальності VALUES " + "(N'" + ab_spec_textBox.Text + "', N'" + full_textBox.Text + "', N'" +
                                           code_textBox.Text + "', N'" + budget_textBox.Text + "', N'" + privilegie_textBox.Text + "', N'" +
                                           kontract_textBox.Text + "')";

                                command = new SqlCommand(q, connect_sql);
                                command.ExecuteNonQuery();

                                MessageBox.Show("Дані успішно додані!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ab_spec_textBox.Text = "";
                                full_textBox.Text = "";
                                code_textBox.Text = "";
                                budget_textBox.Text = "";
                                privilegie_textBox.Text = "";
                                kontract_textBox.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Код спеціальності не може співпадати з іншою!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                        else
                        {
                            MessageBox.Show("Повна назва спеціальності не можу співпадати з іншою!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Абревіатури спеціальностей не можуть співпадати!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Заповніть всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            tab_refresh();
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            if (del_textBox.Text.Length != 0)
            {
                string q = "SELECT COUNT(*) FROM [Спеціальності]  WHERE [Абревіатура_спеціальності]  = N'" + del_textBox.Text + "';";
                SqlCommand command = new SqlCommand(q, connect_sql);
                object res = command.ExecuteScalar();
                int count = Convert.ToInt32(res);
                if (count == 1)
                {
                    q = "DELETE  FROM Спеціальності WHERE [Абревіатура_спеціальності] = N'" + del_textBox.Text + "'";
                    command = new SqlCommand(q, connect_sql);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Спеціальність успішно видалена ", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    del_textBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Абревіатура_спеціальності  - N'" + del_textBox.Text + "'  не існує у таблиці спеціальностей ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    del_textBox.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Поле не заповнено! ", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Error);

                del_textBox.Text = "";
            }
            tab_refresh();
        }
        private void edit_button_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1[2, row].Value.ToString();
            edit_specialty edits = new edit_specialty(connect_sql, id);
            edits.ShowDialog();
            tab_refresh();
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
            if(e.KeyChar == ',')
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
