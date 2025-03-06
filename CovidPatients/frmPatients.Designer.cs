namespace CovidPatients
{
    partial class frmPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatients));
            txtName = new TextBox();
            lblName = new Label();
            txtIdNo = new TextBox();
            label1 = new Label();
            dtpDOB = new DateTimePicker();
            label2 = new Label();
            cmbGender = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtCountry = new TextBox();
            chkIsActive = new CheckBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(193, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(308, 31);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(26, 58);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // txtIdNo
            // 
            txtIdNo.Location = new Point(193, 118);
            txtIdNo.Name = "txtIdNo";
            txtIdNo.Size = new Size(150, 31);
            txtIdNo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 121);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 3;
            label1.Text = "Identity No";
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(193, 180);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(300, 31);
            dtpDOB.TabIndex = 4;
            dtpDOB.ValueChanged += dtpDOB_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 186);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 5;
            label2.Text = "D.O.B";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(193, 231);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(182, 33);
            cmbGender.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 234);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 7;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 283);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 8;
            label4.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(193, 283);
            txtCountry.Name = "txtCountry";
            txtCountry.ScrollBars = ScrollBars.Horizontal;
            txtCountry.Size = new Size(150, 31);
            txtCountry.TabIndex = 9;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(193, 344);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(104, 29);
            chkIsActive.TabIndex = 10;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 33);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 28);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(34, 28);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += openStripButton3_Click;
            // 
            // frmPatients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 523);
            Controls.Add(toolStrip1);
            Controls.Add(chkIsActive);
            Controls.Add(txtCountry);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbGender);
            Controls.Add(label2);
            Controls.Add(dtpDOB);
            Controls.Add(label1);
            Controls.Add(txtIdNo);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Name = "frmPatients";
            Text = "Patients";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private TextBox txtIdNo;
        private Label label1;
        private DateTimePicker dtpDOB;
        private Label label2;
        private ComboBox cmbGender;
        private Label label3;
        private Label label4;
        private TextBox txtCountry;
        private CheckBox chkIsActive;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
    }
}
