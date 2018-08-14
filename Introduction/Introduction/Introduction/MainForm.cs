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
    public partial class MainForm : Form
    {
        SqlConnection connect_sql;
        DataTable table_data;
        SqlDataAdapter adapter_sql;
        public MainForm(SqlConnection transfer_sql)
        {
            InitializeComponent();
            connect_sql = transfer_sql;
            tab_refresh();
        }
        private void tab_refresh()
        {
            SqlCommand command = connect_sql.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Абітурієнт";
            command.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(DT);
            dataGridView1.DataSource = DT;
        }
        public void enter_level(string access)
        {
            if (access == "Низький")
            {
                del_textBox.Enabled = false;
                del_button.Enabled = false;
                edit_btn.Enabled = false;
            }
            else if (access == "Середній")
            {
                del_textBox.Enabled = true;
                del_button.Enabled = true;
                edit_btn.Enabled = true; 
            }
            else if (access == "Високий")
            {
                del_textBox.Enabled = true;
                del_button.Enabled = true;
                edit_btn.Enabled = true;
            }
        }
        private void ADD_button_Click(object sender, EventArgs e)
        {
            Add_form addf = new Add_form(connect_sql);
            addf.ShowDialog();
            tab_refresh();
        }
        private void del_button_Click(object sender, EventArgs e)
        {
            string q = "SELECT COUNT(*) FROM [Абітурієнт]  WHERE [Id]  = '" + del_textBox.Text + "';";
            SqlCommand command = new SqlCommand(q, connect_sql);
            object res = command.ExecuteScalar();
            int count = Convert.ToInt32(res);
            if (count == 1)
            {
                q = "DELETE  FROM Абітурієнт WHERE [Id]= N'" + del_textBox.Text + "'";
                command = new SqlCommand(q, connect_sql);
                command.ExecuteNonQuery();
                MessageBox.Show("Абітурієнт успішно видалений ", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                del_textBox.Text = "";
            }
            else
            {
                MessageBox.Show("Id - " + del_textBox.Text + "  не існує у таблиці абітурієнтів ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                del_textBox.Text = "";
            }
            tab_refresh();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'introductionDatabaseDataSet.Абітурієнт' table. You can move, or remove it, as needed.
            this.абітурієнтTableAdapter.Fill(this.introductionDatabaseDataSet.Абітурієнт);
        }
        private void edit_btn_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1[0, row].Value.ToString();
            edit ed = new edit(connect_sql, id);
            ed.ShowDialog();
            tab_refresh();
        }
        private void find_button_Click(object sender, EventArgs e)
        {
            if (find_comboBox.Text.Length != 0 && find_textBox.Text.Length != 0)
            {
                switch (find_comboBox.SelectedIndex)
                {
                    case 0:
                        {
                            adapter_sql = new SqlDataAdapter("SELECT * FROM Абітурієнт WHERE [ПІБ] LIKE N'%" + find_textBox.Text + "%'", connect_sql);
                            break;
                        }
                    case 1:
                        {
                            adapter_sql = new SqlDataAdapter("SELECT * FROM Абітурієнт WHERE [Номер_паспорта] LIKE N'" + find_textBox.Text + "%'", connect_sql);
                            break;
                        }
                    case 2:
                        {
                            adapter_sql = new SqlDataAdapter("SELECT * FROM Абітурієнт WHERE [Іденфікаційний_код] LIKE N'" + find_textBox.Text + "%'", connect_sql);
                            break;
                        }
                    case 3:
                        {
                            adapter_sql = new SqlDataAdapter("SELECT * FROM Абітурієнт WHERE [Номер_атестату] LIKE N'" + find_textBox.Text + "%'", connect_sql);
                            break;
                        }
                    case 4:
                        {
                            adapter_sql = new SqlDataAdapter("SELECT * FROM Абітурієнт WHERE [Спеціальність №1] LIKE  N'" + find_textBox.Text + "%'" + " OR [Спеціальність №2] LIKE N'" + find_textBox.Text + "%'" + " OR [Спеціальність №3] LIKE N'" + find_textBox.Text + "%'", connect_sql);
                            break;
                        }
                    case 5:
                        {
                            adapter_sql = new SqlDataAdapter("SELECT * FROM Абітурієнт WHERE [Місце_народження] LIKE N'%" + find_textBox.Text + "%'", connect_sql);
                            break;
                        }
                    case 6:
                        {
                            adapter_sql = new SqlDataAdapter("SELECT * FROM Абітурієнт WHERE [Номер_телефону] LIKE N'" + find_textBox.Text + "%'", connect_sql);
                            break;
                        }
                }
                table_data = new DataTable();
                adapter_sql.Fill(table_data);
                dataGridView1.DataSource = table_data;
            }
            else
            {
                MessageBox.Show("Оберіть критерій фільтрації", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void refresh_button_Click(object sender, EventArgs e)
        {
            tab_refresh();
            find_textBox.Text = "";
        }
        private void del_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }
        private void find_comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void find_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && (l < '0' || l > '9') && l != '\b' &&  l != 'ї' && l != 'і' && l != 'Ї' && l != 'І' && l != '.' && l != ',')
            {
                e.Handled = true;
            }
        }
        private void ADD_button_Click_1(object sender, EventArgs e)
        {
            Add_form addf = new Add_form(connect_sql);
            addf.ShowDialog();
            tab_refresh();
        }
    }
}
