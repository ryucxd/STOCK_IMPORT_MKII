namespace stock_import_mkll
{
    partial class frm_fixYellow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_fixYellow));
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ignore = new System.Windows.Forms.Button();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.btn_amend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "The quantity for this item is: 1500 and the Total price would have been: 320";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(496, 83);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(107, 23);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // btn_ignore
            // 
            this.btn_ignore.Location = new System.Drawing.Point(234, 83);
            this.btn_ignore.Name = "btn_ignore";
            this.btn_ignore.Size = new System.Drawing.Size(107, 23);
            this.btn_ignore.TabIndex = 11;
            this.btn_ignore.Text = "Ignore warning";
            this.btn_ignore.UseVisualStyleBackColor = true;
            this.btn_ignore.Click += new System.EventHandler(this.Btn_ignore_Click);
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(15, 81);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(100, 20);
            this.txt_qty.TabIndex = 10;
            // 
            // btn_amend
            // 
            this.btn_amend.Location = new System.Drawing.Point(121, 81);
            this.btn_amend.Name = "btn_amend";
            this.btn_amend.Size = new System.Drawing.Size(107, 23);
            this.btn_amend.TabIndex = 9;
            this.btn_amend.Text = "Amend Quantity";
            this.btn_amend.UseVisualStyleBackColor = true;
            this.btn_amend.Click += new System.EventHandler(this.Btn_amend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "warnings etc\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stock Code: 3033  has triggered warnings. Please enter the correct Value or overr" +
    "ide this with the password.\"";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(383, 83);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 23);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete entry";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // frm_fixYellow
            // 
            this.AcceptButton = this.btn_amend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 116);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ignore);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.btn_amend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_fixYellow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Over Estimated Values";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ignore;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Button btn_amend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
    }
}