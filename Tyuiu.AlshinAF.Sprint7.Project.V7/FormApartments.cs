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
    public partial class FormApartments : Form
    {
        public FormApartments()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string filePath = @"C:\Users\artal\source\repos\Tyuiu.AlshinAF.Sprint7\Tyuiu.AlshinAF.Sprint7.Project.V7\files\SavedApart.csv";
        public double[] GetArrayRow(int row) //Универсальный метод получения столбца массива
        {
            double[] array = new double[dataGridViewApartments_AAF.Rows.Count];
            for (int i = 0; i < dataGridViewApartments_AAF.Rows.Count; i++)
            {
                array[i] = dataGridViewApartments_AAF.Rows[i].Cells[0].Value == null ? array[i - 1] : Convert.ToInt32(dataGridViewApartments_AAF.Rows[i].Cells[row].Value);
                //второй, в конце Cells[1] - номер столбца
            }
            return array;
        }


        private void openFileDialogMatrix_AAF_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void FormApartments_Load(object sender, EventArgs e)
        {
            buttonImportCSVApartments_AAF_Click(sender, e);

        }
        public void DeleteNullCells()
        {
            for (int i = 0; i < dataGridViewApartments_AAF.RowCount - 1; i++)
            {
                if (dataGridViewApartments_AAF.Rows[i].Cells[3].Value.ToString() == "") //удаление пустых строк
                {
                    dataGridViewApartments_AAF.Rows.RemoveAt(i);
                    i--;
                }
            }
        }

        private void buttonImportCSVApartments_AAF_Click(object sender, EventArgs e)
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
            dataGridViewApartments_AAF.DataSource = dataTable;
        }


        private void dataGridViewApartments_AAF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDebtMaximum_AAF_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(6);
            textBoxApartmentsResult_AAF.Text = ds.FindMaxValue(array).ToString();
        }

        private void buttonDebtAverage_AAF_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(6);
            textBoxApartmentsResult_AAF.Text = ds.FindMiddleValue(array).ToString();
        }

        private void buttonDebtMinimum_AAF_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(6);
            textBoxApartmentsResult_AAF.Text = ds.FindMinValue(array).ToString();
        }

        private void buttonDebtSum_AAF_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(6);
            textBoxApartmentsResult_AAF.Text = ds.FindTotalValue(array).ToString();
        }

        private void buttonFindValueApartments_AAF_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewApartments_AAF.RowCount; i++)
            {
                dataGridViewApartments_AAF.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewApartments_AAF.ColumnCount; j++)
                    if (dataGridViewApartments_AAF.Rows[i].Cells[j].Value != null)
                        if (dataGridViewApartments_AAF.Rows[i].Cells[j].Value.ToString().Contains(textBoxApartmentsFindValue_AAF.Text))
                        {
                            dataGridViewApartments_AAF.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void buttonApartmentsAddRow_AAF_Click(object sender, EventArgs e)
        {
            double[] array = { };
            if (array != null)
            {
                array = GetArrayRow(0);
                dataGridViewApartments_AAF.CurrentCell = dataGridViewApartments_AAF[0, dataGridViewApartments_AAF.Rows.Count - 1];
                dataGridViewApartments_AAF.CurrentCell.Value = array.Length;
                dataGridViewApartments_AAF.CurrentCell = dataGridViewApartments_AAF[1, dataGridViewApartments_AAF.Rows.Count - 1];
            }
        }

        private void buttonApartmentsDeleteRow_AAF_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewApartments_AAF.SelectedRows)
            {
                dataGridViewApartments_AAF.Rows.RemoveAt(row.Index);
            }
        }

        private void buttonExportCSVApartments_AAF_Click(object sender, EventArgs e)
        {

            // Create the CSV file
            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Write the header row
                for (int i = 0; i < dataGridViewApartments_AAF.ColumnCount; i++)
                {
                    sw.Write(dataGridViewApartments_AAF.Columns[i].HeaderText);
                    if (i < dataGridViewApartments_AAF.ColumnCount - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.WriteLine();

                // Write the data rows
                foreach (DataGridViewRow row in dataGridViewApartments_AAF.Rows)
                {
                    for (int i = 0; i < dataGridViewApartments_AAF.ColumnCount; i++)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            sw.Write(row.Cells[i].Value.ToString());
                        }
                        if (i < dataGridViewApartments_AAF.ColumnCount - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.WriteLine();
                }

            }
        }

        private void buttonApartmentsExit_AAF_Click(object sender, EventArgs e)
        {
            buttonExportCSVApartments_AAF_Click(sender, e);
            this.Hide();
            FormMain fmain = new FormMain();
            fmain.ShowDialog();
        }

        private void textBoxApartmentsFindValue_AAF_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBoxApartmentsSettings_AAF_Enter(object sender, EventArgs e)
        {

        }

        private void buttonMaxSqr_AAF_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(4);
            textBoxApartmentsResult_AAF.Text = ds.FindMaxValue(array).ToString();
        }

        private void buttonAverageSqr_AAF_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(4);
            textBoxApartmentsResult_AAF.Text = ds.FindMiddleValue(array).ToString();
        }


        private void buttonMinSqr_AAF_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(4);
            textBoxApartmentsResult_AAF.Text = ds.FindMinValue(array).ToString();
        }

        private void buttonSumSqr_AAF_Click(object sender, EventArgs e)
        {
            double[] array = GetArrayRow(4);
            textBoxApartmentsResult_AAF.Text = ds.FindTotalValue(array).ToString();
        }
    }
}



