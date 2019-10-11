namespace stock_import_mkll
{
    partial class frmFixStockCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFixStockCode));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_itemName = new System.Windows.Forms.Button();
            this.btn_QTY = new System.Windows.Forms.Button();
            this.btn_uom = new System.Windows.Forms.Button();
            this.btn_location = new System.Windows.Forms.Button();
            this.btn_timeStamp = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "This entry does not have a valid \'Stock Code\'. Please select the correct one or d" +
    "elete it.";
            // 
            // btn_itemName
            // 
            this.btn_itemName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_itemName.Location = new System.Drawing.Point(135, 89);
            this.btn_itemName.Name = "btn_itemName";
            this.btn_itemName.Size = new System.Drawing.Size(75, 23);
            this.btn_itemName.TabIndex = 9;
            this.btn_itemName.Text = "Column 2";
            this.btn_itemName.UseVisualStyleBackColor = true;
            this.btn_itemName.Click += new System.EventHandler(this.Btn_itemName_Click);
            // 
            // btn_QTY
            // 
            this.btn_QTY.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QTY.Location = new System.Drawing.Point(256, 89);
            this.btn_QTY.Name = "btn_QTY";
            this.btn_QTY.Size = new System.Drawing.Size(75, 23);
            this.btn_QTY.TabIndex = 10;
            this.btn_QTY.Text = "Column 3";
            this.btn_QTY.UseVisualStyleBackColor = true;
            this.btn_QTY.Click += new System.EventHandler(this.Btn_QTY_Click);
            // 
            // btn_uom
            // 
            this.btn_uom.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uom.Location = new System.Drawing.Point(372, 89);
            this.btn_uom.Name = "btn_uom";
            this.btn_uom.Size = new System.Drawing.Size(75, 23);
            this.btn_uom.TabIndex = 11;
            this.btn_uom.Text = "Column 4";
            this.btn_uom.UseVisualStyleBackColor = true;
            this.btn_uom.Click += new System.EventHandler(this.Btn_uom_Click);
            // 
            // btn_location
            // 
            this.btn_location.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_location.Location = new System.Drawing.Point(486, 89);
            this.btn_location.Name = "btn_location";
            this.btn_location.Size = new System.Drawing.Size(75, 23);
            this.btn_location.TabIndex = 12;
            this.btn_location.Text = "Column 5";
            this.btn_location.UseVisualStyleBackColor = true;
            this.btn_location.Click += new System.EventHandler(this.Btn_location_Click);
            // 
            // btn_timeStamp
            // 
            this.btn_timeStamp.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timeStamp.Location = new System.Drawing.Point(603, 89);
            this.btn_timeStamp.Name = "btn_timeStamp";
            this.btn_timeStamp.Size = new System.Drawing.Size(75, 23);
            this.btn_timeStamp.TabIndex = 13;
            this.btn_timeStamp.Text = "Column 6";
            this.btn_timeStamp.UseVisualStyleBackColor = true;
            this.btn_timeStamp.Click += new System.EventHandler(this.Btn_timeStamp_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(9, 121);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(9, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(688, 44);
            this.dataGridView1.TabIndex = 15;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(570, 121);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(108, 23);
            this.btn_confirm.TabIndex = 16;
            this.btn_confirm.Text = "Confirm Changes";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.Btn_confirm_Click);
            // 
            // frmFixStockCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 156);
            this.ControlBox = false;
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_timeStamp);
            this.Controls.Add(this.btn_location);
            this.Controls.Add(this.btn_uom);
            this.Controls.Add(this.btn_QTY);
            this.Controls.Add(this.btn_itemName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFixStockCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fixing broken stock codes...";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_itemName;
        private System.Windows.Forms.Button btn_QTY;
        private System.Windows.Forms.Button btn_uom;
        private System.Windows.Forms.Button btn_location;
        private System.Windows.Forms.Button btn_timeStamp;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_confirm;
    }
}