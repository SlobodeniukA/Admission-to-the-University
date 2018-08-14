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
    public partial class Add_form : Form
    {
        SqlConnection connect_sql;
        public Add_form(SqlConnection transfer_sql)
        {
            InitializeComponent();
            connect_sql = transfer_sql;
            fill_in_specialty_combobox1();
            fill_in_specialty_combobox2();
            fill_in_specialty_combobox3();
            specialty_combobox1.SelectedIndex = 0;
            specialty_combobox2.SelectedIndex = 0;
            specialty_combobox3.Text = "Відсутня";
            specialty_combobox3.Enabled = false;
            privilegie_comboBox.Enabled = false;
            birthday_date.Text = Convert.ToDateTime("01.01.2004").ToString();
        }

        private void clear_data_in_box()
        {
            Name_textbox.Text = "";
            //birthday_date.Text = "";
            num_pasport_textBox.Text = "";
            city_textBox.Text = "";
            In_kode_textBox.Text = "";
            atestat_textBox.Text = "";
            phone_textBox.Text = "";
            specialty_combobox1.SelectedIndex = 0;
            specialty_combobox2.Text = "Відсутній";
            specialty_combobox3.SelectedIndex = 0;
            average_textBox.Text = "";
            exam1_textBox.Text = "";
            exam2_textBox.Text = "";
            privilegie_comboBox.Text = "";
            
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
        private void ADD_button_Click(object sender, EventArgs e)
        {
            if (num_pasport_textBox.Text.Length == 10)
            {
                if (atestat_textBox.Text.Length == 10)
                {
                    if (In_kode_textBox.Text.Length == 10)
                    {
                        if (Name_textbox.Text.Length != 0 && birthday_date.Text.Length != 0 &&
                        num_pasport_textBox.Text.Length != 0 && city_textBox.Text.Length != 0 &&
                        In_kode_textBox.Text.Length != 0 && atestat_textBox.Text.Length != 0 &&
                        phone_textBox.Text.Length != 0 && specialty_combobox1.Text.Length != 0 &&
                        specialty_combobox2.Text.Length != 0 && specialty_combobox3.Text.Length != 0 &&
                        average_textBox.Text.Length != 0 && exam1_textBox.Text.Length != 0 && exam2_textBox.Text.Length != 0)
                        {

                            double tmp = Convert.ToDouble(average_textBox.Text);
                            string average = average_textBox.Text.Replace(",", ".");

                            if (Convert.ToDouble(average_textBox.Text) <= 12 && Convert.ToDouble(average_textBox.Text) != 0 &&
                            Convert.ToDouble(exam1_textBox.Text) != 0 && Convert.ToDouble(exam2_textBox.Text) != 0 &&
                            Convert.ToDouble(exam1_textBox.Text) < 13 && Convert.ToDouble(exam2_textBox.Text) < 13)
                            {

                                string year = DateTime.Now.Year.ToString();
                                int yung_year = Convert.ToInt32(year) - 13;
                                DateTime limit_date_old = Convert.ToDateTime("01.01.1945");
                                DateTime limit_date_yung = Convert.ToDateTime("01.01." + yung_year);

                                if (limit_date_old < birthday_date.Value && birthday_date.Value < limit_date_yung)
                                {
                                    string q = "SELECT COUNT(*) FROM [Абітурієнт]  WHERE [Номер_паспорта]  = '" + num_pasport_textBox.Text + "';";
                                    SqlCommand command = new SqlCommand(q, connect_sql);
                                    object res = command.ExecuteScalar();
                                    int count = Convert.ToInt32(res);
                                    if (count == 0)
                                    {
                                        q = "SELECT COUNT(*) FROM [Абітурієнт]  WHERE [Іденфікаційний_код]  = '" + In_kode_textBox.Text + "';";
                                        command = new SqlCommand(q, connect_sql);
                                        res = command.ExecuteScalar();
                                        count = Convert.ToInt32(res);
                                        if (count == 0)
                                        {
                                            q = "SELECT COUNT(*) FROM [Абітурієнт]  WHERE [Номер_атестату]   = '" + atestat_textBox.Text + "';";
                                            command = new SqlCommand(q, connect_sql);
                                            res = command.ExecuteScalar();
                                            count = Convert.ToInt32(res);
                                            if (count == 0)
                                            {
                                                if (privilegie_checkBox.Checked == true)
                                                {
                                                    q = "INSERT INTO Абітурієнт VALUES " + "(N'" + Name_textbox.Text + "', N'" + birthday_date.Value.ToString("yyyy-MM-dd") + "', N'" +
                                                        num_pasport_textBox.Text + "', N'" + city_textBox.Text + "', N'" + In_kode_textBox.Text + "', N'" +
                                                        atestat_textBox.Text + "', N'" + "Так" + "', N'" + privilegie_comboBox.Text + "', N'" + phone_textBox.Text + "', N'" + specialty_combobox1.Text + "', N'" +
                                                        specialty_combobox2.Text + "', N'" + specialty_combobox3.Text + "', N'" + average + "', N'" + exam1_textBox.Text +
                                                        "', N'" + exam2_textBox.Text + "', N'" + "1" + "')";
                                                }
                                                else
                                                {
                                                    q = "INSERT INTO Абітурієнт VALUES " + "(N'" + Name_textbox.Text + "', N'" + birthday_date.Value.ToString("yyyy-MM-dd") + "', N'" +
                                                        num_pasport_textBox.Text + "', N'" + city_textBox.Text + "', N'" + In_kode_textBox.Text + "', N'" +
                                                        atestat_textBox.Text + "', N'" + "Ні" + "', N'" + "Відсутній" + "', N'" + phone_textBox.Text + "', N'" + specialty_combobox1.Text + "', N'" +
                                                        specialty_combobox2.Text + "', N'" + specialty_combobox3.Text + "', N'" + average + "', N'" + exam1_textBox.Text +
                                                        "', N'" + exam2_textBox.Text + "', N'" + "1" + "')";
                                                }
                                                command = new SqlCommand(q, connect_sql);
                                                command.ExecuteNonQuery();

                                                q = "UPDATE  Абітурієнт  SET [Рейтигновий_бал_вступу]  = [Середній_бал_атестату]  + [Бал_за_екзамен_№1] +[Бал_за_екзамен_№2] ";
                                                command = new SqlCommand(q, connect_sql);
                                                command.ExecuteNonQuery();
                                                clear_data_in_box();
                                                privilegie_checkBox.Checked = false;
                                                MessageBox.Show("Дані успішно додані!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            else
                                            {
                                                MessageBox.Show("Номер атестату - " + atestat_textBox.Text + " вже був введений в базу даних!\n Можливо абітурієнт вже зареєстрований", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                atestat_textBox.Text = "";
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Індефікаційний код - " + In_kode_textBox.Text + "вже був введений в базу даних!\n Можливо абітурієнт вже зареєстрований", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            In_kode_textBox.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Код паспорта - " + num_pasport_textBox.Text + " вже був введений в базу даних!\n Можливо абітурієнт вже зареєстрований", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        num_pasport_textBox.Text = "";
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Порушено межі віку абітурієнта", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Поля оцінок не можуть мати нульові значення або значення більше 12", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Заповніть всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void privilegie_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (privilegie_checkBox.Checked == true)
            {
                privilegie_comboBox.Enabled = true;
            }
            else
            {
                privilegie_comboBox.Text = "";
                privilegie_comboBox.Enabled = false;
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
                if ((l < 'А' || l > 'я')  && l != '\b')
                {
                    e.Handled = true;
                }
            }
            else if (num_pasport_textBox.Text.Length > 1 && num_pasport_textBox.Text.Length < 11)
            {

                if ((l < '0' || l > '9') && l != '\b')
                {
                    e.Handled = true;
                }
            }
        }
        private void city_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ' && l != '.' && l != ',' && l != 'ї' && l != 'і' && l != 'Ї' && l != 'І' && l != '-')
            {
                e.Handled = true;
            }
        }
        private void In_kode_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (In_kode_textBox.Text.Length < 10)
            {
                if ((l < '0' || l > '9') && l != '\b')
                {
                    e.Handled = true;
                }
            }
        }
        private void atestat_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (atestat_textBox.Text.Length < 2)
            {
                e.KeyChar = char.ToUpper(e.KeyChar);

                if ((l < 'А' || l > 'я') && l != '\b')
                {
                    e.Handled = true;
                }
            }
            else if (atestat_textBox.Text.Length > 1 && atestat_textBox.Text.Length < 11)
            {
                if ((l < '0' || l > '9') && l != '\b')
                {
                    e.Handled = true;
                }
            }
        }
        private void privilegie_comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void phone_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
                if ((l < '0' || l > '9') && l != '\b')
                {
                    e.Handled = true;
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
            if ((l < '0' || l > '9') && l != '\b' )
            {
                e.Handled = true;
            }          
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
    }
}
