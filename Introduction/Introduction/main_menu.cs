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
    public partial class main_menu : Form
    {
        SqlConnection connect_sql;

        public main_menu(SqlConnection transfer_sql)
        {
            InitializeComponent();
            connect_sql = transfer_sql;
        }

        public void enter_level(string access)
        {
            if (access == "Низький")
            {
                ADD_button.Enabled = false;
                control_btn.Enabled = false;
                del_all_data_table.Enabled = false;
                manage_specialety_button.Enabled = false;
                users_manage.Enabled = false;
                statement_button.Enabled = false;
            }
            else if (access == "Середній")
            {
                ADD_button.Enabled = true;
                control_btn.Enabled = true;
                del_all_data_table.Enabled = false;
                manage_specialety_button.Enabled = false;
                users_manage.Enabled = false;
                statement_button.Enabled = true;
            }
            else if (access == "Високий")
            {
                ADD_button.Enabled = true;
                control_btn.Enabled = true;
                del_all_data_table.Enabled = true;
                manage_specialety_button.Enabled = true;
                users_manage.Enabled = true;
                statement_button.Enabled = true;
            }
        }

        private void ADD_button_Click(object sender, EventArgs e)
        {
            Add_form addf = new Add_form(connect_sql);
            addf.ShowDialog();
        }

        private void control_btn_Click(object sender, EventArgs e)
        {
            MainForm main_form = new MainForm(connect_sql);
            main_form.ShowDialog();
        }

        private void del_all_data_table_Click(object sender, EventArgs e)
        {
            cleaning_table clean = new cleaning_table(connect_sql);
            clean.ShowDialog();
        }

        private void manage_specialety_button_Click(object sender, EventArgs e)
        {
            manage_specialty managesp = new manage_specialty(connect_sql);
            managesp.ShowDialog();
        }

        private void users_manage_Click(object sender, EventArgs e)
        {
            users_manage user_manage = new users_manage(connect_sql);
            user_manage.ShowDialog();
        }

        private void statement_button_Click(object sender, EventArgs e)
        {
            statement stat = new statement(connect_sql);
            stat.ShowDialog();
        }
    }
}
