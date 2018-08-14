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
    public partial class cleaning_table : Form
    {
        SqlConnection connect_sql;

        public cleaning_table(SqlConnection transfer_sql)
        {
            InitializeComponent();
            connect_sql = transfer_sql;
            clean_button.Enabled = false;
            clean_button.BackColor = Color.LightBlue;
            clean_button.Text = "";
        }

        private void clean_button_Click(object sender, EventArgs e)
        {
            string q = "TRUNCATE TABLE [Абітурієнт] ";
            SqlCommand command = new SqlCommand(q, connect_sql);
            command = new SqlCommand(q, connect_sql);
            command.ExecuteNonQuery();
            MessageBox.Show("Таблиця 'Абітурієнт' повністю очищена!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                clean_button.Enabled = true;
                clean_button.BackColor = Color.WhiteSmoke;
                clean_button.Text = "Видалити всі дані з таблиці 'Абітурієнти'";
            }
            else
            {
                clean_button.Enabled = false;
                clean_button.BackColor = Color.LightBlue;
                clean_button.Text = "";
            }
        }
    }
}
