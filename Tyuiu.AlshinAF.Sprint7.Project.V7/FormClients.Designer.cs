namespace Tyuiu.AlshinAF.Sprint7.Project.V7
{
    partial class FormClients
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
            dataGridViewClients_AAF = new DataGridView();
            groupBoxClientsCalculation_AAF = new GroupBox();
            buttonDebtSum_AAF = new Button();
            buttonDebtMinimum_AAF = new Button();
            buttonDebtAverage_AAF = new Button();
            buttonDebtMaximum_AAF = new Button();
            textBoxClientsResult_AAF = new TextBox();
            groupBoxClientsSettings_AAF = new GroupBox();
            textBoxClientsFindValue_AAF = new TextBox();
            buttonClientsExit_AAF = new Button();
            buttonExportCSVClients_AAF = new Button();
            buttonClientDeleteRow_AAF = new Button();
            buttonClientsAddRow_AAF = new Button();
            buttonFindValueClients_AAF = new Button();
            openFileDialogMatrix_AAF = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients_AAF).BeginInit();
            groupBoxClientsCalculation_AAF.SuspendLayout();
            groupBoxClientsSettings_AAF.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewClients_AAF
            // 
            dataGridViewClients_AAF.BackgroundColor = Color.RosyBrown;
            dataGridViewClients_AAF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients_AAF.Location = new Point(88, 27);
            dataGridViewClients_AAF.Name = "dataGridViewClients_AAF";
            dataGridViewClients_AAF.Size = new Size(885, 239);
            dataGridViewClients_AAF.TabIndex = 0;
            dataGridViewClients_AAF.CellContentClick += dataGridViewClients_AAF_CellContentClick;
            // 
            // groupBoxClientsCalculation_AAF
            // 
            groupBoxClientsCalculation_AAF.BackgroundImage = Properties.Resources.backgroundimage_AAF;
            groupBoxClientsCalculation_AAF.Controls.Add(buttonDebtSum_AAF);
            groupBoxClientsCalculation_AAF.Controls.Add(buttonDebtMinimum_AAF);
            groupBoxClientsCalculation_AAF.Controls.Add(buttonDebtAverage_AAF);
            groupBoxClientsCalculation_AAF.Controls.Add(buttonDebtMaximum_AAF);
            groupBoxClientsCalculation_AAF.Controls.Add(textBoxClientsResult_AAF);
            groupBoxClientsCalculation_AAF.ForeColor = SystemColors.ButtonHighlight;
            groupBoxClientsCalculation_AAF.Location = new Point(608, 272);
            groupBoxClientsCalculation_AAF.Name = "groupBoxClientsCalculation_AAF";
            groupBoxClientsCalculation_AAF.Size = new Size(365, 191);
            groupBoxClientsCalculation_AAF.TabIndex = 1;
            groupBoxClientsCalculation_AAF.TabStop = false;
            groupBoxClientsCalculation_AAF.Text = "Вычисления";
            // 
            // buttonDebtSum_AAF
            // 
            buttonDebtSum_AAF.BackColor = SystemColors.ActiveCaption;
            buttonDebtSum_AAF.FlatStyle = FlatStyle.Popup;
            buttonDebtSum_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonDebtSum_AAF.Location = new Point(191, 121);
            buttonDebtSum_AAF.Name = "buttonDebtSum_AAF";
            buttonDebtSum_AAF.Size = new Size(168, 47);
            buttonDebtSum_AAF.TabIndex = 5;
            buttonDebtSum_AAF.Text = "Общая задолженность";
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
            buttonDebtMinimum_AAF.Text = "Минимальная задолженность";
            buttonDebtMinimum_AAF.UseVisualStyleBackColor = false;
            buttonDebtMinimum_AAF.Click += buttonDebtMinimum_AAF_Click;
            // 
            // buttonDebtAverage_AAF
            // 
            buttonDebtAverage_AAF.BackColor = SystemColors.ActiveCaption;
            buttonDebtAverage_AAF.FlatStyle = FlatStyle.Popup;
            buttonDebtAverage_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonDebtAverage_AAF.Location = new Point(191, 49);
            buttonDebtAverage_AAF.Name = "buttonDebtAverage_AAF";
            buttonDebtAverage_AAF.Size = new Size(168, 47);
            buttonDebtAverage_AAF.TabIndex = 3;
            buttonDebtAverage_AAF.Text = "Средняя задолженность";
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
            buttonDebtMaximum_AAF.Text = "Максимальная задолженность";
            buttonDebtMaximum_AAF.UseVisualStyleBackColor = false;
            buttonDebtMaximum_AAF.Click += buttonDebtMaximum_AAF_Click;
            // 
            // textBoxClientsResult_AAF
            // 
            textBoxClientsResult_AAF.Location = new Point(79, 20);
            textBoxClientsResult_AAF.Name = "textBoxClientsResult_AAF";
            textBoxClientsResult_AAF.ReadOnly = true;
            textBoxClientsResult_AAF.Size = new Size(200, 23);
            textBoxClientsResult_AAF.TabIndex = 3;
            // 
            // groupBoxClientsSettings_AAF
            // 
            groupBoxClientsSettings_AAF.BackgroundImage = Properties.Resources.backgroundimage_AAF;
            groupBoxClientsSettings_AAF.Controls.Add(textBoxClientsFindValue_AAF);
            groupBoxClientsSettings_AAF.Controls.Add(buttonClientsExit_AAF);
            groupBoxClientsSettings_AAF.Controls.Add(buttonExportCSVClients_AAF);
            groupBoxClientsSettings_AAF.Controls.Add(buttonClientDeleteRow_AAF);
            groupBoxClientsSettings_AAF.Controls.Add(buttonClientsAddRow_AAF);
            groupBoxClientsSettings_AAF.Controls.Add(buttonFindValueClients_AAF);
            groupBoxClientsSettings_AAF.ForeColor = SystemColors.ButtonHighlight;
            groupBoxClientsSettings_AAF.Location = new Point(88, 272);
            groupBoxClientsSettings_AAF.Name = "groupBoxClientsSettings_AAF";
            groupBoxClientsSettings_AAF.Size = new Size(392, 191);
            groupBoxClientsSettings_AAF.TabIndex = 2;
            groupBoxClientsSettings_AAF.TabStop = false;
            groupBoxClientsSettings_AAF.Text = "Настройки";
            // 
            // textBoxClientsFindValue_AAF
            // 
            textBoxClientsFindValue_AAF.Location = new Point(6, 23);
            textBoxClientsFindValue_AAF.Name = "textBoxClientsFindValue_AAF";
            textBoxClientsFindValue_AAF.Size = new Size(159, 23);
            textBoxClientsFindValue_AAF.TabIndex = 4;
            // 
            // buttonClientsExit_AAF
            // 
            buttonClientsExit_AAF.BackColor = Color.Red;
            buttonClientsExit_AAF.FlatStyle = FlatStyle.Popup;
            buttonClientsExit_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonClientsExit_AAF.Location = new Point(6, 148);
            buttonClientsExit_AAF.Name = "buttonClientsExit_AAF";
            buttonClientsExit_AAF.Size = new Size(159, 23);
            buttonClientsExit_AAF.TabIndex = 10;
            buttonClientsExit_AAF.Text = "Выйти";
            buttonClientsExit_AAF.UseVisualStyleBackColor = false;
            buttonClientsExit_AAF.Click += buttonClientsExit_AAF_Click;
            // 
            // buttonExportCSVClients_AAF
            // 
            buttonExportCSVClients_AAF.BackColor = SystemColors.ActiveBorder;
            buttonExportCSVClients_AAF.FlatStyle = FlatStyle.Popup;
            buttonExportCSVClients_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonExportCSVClients_AAF.Location = new Point(6, 119);
            buttonExportCSVClients_AAF.Name = "buttonExportCSVClients_AAF";
            buttonExportCSVClients_AAF.Size = new Size(159, 23);
            buttonExportCSVClients_AAF.TabIndex = 9;
            buttonExportCSVClients_AAF.Text = "Экспорт и сохранение";
            buttonExportCSVClients_AAF.UseVisualStyleBackColor = false;
            buttonExportCSVClients_AAF.Click += buttonExportCSVClients_AAF_Click;
            // 
            // buttonClientDeleteRow_AAF
            // 
            buttonClientDeleteRow_AAF.BackColor = Color.IndianRed;
            buttonClientDeleteRow_AAF.FlatStyle = FlatStyle.Popup;
            buttonClientDeleteRow_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonClientDeleteRow_AAF.Location = new Point(6, 90);
            buttonClientDeleteRow_AAF.Name = "buttonClientDeleteRow_AAF";
            buttonClientDeleteRow_AAF.Size = new Size(159, 23);
            buttonClientDeleteRow_AAF.TabIndex = 8;
            buttonClientDeleteRow_AAF.Text = "Удалить строку";
            buttonClientDeleteRow_AAF.UseVisualStyleBackColor = false;
            buttonClientDeleteRow_AAF.Click += buttonClientDeleteRow_AAF_Click;
            // 
            // buttonClientsAddRow_AAF
            // 
            buttonClientsAddRow_AAF.BackColor = Color.YellowGreen;
            buttonClientsAddRow_AAF.FlatStyle = FlatStyle.Popup;
            buttonClientsAddRow_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonClientsAddRow_AAF.Location = new Point(6, 61);
            buttonClientsAddRow_AAF.Name = "buttonClientsAddRow_AAF";
            buttonClientsAddRow_AAF.Size = new Size(159, 23);
            buttonClientsAddRow_AAF.TabIndex = 7;
            buttonClientsAddRow_AAF.Text = "Добавить строку";
            buttonClientsAddRow_AAF.UseVisualStyleBackColor = false;
            buttonClientsAddRow_AAF.Click += buttonClientsAddRow_AAF_Click;
            // 
            // buttonFindValueClients_AAF
            // 
            buttonFindValueClients_AAF.BackColor = SystemColors.ActiveCaption;
            buttonFindValueClients_AAF.FlatStyle = FlatStyle.Popup;
            buttonFindValueClients_AAF.ForeColor = SystemColors.ActiveCaptionText;
            buttonFindValueClients_AAF.Location = new Point(171, 22);
            buttonFindValueClients_AAF.Name = "buttonFindValueClients_AAF";
            buttonFindValueClients_AAF.Size = new Size(170, 23);
            buttonFindValueClients_AAF.TabIndex = 6;
            buttonFindValueClients_AAF.Text = "Найти значение";
            buttonFindValueClients_AAF.UseVisualStyleBackColor = false;
            buttonFindValueClients_AAF.Click += buttonFindValueClients_AAF_Click;
            // 
            // openFileDialogMatrix_AAF
            // 
            openFileDialogMatrix_AAF.FileName = "openFileDialogMatrix_AAF";
            openFileDialogMatrix_AAF.FileOk += openFileDialogMatrix_AAF_FileOk;
            // 
            // FormClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundimage_AAF;
            ClientSize = new Size(1059, 580);
            Controls.Add(groupBoxClientsSettings_AAF);
            Controls.Add(groupBoxClientsCalculation_AAF);
            Controls.Add(dataGridViewClients_AAF);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormClients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Клиенты";
            Load += FormClients_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients_AAF).EndInit();
            groupBoxClientsCalculation_AAF.ResumeLayout(false);
            groupBoxClientsCalculation_AAF.PerformLayout();
            groupBoxClientsSettings_AAF.ResumeLayout(false);
            groupBoxClientsSettings_AAF.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewClients_AAF;
        private GroupBox groupBoxClientsCalculation_AAF;
        private Button buttonDebtMaximum_AAF;
        private Button buttonDebtMinimum_AAF;
        private Button buttonDebtAverage_AAF;
        private Button buttonDebtSum_AAF;
        private GroupBox groupBoxClientsSettings_AAF;
        private Button buttonClientDeleteRow_AAF;
        private Button buttonClientsAddRow_AAF;
        private Button buttonFindValueClients_AAF;
        private TextBox textBoxClientsResult_AAF;
        private Button buttonExportCSVClients_AAF;
        private Button buttonClientsExit_AAF;
        private OpenFileDialog openFileDialogMatrix_AAF;
        private TextBox textBoxClientsFindValue_AAF;
    }
}