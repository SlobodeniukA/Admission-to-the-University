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
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Introduction
{
    public partial class statement : Form
    {
        SqlConnection connect_sql;
        string special_query;
        public statement(SqlConnection transfer_sql)
        {
            InitializeComponent();
            connect_sql = transfer_sql;
            fill_in_comboBox1();
            import_btn.Enabled = false;
            stat_button.Enabled = false;
        }
        private void fill_in_comboBox1()
        {
            string query = "Select Абревіатура_спеціальності From [Спеціальності]";
            SqlCommand cmd = new SqlCommand(query, connect_sql);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string specialty = reader.GetString(reader.GetOrdinal("Абревіатура_спеціальності"));
                comboBox1.Items.Add(specialty);
            }
            reader.Close();
        }
        private void stat_button_Click(object sender, EventArgs e)
        {
            import_btn.Enabled = true;
            if (comboBox1.Text.Length != 0)
            { 
            string q = "SELECT [Кількість_пільгових_місць]  FROM [Спеціальності]  WHERE [Абревіатура_спеціальності] = N'" + comboBox1.Text + "'";
            SqlCommand command = new SqlCommand(q, connect_sql);
            object res = command.ExecuteScalar();
            int count_privilegies = Convert.ToInt32(res);
             q = "SELECT [Кількість_бюджетних_місць]  FROM [Спеціальності]  WHERE [Абревіатура_спеціальності] = N'" + comboBox1.Text + "'";
             command = new SqlCommand(q, connect_sql);
             res = command.ExecuteScalar();
            int count_budget = Convert.ToInt32(res);
            q = "SELECT [Кількість_місць_для_контрактників]  FROM [Спеціальності]  WHERE [Абревіатура_спеціальності] = N'" + comboBox1.Text + "'";
            command = new SqlCommand(q, connect_sql);
            res = command.ExecuteScalar();
            int count_kontract = Convert.ToInt32(res);
            command = connect_sql.CreateCommand();
            command.CommandType = CommandType.Text;
                special_query = "SELECT a.[Id], a.[ПІБ], a.[Дата_народження], a.[Пільги], a.[Номер_телефону], a.[Рейтигновий_бал_вступу], a.[Тип_вступу]" +
                " into #temp " +
                " FROM( " +
              " SELECT TOP (" + count_privilegies + ")  [Абітурієнт].[Id], [Абітурієнт].[ПІБ], [Абітурієнт].[Дата_народження], [Абітурієнт].[Пільги], [Абітурієнт].[Номер_телефону], [Абітурієнт].[Рейтигновий_бал_вступу], '1' as [Тип_вступу] " +
              " FROM[Абітурієнт] " +
                " WHERE[Абітурієнт].[Пільги] = N'Так' AND([Абітурієнт].[Спеціальність №1] = N'" + comboBox1.Text + "' OR[Абітурієнт].[Спеціальність №2] = N'" + comboBox1.Text + "' OR[Абітурієнт].[Спеціальність №3]= N'" + comboBox1.Text + "') " +

             " ORDER BY[Абітурієнт].[Рейтигновий_бал_вступу] " +
             " desc " +
                " UNION " +
             " SELECT TOP (" + count_budget + ")	 [Абітурієнт].[Id], [Абітурієнт].[ПІБ], [Абітурієнт].[Дата_народження], [Абітурієнт].[Пільги], [Абітурієнт].[Номер_телефону], [Абітурієнт].[Рейтигновий_бал_вступу], '2' as [Тип_вступу] " +
             " FROM[Абітурієнт] " +
             " WHERE ([Абітурієнт].[Спеціальність №1] = N'" + comboBox1.Text + "' OR[Абітурієнт].[Спеціальність №2] = N'" + comboBox1.Text + "' OR[Абітурієнт].[Спеціальність №3]= N'" + comboBox1.Text + "' )" +
                  " AND NOT EXISTS(SELECT TOP(6) a1.[Id], a1.[Рейтигновий_бал_вступу], 'select 1' as [Тип_вступу] FROM[Абітурієнт] a1 WHERE a1.[Пільги] = N'Так' AND (a1.[Спеціальність №1] = N'" + comboBox1.Text + "' OR a1.[Спеціальність №2] = N'" + comboBox1.Text + "' OR a1.[Спеціальність №3]= N'" + comboBox1.Text + "') and[Абітурієнт].[Id] = a1.[Id] ORDER BY a1.[Рейтигновий_бал_вступу] desc ) " +

              " ORDER BY[Абітурієнт].[Рейтигновий_бал_вступу] desc " +
                " ) a " +
                " SELECT a.[Id], a.[ПІБ], a.[Дата_народження], a.[Пільги], a.[Номер_телефону], a.[Рейтигновий_бал_вступу], " +
                " case when a.[Тип_вступу] = '1' then N'Пільгове місце' " +
             " when a.[Тип_вступу] = '2' then N'Бюджетне місце' " +
             " when a.[Тип_вступу] = '3' then N'Контрактне місце' " +
              " end as 'Тип_вступу' " +
                " FROM ( " +
              " SELECT b.[Id], b.[ПІБ], b.[Дата_народження], b.[Пільги], b.[Номер_телефону], b.[Рейтигновий_бал_вступу], b.[Тип_вступу] " +
             " FROM #temp b " +
            " UNION " +
          " SELECT TOP (" + count_kontract + ")    a2.[Id], a2.[ПІБ], a2.[Дата_народження], a2.[Пільги], a2.[Номер_телефону], a2.[Рейтигновий_бал_вступу], '3' as [Тип_вступу]" +
          " FROM [Абітурієнт] a2 " +

          " WHERE (a2.[Спеціальність №1] = N'" + comboBox1.Text + "' OR a2.[Спеціальність №2] = N'" + comboBox1.Text + "' OR a2.[Спеціальність №3]= N'" + comboBox1.Text + "' ) " +

                 " AND NOT EXISTS(SELECT z.id FROM #temp z WHERE z.id = a2.Id) " +
          " ORDER BY a2.[Рейтигновий_бал_вступу] desc " +
            " )a " +
            " ORDER BY a.Тип_вступу, a.[Рейтигновий_бал_вступу] desc " +

            " drop table #temp ";
            command = new SqlCommand(special_query, connect_sql);
            command.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SqlDA = new SqlDataAdapter(command);
            SqlDA.Fill(DT);
            dataGridView1.DataSource = DT;
            }
            else
            {
                MessageBox.Show("Оберіть групу для створення відомостей", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void import_btn_Click(object sender, EventArgs e)
        {
        
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            Excel.Application exApp = new Excel.Application();
            //exApp.Visible = true;
            exApp.Workbooks.Open(Environment.CurrentDirectory + @"\Шаблон.xls");
            Excel.Worksheet workSheet = (Excel.Worksheet)exApp.ActiveSheet;
            workSheet.Cells[1, 1] = "Cпеціальність " + comboBox1.Text;
            workSheet.Cells[2, 1] = "#";
            workSheet.Cells[2, 2] = "ПІБ";
            workSheet.Cells[2, 3] = "Дата народження";
            workSheet.Cells[2, 4] = "Пільги";
            workSheet.Cells[2, 5] = "Номер телефону";
            workSheet.Cells[2, 6] = "Рейтигновий бал вступу";
            workSheet.Cells[2, 7] = "Тип вступу";
            int rowExcel = 3;
            int y = 1, counter = 1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                workSheet.Cells[rowExcel,"A"] = counter.ToString();
                workSheet.Cells[rowExcel, "B"] = dataGridView1.Rows[i].Cells["ПІБ"].Value;
                workSheet.Cells[rowExcel, "C"] = dataGridView1.Rows[i].Cells["Дата_народження"].Value;
                workSheet.Cells[rowExcel, "D"] = dataGridView1.Rows[i].Cells["Пільги"].Value;
                workSheet.Cells[rowExcel, "E"] = dataGridView1.Rows[i].Cells["Номер_телефону"].Value;
                workSheet.Cells[rowExcel, "F"] = dataGridView1.Rows[i].Cells["Рейтигновий_бал_вступу"].Value;
                workSheet.Cells[rowExcel, "G"] = dataGridView1.Rows[i].Cells["Тип_вступу"].Value;

                ++rowExcel;
                ++counter;
            }
            workSheet.SaveAs("Вступники на спеціальність "  + comboBox1.Text +  ".xls");
            exApp.Quit();
            MessageBox.Show("Файл був збережений в папці 'Мої документи' під назвою 'Вступники на спеціальність "  + comboBox1.Text +  ".xls'", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text.Length !=0)
            {
                stat_button.Enabled = true;
            }
            else
            {
                stat_button.Enabled = false;
            }
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
