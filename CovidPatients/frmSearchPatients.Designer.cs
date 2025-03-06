namespace CovidPatients
{
    partial class frmSearchPatients
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
            lstPatients = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader0 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstPatients
            // 
            lstPatients.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader0, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lstPatients.FullRowSelect = true;
            lstPatients.GridLines = true;
            lstPatients.Location = new Point(2, 12);
            lstPatients.MultiSelect = false;
            lstPatients.Name = "lstPatients";
            lstPatients.ShowGroups = false;
            lstPatients.Size = new Size(749, 300);
            lstPatients.TabIndex = 0;
            lstPatients.UseCompatibleStateImageBehavior = false;
            lstPatients.View = View.Details;
            lstPatients.SelectedIndexChanged += lstPatients_SelectedIndexChanged;
            lstPatients.DoubleClick += lstPatients_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "PatientId";
            columnHeader1.Width = 0;
            // 
            // columnHeader0
            // 
            columnHeader0.Text = "Name";
            columnHeader0.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Id No";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "DOB";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Gender";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Country";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Is Active";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 367);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // frmSearchPatients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 450);
            Controls.Add(label1);
            Controls.Add(lstPatients);
            Name = "frmSearchPatients";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "SearchPatients";
            Load += frmSearchPatients_Load;
            DoubleClick += frmSearchPatients_DoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstPatients;
        private ColumnHeader columnHeader0;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label1;
    }
}