using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AlshinAF.Sprint7.Project.V7.Lib;

namespace Tyuiu.AlshinAF.Sprint7.Project.V7
{
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string filePath = @"C:\Users\artal\source\repos\Tyuiu.AlshinAF.Sprint7\Tyuiu.AlshinAF.Sprint7.Project.V7\files\SavedClients.csv";
        public double[] GetArrayRow(int row) //Универсальный метод получения столбца массива
        {
            double[] array = new double[dataGridViewClients_AAF.Rows.Count];
            for (int i = 0; i < dataGridViewClients_AAF.Rows.Count; i++)
            {
                array[i] = dataGridViewClients_AAF.Rows[i].Cells[0].Value == null ? array[i - 1] : Convert.ToInt32(dataGridViewClients_AAF.Rows[i].Cells[row].Value);
                //второй, в конце Cells[1] - номер столбца
            }
            return array;
        }


        private void openFileDialogMatrix_AAF_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            buttonImportCSVClients_AAF_Click(sender, e);

        }
        public void DeleteNullCells()
        {
            for (int i = 0; i < dataGridViewClients_AAF.RowCount - 1; i++)
            {
                if (dataGridViewClients_AAF.Rows[i].Cells[3].Value.ToString() == "") //удаление пустых строк
                {
                    dataGridViewClients_AAF.Rows.RemoveAt(i);
                    i--;
                }
            }
        }

        private void buttonImportCSVClients_AAF_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            ImportCsvToDataGridView(filePath);
            DeleteNullCells();
        }

        private void ImportCsvToDataGridView(string filePath)
        {
            DataTable dataTable = new DataTable();
            using (StreamReader sr = new StreamReader(filePath))
            {
                // Read the header line
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                // Read the data lines
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    dataTable.Rows.Add(values);
                }
            }
            // Bind the DataTable to the DataGridView
            dataGridViewClients_AAF.DataSource = dataTable;
        }


        private void dataGridViewClients_AAF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDebtMaximum_AAF_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(4);
            textBoxClientsResult_AAF.Text = ds.FindMaxValue(array).ToString();
        }

        private void buttonDebtAverage_AAF_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(4);
            textBoxClientsResult_AAF.Text = ds.FindMiddleValue(array).ToString();
        }

        private void buttonDebtMinimum_AAF_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(4);
            textBoxClientsResult_AAF.Text = ds.FindMinValue(array).ToString();
        }

        private void buttonDebtSum_AAF_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(4);
            textBoxClientsResult_AAF.Text = ds.FindTotalValue(array).ToString();
        }

        private void buttonFindValueClients_AAF_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewClients_AAF.RowCount; i++)
            {
                dataGridViewClients_AAF.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewClients_AAF.ColumnCount; j++)
                    if (dataGridViewClients_AAF.Rows[i].Cells[j].Value != null)
                        if (dataGridViewClients_AAF.Rows[i].Cells[j].Value.ToString().Contains(textBoxClientsFindValue_AAF.Text))
                        {
                            dataGridViewClients_AAF.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void buttonClientsAddRow_AAF_Click(object sender, EventArgs e)
        {
            double[] array = { };
            if (array != null)
            {
                array = GetArrayRow(0);
                dataGridViewClients_AAF.CurrentCell = dataGridViewClients_AAF[0, dataGridViewClients_AAF.Rows.Count - 1];
                dataGridViewClients_AAF.CurrentCell.Value = array.Length;
                dataGridViewClients_AAF.CurrentCell = dataGridViewClients_AAF[1, dataGridViewClients_AAF.Rows.Count - 1];
            }
        }

        private void buttonClientDeleteRow_AAF_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewClients_AAF.SelectedRows)
            {
                dataGridViewClients_AAF.Rows.RemoveAt(row.Index);
            }
        }

        private void buttonExportCSVClients_AAF_Click(object sender, EventArgs e)
        {

            // Create the CSV file
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Write the header row
                for (int i = 0; i < dataGridViewClients_AAF.ColumnCount; i++)
                {
                    sw.Write(dataGridViewClients_AAF.Columns[i].HeaderText);
                    if (i < dataGridViewClients_AAF.ColumnCount - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.WriteLine();

                // Write the data rows
                foreach (DataGridViewRow row in dataGridViewClients_AAF.Rows)
                {
                    for (int i = 0; i < dataGridViewClients_AAF.ColumnCount; i++)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            sw.Write(row.Cells[i].Value.ToString());
                        }
                        if (i < dataGridViewClients_AAF.ColumnCount - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.WriteLine();
                }

            }
        }

        private void buttonClientsExit_AAF_Click(object sender, EventArgs e)
        {
            buttonExportCSVClients_AAF_Click(sender, e);
            this.Hide();
            FormMain fmain = new FormMain();
            fmain.ShowDialog();
        }
    }
}

