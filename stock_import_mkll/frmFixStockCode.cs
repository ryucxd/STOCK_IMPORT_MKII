using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace stock_import_mkll
{
    public partial class frmFixStockCode : Form
    {
        public frmFixStockCode(DataTable dt)
        {
            InitializeComponent();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Item Code";
            dataGridView1.Columns[1].HeaderText = "Item Name";
            dataGridView1.Columns[2].HeaderText = "QTY";
            dataGridView1.Columns[3].HeaderText = "UoM";
            dataGridView1.Columns[4].HeaderText = "Location";
            dataGridView1.Columns[5].HeaderText = "TimeStamp";



        }

        private void swappable(int columnNumber)
        {
            string newStockCode = "";
            string oldStockCode = "";
            //get values
            newStockCode = dataGridView1.Rows[0].Cells[columnNumber].Value.ToString();
            oldStockCode = dataGridView1.Rows[0].Cells[0].Value.ToString();
            //swap values
            dataGridView1.Rows[0].Cells[columnNumber].Value = oldStockCode;
            dataGridView1.Rows[0].Cells[0].Value = newStockCode;
        }

        private void Btn_itemName_Click(object sender, EventArgs e)
        {
            //col2
            swappable(1);
        }

        private void Btn_QTY_Click(object sender, EventArgs e)
        {
            swappable(2);
        }

        private void Btn_uom_Click(object sender, EventArgs e)
        {
            swappable(3);
        }

        private void Btn_location_Click(object sender, EventArgs e)
        {
            swappable(4);
        }

        private void Btn_timeStamp_Click(object sender, EventArgs e)
        {
            swappable(5);
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to DELETE this entry?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                this.Close();
            else
                return;
        }

        private void Btn_confirm_Click(object sender, EventArgs e)
        {
            int valid = 0;
            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {
                string sql = "SELECT COUNT(stock_code) FROM dbo.stock WHERE stock_code ='" + dataGridView1.Rows[0].Cells[0].Value.ToString() + "'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    valid = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                }
            }
            if (valid != 0)
            {
                DialogResult result = MessageBox.Show("Are you sure the information lines up correctly?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //move it to DT and work out how to save it etc
                    GlobalVariables.col0 = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    GlobalVariables.col1 = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    GlobalVariables.col2 = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    GlobalVariables.col3 = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    GlobalVariables.col4 = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    GlobalVariables.col5 = dataGridView1.Rows[0].Cells[5].Value.ToString();

                    this.Close();
                }
                else
                    return;
            }
            else
                MessageBox.Show("That is not a valid stock code! If there is not one present then use delete"); //this needs to be much nicer
        }
    }

}
