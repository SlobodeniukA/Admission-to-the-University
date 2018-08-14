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
    public partial class edit : Form
    {
        SqlConnection connect_sql;
        string id;
        public edit(SqlConnection transfer_sql, string id_edit)
        {
            InitializeComponent();
            connect_sql = transfer_sql;
            id = id_edit;
            init_boxs();
            fill_in_specialty_combobox1();
            fill_in_specialty_combobox2();
            fill_in_specialty_combobox3();
            specialty_combobox2.Items.Remove(specialty_combobox1.Text);
            specialty_combobox3.Items.Remove(specialty_combobox1.Text);
            specialty_combobox3.Items.Remove(specialty_combobox2.Text);
            specialty_combobox1.Items.Remove(specialty_combobox2.Text);
            specialty_combobox2.Items.Remove(specialty_combobox3.Text);
            specialty_combobox1.Items.Remove(specialty_combobox3.Text);
            num_pasport_textBox.Enabled = false;
            In_kode_textBox.Enabled = false;
            atestat_textBox.Enabled = false;
            birthday_date.Text = "01.01.2005";
            if(privilegie_checkBox.Checked == false)
            {
                privilegie_comboBox.Enabled = false;
            }
        }

        private void fill_in_specialty_combobox1()
        {
            string query = "Select Абревіатура_спеціальності From [Спеціальності]";
            SqlCommand cmd = new SqlCommand(query, connect_sql);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string specialty = reader.GetString(reader.GetOrdinal("Абревіатура_спеціальності"));
                specialty_combobox1.Items.Add(specialty);
            }
            reader.Close();
        }

        private void fill_in_specialty_combobox2()
        {
            specialty_combobox2.Items.Add("Відсутня");
            string q = "Select Абревіатура_спеціальності From [Спеціальності]";
            SqlCommand cmd = new SqlCommand(q, connect_sql);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string specialty = reader.GetString(reader.GetOrdinal("Абревіатура_спеціальності"));
                specialty_combobox2.Items.Add(specialty);
            }
            reader.Close();
        }
        private void fill_in_specialty_combobox3()
        {
            specialty_combobox3.Items.Add("Відсутня");
            string q = "Select Абревіатура_спеціальності From [Спеціальності]";
            SqlCommand cmd = new SqlCommand(q, connect_sql);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string specialty = reader.GetString(reader.GetOrdinal("Абревіатура_спеціальності"));
                specialty_combobox3.Items.Add(specialty);
            }
            reader.Close();
        }
        private void init_boxs()
        {
            string q = "SELECT [ПІБ]  FROM [Абітурієнт]  WHERE Id = '" + id + "'";
            SqlCommand command = new SqlCommand(q, connect_sql);
            Name_textbox.Text = command.ExecuteScalar().ToString();
            q = "SELECT [Дата_народження]  FROM [Абітурієнт]  WHERE Id = '" + id + "'";
            command = new SqlCommand(q, connect_sql);
            birthday_date.Value = Convert.ToDateTime(command.ExecuteScalar());
            q = "SELECT [Номер_паспорта]   FROM [Абітурієнт]  WHERE Id = '" + id + "'";
            command = new SqlCommand(q, connect_sql);
            num_pasport_textBox.Text = command.ExecuteScalar().ToString();
            q = "SELECT [Місце_народження]  FROM [Абітурієнт]  WHERE Id = '" + id + "'";
            command = new SqlCommand(q, connect_sql);
            city_textBox.Text = command.ExecuteScalar().ToString();
            q = "SELECT [Іденфікаційний_код]    FROM [Абітурієнт]  WHERE Id = '" + id + "'";
            command = new SqlCommand(q, connect_sql);
            In_kode_textBox.Text = command.ExecuteScalar().ToString();
            q = "SELECT [Номер_атестату]  FROM [Абітурієнт]  WHERE Id = '" + id + "'";
            command = new SqlCommand(q, connect_sql);
            atestat_textBox.Text = command.ExecuteScalar().ToString();
             q = "SELECT COUNT(Id) FROM [Абітурієнт]  WHERE Id = '" + id + "' and [Пільги] = N'Так'";
            command = new SqlCommand(q, connect_sql);
            object res = command.ExecuteScalar();
            int count = Convert.ToInt32(res);
            if (count == 1)
            {
                privilegie_checkBox.Checked = true;
                q = "SELECT [Тип_пільг]  FROM [Абітурієнт]  WHERE Id = '" + id + "'";
                command = new SqlCommand(q, connect_sql);
                privilegie_comboBox.Text = command.ExecuteScalar().ToString();
            }
            else
            {
                privilegie_checkBox.Checked = false;
            }
            q = "SELECT [Номер_телефону]  FROM [Абітурієнт]  WHERE Id = '" + id + "'";
            command = new SqlCommand(q, connect_sql);
            phone_textBox.Text = command.ExecuteScalar().ToString();
            q = "SELECT [Спеціальність №1]  FROM [Абітурієнт]  WHERE Id = '" + id + "'";
            command = new SqlCommand(q, connect_sql);
            specialty_combobox1.Text = command.ExecuteScalar().ToString();
            q = "SELECT [Спеціальність №2]  FROM [Абітурієнт]  WHERE Id = '" + id + "'";
            command = new SqlCommand(q, connect_sql);
            specialty_combobox2.Text = command.ExecuteScalar().ToString();
            q = "SELECT [Спеціальність №3]  FROM [Абітурієнт]  WHERE Id = '" + id + "'";
            command = new SqlCommand(q, connect_sql);
            specialty_combobox3.Text = command.ExecuteScalar().ToString();
            q = "SELECT [Середній_бал_атестату]  FROM [Абітурієнт]  WHERE Id = '" + id + "'";
            command = new SqlCommand(q, connect_sql);
            average_textBox.Text = command.ExecuteScalar().ToString();
            q = "SELECT [Бал_за_екзамен_№1]  FROM [Абітурієнт]  WHERE Id = '" + id + "'";
            command = new SqlCommand(q, connect_sql);
            exam1_textBox.Text = command.ExecuteScalar().ToString();
            q = "SELECT [Бал_за_екзамен_№2]  FROM [Абітурієнт]  WHERE Id = '" + id + "'";
            command = new SqlCommand(q, connect_sql);
            exam2_textBox.Text = command.ExecuteScalar().ToString();
        }

        private void privilegie_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (privilegie_checkBox.Checked == true)
            {
                privilegie_comboBox.Enabled = true;
            }
            else
            {
                privilegie_comboBox.Enabled = false;
                privilegie_comboBox.Text = "";
            }
        }

        private void specialty_combobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            specialty_combobox2.Items.Clear();
            specialty_combobox3.Items.Clear();
            fill_in_specialty_combobox2();
            fill_in_specialty_combobox3();
            specialty_combobox2.Items.Remove(specialty_combobox1.Text);
            specialty_combobox3.Items.Remove(specialty_combobox1.Text);
            specialty_combobox2.Items.Remove(specialty_combobox3.Text);
            specialty_combobox3.Items.Remove(specialty_combobox2.Text);
            if (specialty_combobox1.Text == "")
            {
                specialty_combobox2.Text = "Відсутня";
                specialty_combobox3.Enabled = false;
                specialty_combobox3.Text = "Відсутня";
            }
        }
        private void specialty_combobox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            specialty_combobox1.Items.Clear();
            specialty_combobox3.Items.Clear();
            fill_in_specialty_combobox1();
            fill_in_specialty_combobox3();
            specialty_combobox1.Items.Remove(specialty_combobox2.Text);
            specialty_combobox3.Items.Remove(specialty_combobox2.Text);
            specialty_combobox1.Items.Remove(specialty_combobox3.Text);
            specialty_combobox3.Items.Remove(specialty_combobox1.Text);
            if (specialty_combobox2.Text == "Відсутня")
            {
                specialty_combobox3.Enabled = false;
                specialty_combobox3.Text = "Відсутня";
            }
            else
            {
                specialty_combobox3.Enabled = true;
            }
        }
        private void specialty_combobox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            specialty_combobox1.Items.Clear();
            specialty_combobox2.Items.Clear();
            fill_in_specialty_combobox1();
            fill_in_specialty_combobox2();
            specialty_combobox1.Items.Remove(specialty_combobox3.Text);
            specialty_combobox2.Items.Remove(specialty_combobox3.Text);
            specialty_combobox1.Items.Remove(specialty_combobox2.Text);
            specialty_combobox2.Items.Remove(specialty_combobox1.Text);
            if (specialty_combobox3.Text == specialty_combobox2.Text)
            {
                specialty_combobox3.Text = "Відсутня";
            }
        }
        private void edit_button_Click(object sender, EventArgs e)
        {
            double tmp = Convert.ToDouble(average_textBox.Text);
            string average = average_textBox.Text.Replace(",", ".");
            if (num_pasport_textBox.Text.Length == 10)
            {
                if (atestat_textBox.Text.Length == 10)
                {
                    if (In_kode_textBox.Text.Length == 10)
                    {
                        if (Convert.ToDouble(average_textBox.Text) <= 12 && Convert.ToDouble(average_textBox.Text) != 0 &&
                        Convert.ToDouble(exam1_textBox.Text) != 0 && Convert.ToDouble(exam2_textBox.Text) != 0 &&
                        Convert.ToDouble(exam1_textBox.Text) < 13 && Convert.ToDouble(exam2_textBox.Text) < 13)
                        {
                            if (Name_textbox.Text.Length != 0 && birthday_date.Text.Length != 0 &&
                             num_pasport_textBox.Text.Length != 0 && city_textBox.Text.Length != 0 &&
                             In_kode_textBox.Text.Length != 0 && atestat_textBox.Text.Length != 0 &&
                             phone_textBox.Text.Length != 0 && specialty_combobox1.Text.Length != 0 &&
                             specialty_combobox2.Text.Length != 0 && specialty_combobox3.Text.Length != 0 &&
                             average_textBox.Text.Length != 0 && exam1_textBox.Text.Length != 0 && exam2_textBox.Text.Length != 0)
                            {
                                string year = DateTime.Now.Year.ToString();
                                int yung_year = Convert.ToInt32(year) - 13;
                                DateTime limit_date_old = Convert.ToDateTime("01.01.1945");
                                DateTime limit_date_yung = Convert.ToDateTime("01.01." + yung_year);

                                if (limit_date_old < birthday_date.Value && birthday_date.Value < limit_date_yung)
                                {
                                    string q;
                                    SqlCommand command;

                                    if (privilegie_checkBox.Checked == true)
                                    {
                                        q = "UPDATE Абітурієнт SET [ПІБ] =  N'" + Name_textbox.Text + "', [Дата_народження] = N'" + birthday_date.Value.ToString("yyyy-MM-dd") +
                                            "', [Місце_народження] = N'" + city_textBox.Text +
                                            "' , [Пільги] = N'" + "Так" + "', [Тип_пільг] = N'" + privilegie_comboBox.Text +
                                            "' , [Номер_телефону] = N'" + phone_textBox.Text + "', [Спеціальність №1] = N'" + specialty_combobox1.Text +
                                            "' , [Спеціальність №2] = N'" + specialty_combobox2.Text + "', [Спеціальність №3] = N'" + specialty_combobox3.Text +
                                            "' , [Середній_бал_атестату] = N'" + average + "', [Бал_за_екзамен_№1] = N'" + exam1_textBox.Text +
                                            "' , [Бал_за_екзамен_№2] = N'" + exam2_textBox.Text + "' Where Id = N'" + id + "'";
                                    }
                                    else
                                    {
                                        q = "UPDATE Абітурієнт SET [ПІБ] =  N'" + Name_textbox.Text + "', [Дата_народження] = N'" + birthday_date.Value.ToString("yyyy-MM-dd") +
                                             "', [Місце_народження] = N'" + city_textBox.Text +
                                              "' , [Пільги] = N'" + "Ні" + "', [Тип_пільг] = N'" + "Відсутній" +
                                              "' , [Номер_телефону] = N'" + phone_textBox.Text + "', [Спеціальність №1] = N'" + specialty_combobox1.Text +
                                              "' , [Спеціальність №2] = N'" + specialty_combobox2.Text + "', [Спеціальність №3] = N'" + specialty_combobox3.Text +
                                              "' , [Середній_бал_атестату] = N'" + average + "', [Бал_за_екзамен_№1] = N'" + exam1_textBox.Text +
                                              "' , [Бал_за_екзамен_№2] = N'" + exam2_textBox.Text + "' Where Id = N'" + id + "'";

                                    }
                                    command = new SqlCommand(q, connect_sql);
                                    command.ExecuteNonQuery();
                                    q = "UPDATE  Абітурієнт  SET [Рейтигновий_бал_вступу]  = [Середній_бал_атестату]  + [Бал_за_екзамен_№1] +[Бал_за_екзамен_№2] ";
                                    command = new SqlCommand(q, connect_sql);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Зміна данних пройшла успішно!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Порушено межі віку абітурієнта", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Заповніть всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Поля оцінок не можуть мати нульові значення або значення більше 12", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Поле Іденфікаційний код до кінця не заповнено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Поле Номер атесату  до кінця не заповнено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Поле Номер паспорта до кінця не заповнено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
        private void Name_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ' && l != 'ї' && l != 'і' && l != 'Ї' && l != 'І')
            {
                e.Handled = true;
            }
        }
        private void num_pasport_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (num_pasport_textBox.Text.Length < 2)
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
                if ((l < 'А' || l > 'я') && l != '\b')
                {
                    e.Handled = true;
                }
            }
            else if (num_pasport_textBox.Text.Length > 1 && num_pasport_textBox.Text.Length < 8)
            {
                if ((l < '0' || l > '9') && l != '\b')
                {
                    e.Handled = true;
                }
            }
            e.Handled = true;
        }
        private void city_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ' && l != '.' && l != ',' && l != 'ї' && l != 'і' && l != 'Ї' && l != 'І' && l != '-')
            {
                e.Handled = true;
            }
        }
        private void privilegie_comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void phone_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            if (phone_textBox.Text.Length > 10)
            {

                if ((l < '0' || l > '9') && l != '\b')
                {
                    e.Handled = true;
                }
            }
        }
        private void specialty_combobox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void specialty_combobox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void specialty_combobox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void average_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (e.KeyChar == ',')
            {
                if ((average_textBox.Text.IndexOf(',') != -1) || (average_textBox.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }
            if ((l < '0' || l > '9') && l != '\b' && l != ',')
            {
                e.Handled = true;
            }
        }
        private void exam1_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
            string s = average_textBox.Text;
        }
        private void exam2_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }
        private void exam1_textBox_TextChanged(object sender, EventArgs e)
        {
            string s = exam1_textBox.Text;
            if (exam1_textBox.Text.Length > 0)
            {
                int mark = Convert.ToInt32(s);
                if (mark > 12)
                    exam1_textBox.Text = "";
            }
            if (exam1_textBox.Text.Length > 2)
                exam1_textBox.Text = "";
        }
        private void exam2_textBox_TextChanged(object sender, EventArgs e)
        {
            string s = exam2_textBox.Text;
            if (exam2_textBox.Text.Length > 0)
            {
                int mark = Convert.ToInt32(s);
                if (mark > 12)
                    exam2_textBox.Text = "";
            }

            if (exam2_textBox.Text.Length > 2)
                exam2_textBox.Text = "";
        }
        private void edit_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}
