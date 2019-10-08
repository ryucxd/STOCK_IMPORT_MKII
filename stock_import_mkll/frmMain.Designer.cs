namespace stock_import_mkll
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.btn_add_csv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.progression = new System.Windows.Forms.ProgressBar();
            this.lbl_prog = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_check_csv = new System.Windows.Forms.Button();
            this.txt_csv_location = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_department
            // 
            this.cmb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_department.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Location = new System.Drawing.Point(142, 8);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(121, 23);
            this.cmb_department.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "TYPE of Stock Take";
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(142, 40);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(121, 23);
            this.cmb_type.TabIndex = 2;
            // 
            // btn_add_csv
            // 
            this.btn_add_csv.Location = new System.Drawing.Point(12, 87);
            this.btn_add_csv.Name = "btn_add_csv";
            this.btn_add_csv.Size = new System.Drawing.Size(75, 23);
            this.btn_add_csv.TabIndex = 4;
            this.btn_add_csv.Text = "Add CSV";
            this.btn_add_csv.UseVisualStyleBackColor = true;
            this.btn_add_csv.Click += new System.EventHandler(this.Btn_add_csv_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(688, 300);
            this.dataGridView1.TabIndex = 5;
            // 
            // progression
            // 
            this.progression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progression.Location = new System.Drawing.Point(93, 87);
            this.progression.Name = "progression";
            this.progression.Size = new System.Drawing.Size(255, 23);
            this.progression.TabIndex = 6;
            this.progression.Visible = false;
            // 
            // lbl_prog
            // 
            this.lbl_prog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_prog.AutoSize = true;
            this.lbl_prog.Location = new System.Drawing.Point(160, 71);
            this.lbl_prog.Name = "lbl_prog";
            this.lbl_prog.Size = new System.Drawing.Size(72, 13);
            this.lbl_prog.TabIndex = 7;
            this.lbl_prog.Text = "CSV Location";
            this.lbl_prog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(435, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 114);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_check_csv
            // 
            this.btn_check_csv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check_csv.Location = new System.Drawing.Point(354, 87);
            this.btn_check_csv.Name = "btn_check_csv";
            this.btn_check_csv.Size = new System.Drawing.Size(75, 23);
            this.btn_check_csv.TabIndex = 9;
            this.btn_check_csv.Text = "Check CSV";
            this.btn_check_csv.UseVisualStyleBackColor = true;
            // 
            // txt_csv_location
            // 
            this.txt_csv_location.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_csv_location.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_csv_location.Location = new System.Drawing.Point(93, 87);
            this.txt_csv_location.Name = "txt_csv_location";
            this.txt_csv_location.Size = new System.Drawing.Size(255, 23);
            this.txt_csv_location.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 428);
            this.Controls.Add(this.btn_check_csv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_prog);
            this.Controls.Add(this.progression);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_add_csv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_department);
            this.Controls.Add(this.txt_csv_location);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Stock";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Button btn_add_csv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ProgressBar progression;
        private System.Windows.Forms.Label lbl_prog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_check_csv;
        private System.Windows.Forms.TextBox txt_csv_location;
    }
}

