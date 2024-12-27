namespace Tyuiu.AlshinAF.Sprint7.Project.V7
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button3 = new Button();
            buttonClients_AAF = new Button();
            buttonApartments_AAF = new Button();
            buttonInfo_AAF = new Button();
            labelMain_AAF = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.backpanel_AAF;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(buttonClients_AAF);
            panel1.Controls.Add(buttonApartments_AAF);
            panel1.Location = new Point(22, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 436);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSlateBlue;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(38, 215);
            button3.Name = "button3";
            button3.Size = new Size(156, 50);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // buttonClients_AAF
            // 
            buttonClients_AAF.BackColor = Color.MediumSlateBlue;
            buttonClients_AAF.FlatStyle = FlatStyle.Popup;
            buttonClients_AAF.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonClients_AAF.Location = new Point(38, 142);
            buttonClients_AAF.Name = "buttonClients_AAF";
            buttonClients_AAF.Size = new Size(156, 54);
            buttonClients_AAF.TabIndex = 2;
            buttonClients_AAF.Text = "КЛИЕНТЫ";
            buttonClients_AAF.UseVisualStyleBackColor = false;
            buttonClients_AAF.Click += buttonClients_AAF_Click;
            // 
            // buttonApartments_AAF
            // 
            buttonApartments_AAF.BackColor = Color.MediumSlateBlue;
            buttonApartments_AAF.FlatStyle = FlatStyle.Popup;
            buttonApartments_AAF.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonApartments_AAF.Location = new Point(38, 70);
            buttonApartments_AAF.Name = "buttonApartments_AAF";
            buttonApartments_AAF.Size = new Size(156, 52);
            buttonApartments_AAF.TabIndex = 1;
            buttonApartments_AAF.Text = "КВАРТИРЫ";
            buttonApartments_AAF.UseVisualStyleBackColor = false;
            buttonApartments_AAF.Click += buttonApartments_AAF_Click;
            // 
            // buttonInfo_AAF
            // 
            buttonInfo_AAF.BackColor = Color.Gold;
            buttonInfo_AAF.FlatStyle = FlatStyle.Popup;
            buttonInfo_AAF.Location = new Point(676, 458);
            buttonInfo_AAF.Name = "buttonInfo_AAF";
            buttonInfo_AAF.Size = new Size(156, 51);
            buttonInfo_AAF.TabIndex = 4;
            buttonInfo_AAF.Text = "Об разработчике и программе";
            buttonInfo_AAF.UseVisualStyleBackColor = false;
            buttonInfo_AAF.Click += buttonInfo_AAF_Click;
            // 
            // labelMain_AAF
            // 
            labelMain_AAF.AutoSize = true;
            labelMain_AAF.BackColor = Color.Transparent;
            labelMain_AAF.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelMain_AAF.ForeColor = Color.White;
            labelMain_AAF.Location = new Point(462, 26);
            labelMain_AAF.Name = "labelMain_AAF";
            labelMain_AAF.Size = new Size(277, 35);
            labelMain_AAF.TabIndex = 5;
            labelMain_AAF.Text = "ДОМОУПРАВЛЕНИЕ";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundimage_AAF;
            ClientSize = new Size(844, 521);
            Controls.Add(buttonInfo_AAF);
            Controls.Add(labelMain_AAF);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Проект | Вариант 7 | Альшин А. Ф.";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonApartments_AAF;
        private Button buttonInfo_AAF;
        private Button button3;
        private Button buttonClients_AAF;
        private Label labelMain_AAF;
    }
}
