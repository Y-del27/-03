using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Осннова_7
{
    public partial class Form3 : Form
    {
        private SQLiteConnection Судоходство;
        public Form3()
        {
            InitializeComponent();
            InitializeDatabase();
        }
        private void InitializeDatabase()
        {
            // Укажите путь к своей базе данных
            string connectionString = "Data Source=Судоходство.db;Version=3;";
            Судоходство = new SQLiteConnection(connectionString);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form3 = new Form2();
            form3.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                Судоходство.Open();
                string query = "SELECT * FROM Посещения"; // Замените на имя вашей таблицы
                SQLiteCommand command = new SQLiteCommand(query, Судоходство);

                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable; // Привязка данных
                AdjustColumnWidths();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void AdjustColumnWidths()
        {
            // Установите ширину для каждого столбца по индексу
            dataGridView1.Columns[0].Width = 20; // Ширина первого столбца
            dataGridView1.Columns[1].Width = 150; // Ширина второго столбца
            dataGridView1.Columns[2].Width = 200; // Ширина третьего столбца
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 150;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
        
    
