﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_import_mkll
{
    public partial class frm_fixYellow : Form
    {
        public decimal _oldQuantity { get; set; }
        public decimal _newQuantity { get; set; }
        public int _overRide { get; set; }
        public int _QTY { get; set; }

        public int _delete { get; set; }
        public frm_fixYellow(int _stock, decimal _price, decimal _quantity, string description)
        {
            InitializeComponent();
            txt_qty.Select();
            _overRide = 0;
            _delete = 0;
            _QTY = 0;


            label1.Text = "Stock Code: " + _stock.ToString() + "   Description: " + description;
            label2.Text = "This has triggered warnings. Please enter the correct Value or override this with the password.";
            label3.Text = "The quantity for this item is: " + _quantity.ToString() + " and the Total price would have been: £" + _price.ToString();
            _oldQuantity = Math.Round(_quantity, 0);


        }

        private void Btn_amend_Click(object sender, EventArgs e)
        {
            if (txt_qty.TextLength > 0)
            {
                if (Convert.ToInt32(txt_qty.Text) <= _oldQuantity)
                {
                    _QTY = 1;
                    _newQuantity = Convert.ToInt32(txt_qty.Text.ToString());
                    this.Close();
                }
                else
                    MessageBox.Show("You cannot enter a value higher than the original count", "Error", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Please enter a number into the text box.", "no text", MessageBoxButtons.OK);
        }

        private void Btn_ignore_Click(object sender, EventArgs e)
        {
            //password is verified here
            if (GlobalVariables.isVerified == true)
            {
                _overRide = 1;
                this.Close();
            }
            else
            {
                frmPassword password = new frmPassword();
                password.ShowDialog();
                if (password._pass == 1)
                {
                    _overRide = 1;
                    this.Close();
                }
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "202", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _delete = 1;
                this.Close();
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This action will RESTART the app and you will lost any current progress.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
                Application.Restart();
            
        }
    }
}
