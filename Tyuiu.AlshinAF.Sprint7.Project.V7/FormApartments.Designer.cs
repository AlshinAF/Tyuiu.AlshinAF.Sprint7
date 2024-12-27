

namespace Tyuiu.AlshinAF.Sprint7.Project.V7
{
    partial class FormApartments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxApartmentsSettings_AAF = new GroupBox();
            textBoxApartmentsFindValue_AAF = new TextBox();
            buttonApartmentsExit_AAF = new Button();
            buttonExportCSVApartments_AAF = new Button();
            buttonApartmentsDeleteRow_AAF = new Button();
            buttonApartmentsAddRow_AAF = new Button();
            buttonFindValueApartments_AAF = new Button();
            groupBoxApartmentsCalculation_AAF = new GroupBox();
            buttonSumSqr_AAF = new Button();
            buttonAverageSqr_AAF = new Button();
            buttonMinSqr_AAF = new Button();
            buttonMaxSqr_AAF = new Button();
            buttonDebtSum_AAF = new Button();
            buttonDebtMinimum_AAF = new Button();
            buttonDebtAverage_AAF = new Button();
            buttonDebtMaximum_AAF = new Button();
            textBoxApartmentsResult_AAF = new TextBox();
            dataGridViewApartments_AAF = new DataGridView();
            openFileDialogCSV_AAF = new OpenFileDialog();
            groupBoxApartmentsSettings_AAF.SuspendLayout();
            groupBoxApartmentsCalculation_AAF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApartments_AAF).BeginInit();
            SuspendLayout();
            // 
            // groupBoxApartmentsSettings_AAF
            // 
            groupBoxApartmentsSettings_AAF.BackgroundImage = Properties.Resources.backgroundimage_AAF;
            groupBoxApartmentsSettings_AAF.Controls.Add(textBoxApartmentsFindValue_AAF);
            groupBoxApartmentsSettings_AAF.Controls.Add(buttonApartmentsExit_AAF);
            groupBoxApartmentsSettings_AAF.Controls.Add(buttonExportCSVApartments_AAF);
            groupBoxApartmentsSettings_AAF.Controls.Add(buttonApartmentsDeleteRow_AAF);
            groupBoxApartmentsSettings_AAF.Controls.Add(buttonApartmentsAddRow_AAF);
            groupBoxApartmentsSettings_AAF.Controls.Add(buttonFindValueApartments_AAF);
            groupBoxApartmentsSettings_AAF.ForeColor = SystemColors.ButtonHighlight;
            groupBoxApartmentsSettings_AAF.Location = new Point(87, 317);
            groupBoxApartmentsSettings_AAF.Name = "groupBoxApartmentsSettings_AAF";
            groupBoxApartmentsSettings_AAF.Size = new Size(392, 191);
            groupBoxApartmentsSettings_AAF.TabIndex = 5;
            groupBoxApartmentsSettings_AAF.TabStop = false;
            groupBoxApartmentsSettings_AAF.Text = "Настройки";
            groupBoxApartmentsSettings_AAF.Enter += groupBoxApartmentsSettings_AAF_Enter;
            // 
            // textBoxApartmentsFindValue_AAF
            // 
            textBoxApartmentsFindValue_AAF.Location = new Point(6, 23);
            textBoxApartmentsFindValue_AAF.Name = "textBoxApartmentsFindValue_AAF";
            textBoxApartmentsFindValue_AAF.Size = new Size(159, 23);
            textBoxApartmentsFindValue_AAF.TabIndex = 4;
            textBoxApartmentsFindValue_AAF.TextChanged += textBoxApartmentsFindValue_AAF_TextChanged;
            // 
            // buttonApartmentsExit_AAF
            // 
            buttonApartmentsExit_AAF.BackColor = Color.Red;
            buttonApartmentsExit_AAF.FlatStyle = FlatStyle.Popup;
            buttonApartmentsExit_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonApartmentsExit_AAF.Location = new Point(6, 148);
            buttonApartmentsExit_AAF.Name = "buttonApartmentsExit_AAF";
            buttonApartmentsExit_AAF.Size = new Size(159, 23);
            buttonApartmentsExit_AAF.TabIndex = 10;
            buttonApartmentsExit_AAF.Text = "Выйти";
            buttonApartmentsExit_AAF.UseVisualStyleBackColor = false;
            buttonApartmentsExit_AAF.Click += buttonApartmentsExit_AAF_Click;
            // 
            // buttonExportCSVApartments_AAF
            // 
            buttonExportCSVApartments_AAF.BackColor = SystemColors.ActiveBorder;
            buttonExportCSVApartments_AAF.FlatStyle = FlatStyle.Popup;
            buttonExportCSVApartments_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonExportCSVApartments_AAF.Location = new Point(6, 119);
            buttonExportCSVApartments_AAF.Name = "buttonExportCSVApartments_AAF";
            buttonExportCSVApartments_AAF.Size = new Size(159, 23);
            buttonExportCSVApartments_AAF.TabIndex = 9;
            buttonExportCSVApartments_AAF.Text = "Экспорт и сохранение";
            buttonExportCSVApartments_AAF.UseVisualStyleBackColor = false;
            buttonExportCSVApartments_AAF.Click += buttonExportCSVApartments_AAF_Click;
            // 
            // buttonApartmentsDeleteRow_AAF
            // 
            buttonApartmentsDeleteRow_AAF.BackColor = Color.IndianRed;
            buttonApartmentsDeleteRow_AAF.FlatStyle = FlatStyle.Popup;
            buttonApartmentsDeleteRow_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonApartmentsDeleteRow_AAF.Location = new Point(6, 90);
            buttonApartmentsDeleteRow_AAF.Name = "buttonApartmentsDeleteRow_AAF";
            buttonApartmentsDeleteRow_AAF.Size = new Size(159, 23);
            buttonApartmentsDeleteRow_AAF.TabIndex = 8;
            buttonApartmentsDeleteRow_AAF.Text = "Удалить строку";
            buttonApartmentsDeleteRow_AAF.UseVisualStyleBackColor = false;
            buttonApartmentsDeleteRow_AAF.Click += buttonApartmentsDeleteRow_AAF_Click;
            // 
            // buttonApartmentsAddRow_AAF
            // 
            buttonApartmentsAddRow_AAF.BackColor = Color.YellowGreen;
            buttonApartmentsAddRow_AAF.FlatStyle = FlatStyle.Popup;
            buttonApartmentsAddRow_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonApartmentsAddRow_AAF.Location = new Point(6, 61);
            buttonApartmentsAddRow_AAF.Name = "buttonApartmentsAddRow_AAF";
            buttonApartmentsAddRow_AAF.Size = new Size(159, 23);
            buttonApartmentsAddRow_AAF.TabIndex = 7;
            buttonApartmentsAddRow_AAF.Text = "Добавить строку";
            buttonApartmentsAddRow_AAF.UseVisualStyleBackColor = false;
            buttonApartmentsAddRow_AAF.Click += buttonApartmentsAddRow_AAF_Click;
            // 
            // buttonFindValueApartments_AAF
            // 
            buttonFindValueApartments_AAF.BackColor = SystemColors.ActiveCaption;
            buttonFindValueApartments_AAF.FlatStyle = FlatStyle.Popup;
            buttonFindValueApartments_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonFindValueApartments_AAF.Location = new Point(171, 22);
            buttonFindValueApartments_AAF.Name = "buttonFindValueApartments_AAF";
            buttonFindValueApartments_AAF.Size = new Size(170, 23);
            buttonFindValueApartments_AAF.TabIndex = 6;
            buttonFindValueApartments_AAF.Text = "Найти значение";
            buttonFindValueApartments_AAF.UseVisualStyleBackColor = false;
            buttonFindValueApartments_AAF.Click += buttonFindValueApartments_AAF_Click;
            // 
            // groupBoxApartmentsCalculation_AAF
            // 
            groupBoxApartmentsCalculation_AAF.BackgroundImage = Properties.Resources.backgroundimage_AAF;
            groupBoxApartmentsCalculation_AAF.Controls.Add(buttonSumSqr_AAF);
            groupBoxApartmentsCalculation_AAF.Controls.Add(buttonAverageSqr_AAF);
            groupBoxApartmentsCalculation_AAF.Controls.Add(buttonMinSqr_AAF);
            groupBoxApartmentsCalculation_AAF.Controls.Add(buttonMaxSqr_AAF);
            groupBoxApartmentsCalculation_AAF.Controls.Add(buttonDebtSum_AAF);
            groupBoxApartmentsCalculation_AAF.Controls.Add(buttonDebtMinimum_AAF);
            groupBoxApartmentsCalculation_AAF.Controls.Add(buttonDebtAverage_AAF);
            groupBoxApartmentsCalculation_AAF.Controls.Add(buttonDebtMaximum_AAF);
            groupBoxApartmentsCalculation_AAF.Controls.Add(textBoxApartmentsResult_AAF);
            groupBoxApartmentsCalculation_AAF.ForeColor = SystemColors.ButtonHighlight;
            groupBoxApartmentsCalculation_AAF.Location = new Point(485, 317);
            groupBoxApartmentsCalculation_AAF.Name = "groupBoxApartmentsCalculation_AAF";
            groupBoxApartmentsCalculation_AAF.Size = new Size(704, 191);
            groupBoxApartmentsCalculation_AAF.TabIndex = 4;
            groupBoxApartmentsCalculation_AAF.TabStop = false;
            groupBoxApartmentsCalculation_AAF.Text = "Вычисления";
            // 
            // buttonSumSqr_AAF
            // 
            buttonSumSqr_AAF.BackColor = SystemColors.ActiveCaption;
            buttonSumSqr_AAF.FlatStyle = FlatStyle.Popup;
            buttonSumSqr_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonSumSqr_AAF.Location = new Point(528, 119);
            buttonSumSqr_AAF.Name = "buttonSumSqr_AAF";
            buttonSumSqr_AAF.Size = new Size(168, 49);
            buttonSumSqr_AAF.TabIndex = 9;
            buttonSumSqr_AAF.Text = "Сумма площадей";
            buttonSumSqr_AAF.UseVisualStyleBackColor = false;
            buttonSumSqr_AAF.Click += buttonSumSqr_AAF_Click;
            // 
            // buttonAverageSqr_AAF
            // 
            buttonAverageSqr_AAF.BackColor = SystemColors.ActiveCaption;
            buttonAverageSqr_AAF.FlatStyle = FlatStyle.Popup;
            buttonAverageSqr_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonAverageSqr_AAF.Location = new Point(528, 49);
            buttonAverageSqr_AAF.Name = "buttonAverageSqr_AAF";
            buttonAverageSqr_AAF.Size = new Size(168, 47);
            buttonAverageSqr_AAF.TabIndex = 8;
            buttonAverageSqr_AAF.Text = "Средняя площадь";
            buttonAverageSqr_AAF.UseVisualStyleBackColor = false;
            buttonAverageSqr_AAF.Click += buttonAverageSqr_AAF_Click;
            // 
            // buttonMinSqr_AAF
            // 
            buttonMinSqr_AAF.BackColor = SystemColors.ActiveCaption;
            buttonMinSqr_AAF.FlatStyle = FlatStyle.Popup;
            buttonMinSqr_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonMinSqr_AAF.Location = new Point(354, 121);
            buttonMinSqr_AAF.Name = "buttonMinSqr_AAF";
            buttonMinSqr_AAF.Size = new Size(168, 47);
            buttonMinSqr_AAF.TabIndex = 7;
            buttonMinSqr_AAF.Text = "Минимальная площадь";
            buttonMinSqr_AAF.UseVisualStyleBackColor = false;
            buttonMinSqr_AAF.Click += buttonMinSqr_AAF_Click;
            // 
            // buttonMaxSqr_AAF
            // 
            buttonMaxSqr_AAF.BackColor = SystemColors.ActiveCaption;
            buttonMaxSqr_AAF.FlatStyle = FlatStyle.Popup;
            buttonMaxSqr_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonMaxSqr_AAF.Location = new Point(354, 49);
            buttonMaxSqr_AAF.Name = "buttonMaxSqr_AAF";
            buttonMaxSqr_AAF.Size = new Size(168, 47);
            buttonMaxSqr_AAF.TabIndex = 6;
            buttonMaxSqr_AAF.Text = "Максимальня площадь";
            buttonMaxSqr_AAF.UseVisualStyleBackColor = false;
            buttonMaxSqr_AAF.Click += buttonMaxSqr_AAF_Click;
            // 
            // buttonDebtSum_AAF
            // 
            buttonDebtSum_AAF.BackColor = SystemColors.ActiveCaption;
            buttonDebtSum_AAF.FlatStyle = FlatStyle.Popup;
            buttonDebtSum_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonDebtSum_AAF.Location = new Point(180, 119);
            buttonDebtSum_AAF.Name = "buttonDebtSum_AAF";
            buttonDebtSum_AAF.Size = new Size(168, 47);
            buttonDebtSum_AAF.TabIndex = 5;
            buttonDebtSum_AAF.Text = "Сумма квартплат";
            buttonDebtSum_AAF.UseVisualStyleBackColor = false;
            buttonDebtSum_AAF.Click += buttonDebtSum_AAF_Click;
            // 
            // buttonDebtMinimum_AAF
            // 
            buttonDebtMinimum_AAF.BackColor = SystemColors.ActiveCaption;
            buttonDebtMinimum_AAF.FlatStyle = FlatStyle.Popup;
            buttonDebtMinimum_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonDebtMinimum_AAF.Location = new Point(6, 121);
            buttonDebtMinimum_AAF.Name = "buttonDebtMinimum_AAF";
            buttonDebtMinimum_AAF.Size = new Size(168, 47);
            buttonDebtMinimum_AAF.TabIndex = 4;
            buttonDebtMinimum_AAF.Text = "Минимальная квартплата";
            buttonDebtMinimum_AAF.UseVisualStyleBackColor = false;
            buttonDebtMinimum_AAF.Click += buttonDebtMinimum_AAF_Click;
            // 
            // buttonDebtAverage_AAF
            // 
            buttonDebtAverage_AAF.BackColor = SystemColors.ActiveCaption;
            buttonDebtAverage_AAF.FlatStyle = FlatStyle.Popup;
            buttonDebtAverage_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonDebtAverage_AAF.Location = new Point(180, 49);
            buttonDebtAverage_AAF.Name = "buttonDebtAverage_AAF";
            buttonDebtAverage_AAF.Size = new Size(168, 47);
            buttonDebtAverage_AAF.TabIndex = 3;
            buttonDebtAverage_AAF.Text = "Средняя квартплата";
            buttonDebtAverage_AAF.UseVisualStyleBackColor = false;
            buttonDebtAverage_AAF.Click += buttonDebtAverage_AAF_Click;
            // 
            // buttonDebtMaximum_AAF
            // 
            buttonDebtMaximum_AAF.BackColor = SystemColors.ActiveCaption;
            buttonDebtMaximum_AAF.FlatStyle = FlatStyle.Popup;
            buttonDebtMaximum_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonDebtMaximum_AAF.Location = new Point(6, 49);
            buttonDebtMaximum_AAF.Name = "buttonDebtMaximum_AAF";
            buttonDebtMaximum_AAF.Size = new Size(168, 47);
            buttonDebtMaximum_AAF.TabIndex = 2;
            buttonDebtMaximum_AAF.Text = "Максимальная квартплата";
            buttonDebtMaximum_AAF.UseVisualStyleBackColor = false;
            buttonDebtMaximum_AAF.Click += buttonDebtMaximum_AAF_Click;
            // 
            // textBoxApartmentsResult_AAF
            // 
            textBoxApartmentsResult_AAF.Location = new Point(248, 23);
            textBoxApartmentsResult_AAF.Name = "textBoxApartmentsResult_AAF";
            textBoxApartmentsResult_AAF.ReadOnly = true;
            textBoxApartmentsResult_AAF.Size = new Size(200, 23);
            textBoxApartmentsResult_AAF.TabIndex = 3;
            // 
            // dataGridViewApartments_AAF
            // 
            dataGridViewApartments_AAF.BackgroundColor = Color.RosyBrown;
            dataGridViewApartments_AAF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewApartments_AAF.Location = new Point(87, 72);
            dataGridViewApartments_AAF.Name = "dataGridViewApartments_AAF";
            dataGridViewApartments_AAF.Size = new Size(1102, 239);
            dataGridViewApartments_AAF.TabIndex = 3;
            dataGridViewApartments_AAF.CellContentClick += dataGridViewApartments_AAF_CellContentClick;
            // 
            // openFileDialogCSV_AAF
            // 
            openFileDialogCSV_AAF.FileName = "openFileDialogCSV_AAF";
            // 
            // FormApartments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundimage_AAF;
            ClientSize = new Size(1196, 529);
            Controls.Add(groupBoxApartmentsSettings_AAF);
            Controls.Add(groupBoxApartmentsCalculation_AAF);
            Controls.Add(dataGridViewApartments_AAF);
            Name = "FormApartments";
            Text = "Квартиры";
            Load += FormApartments_Load;
            groupBoxApartmentsSettings_AAF.ResumeLayout(false);
            groupBoxApartmentsSettings_AAF.PerformLayout();
            groupBoxApartmentsCalculation_AAF.ResumeLayout(false);
            groupBoxApartmentsCalculation_AAF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApartments_AAF).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private GroupBox groupBoxApartmentsSettings_AAF;
        private TextBox textBoxApartmentsFindValue_AAF;
        private Button buttonApartmentsExit_AAF;
        private Button buttonExportCSVApartments_AAF;
        private Button buttonApartmentsDeleteRow_AAF;
        private Button buttonApartmentsAddRow_AAF;
        private Button buttonFindValueApartments_AAF;
        private GroupBox groupBoxApartmentsCalculation_AAF;
        private Button buttonDebtSum_AAF;
        private Button buttonDebtMinimum_AAF;
        private Button buttonDebtAverage_AAF;
        private Button buttonDebtMaximum_AAF;
        private TextBox textBoxApartmentsResult_AAF;
        private DataGridView dataGridViewApartments_AAF;
        private OpenFileDialog openFileDialogCSV_AAF;
        private Button buttonSumSqr_AAF;
        private Button buttonAverageSqr_AAF;
        private Button buttonMinSqr_AAF;
        private Button buttonMaxSqr_AAF;
    }
}