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
    public partial class frmMain : Form
    {
        //props
        public int[] rowIndex = new int[20];
        public int arrayIndex { get; set; }
        public int multiple_csv_check { get; set; }
        public int progression_complete { get; set; }
        public DataTable extendedDataTable { get; set; }
        public int datatableCount { get; set; }
        public DataTable fixedStockCodeDT { get; set; }
        public frmMain()
        {
            InitializeComponent();
            //add combobox text
            cmb_department.Items.Add("Traditional");
            cmb_department.Items.Add("Slimline");
            //
            cmb_type.Items.Add("Full");
            cmb_type.Items.Add("Partial");
            cmb_type.Items.Add("Incremental");
            datatableCount = 0;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void format()
        {
            //datagridview formatting
        }

        private void Btn_add_csv_Click(object sender, EventArgs e)
        {
            datatableCount = 0;
            //select DEPARTMENT and TYPE before adding csv
            if (string.IsNullOrEmpty(cmb_department.Text) || string.IsNullOrEmpty(cmb_type.Text))
            {
                MessageBox.Show("Please Select the Department and TYPE of Stock Take.", "Missing Information", MessageBoxButtons.OK);
                return;
            }
            //lock the cmb boxes
            cmb_department.Enabled = false;
            cmb_type.Enabled = false;

            //start loading csv#
            string csv1;
            OpenFileDialog openFileName = new OpenFileDialog();
            openFileName.FilterIndex = 1;
            openFileName.RestoreDirectory = true;

            if (openFileName.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txt_csv_location.Text = openFileName.FileName;
                    csv1 = openFileName.FileName;

                }
                catch
                {
                    MessageBox.Show("Error loading file, please check the filetype is correct.");
                    csv1 = "Error!";
                }
            }
            else
                csv1 = "Error";
            //1 or 2
            if (multiple_csv_check != 1)
                csv_import(csv1);
            else
                csv_append(csv1);
        }

        //csv voids
        private void csv_import(string fileName)
        {
            //initialise DT and add columns
            fixedStockCodeDT = new DataTable();
            fixedStockCodeDT.Columns.AddRange(new[] {
                    new DataColumn ("item Code"),
                    new DataColumn ("item name"),
                    new DataColumn ("QTY"),
                    new DataColumn ("UoM"),
                    new DataColumn ("Location"),
                    new DataColumn ("TimeStamp")
                });
            //first csv
            string textLine = string.Empty;
            string[] splitline;

            dataGridView1.SuspendLayout();

            var data = new DataTable();
            data.Columns.AddRange(new[]
            {
                new DataColumn ("item Code"),
                new DataColumn ("item name"),
                new DataColumn ("QTY"),
                new DataColumn ("UoM"),
                new DataColumn ("Location"),
                new DataColumn ("TimeStamp")
            });

            data.Rows.Clear();
            //read file
            if (System.IO.File.Exists(fileName))
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(fileName);
                var contents = reader.ReadToEnd();
                var strReader = new System.IO.StringReader(contents);
                strReader.ReadLine();

                do
                {
                    textLine = strReader.ReadLine();
                    if (textLine == null)
                        ;//MessageBox.Show("its null bruh");
                    else
                    {
                        splitline = textLine.Split(';');
                        if (splitline[0] != string.Empty || splitline[1] != string.Empty)
                            data.Rows.Add(splitline);
                    }
                } while (strReader.Peek() >= 1);
            }

            //add it to the DGV
            dataGridView1.DataSource = data;
            extendedDataTable = data;
            //add missing descriptions
            missingDescription(); // it also adds it to the prop in this function 


            //dont allow the user to fall into csv import again
            multiple_csv_check = 1;
            //flag suspicious values
            stockValidation();
        }

        private void csv_append(string fileName)
        {
            //initialise DT and add columns
            fixedStockCodeDT = new DataTable();
            fixedStockCodeDT.Columns.AddRange(new[] {
                    new DataColumn ("item Code"),
                    new DataColumn ("item name"),
                    new DataColumn ("QTY"),
                    new DataColumn ("UoM"),
                    new DataColumn ("Location"),
                    new DataColumn ("TimeStamp")
                });
            //second csv and up
            MessageBox.Show("entered csv append ");
            string textLine = string.Empty;
            string[] splitLine;
            DataTable dt = new DataTable();
            //add current dgv to this
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dt.Columns.Add("column" + i.ToString());
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dr = dt.NewRow();
                for (int z = 0; z < dataGridView1.Columns.Count; z++)
                {
                    dr["column" + z.ToString()] = row.Cells[z].Value;
                }
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            //should only add as there is no clear
            if (System.IO.File.Exists(fileName))
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(fileName);
                var contents = reader.ReadToEnd();
                var strReader = new System.IO.StringReader(contents);
                strReader.ReadLine();

                do
                {
                    textLine = strReader.ReadLine();
                    if (textLine != string.Empty)
                    {
                        splitLine = textLine.Split(';');
                        if (splitLine[0] != string.Empty || splitLine[1] != string.Empty)
                        {
                            dt.Rows.Add(splitLine);
                        }
                    }

                } while (strReader.Peek() != -1);
            }
            dataGridView1.DataSource = dt;
            extendedDataTable = null;
            extendedDataTable = dt;
            missingDescription();
            stockValidation();
        }


        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void missingDescription()
        {
            int elseLoop = 0;
            

            lbl_prog.Text = "Adding missing descriptions...";
            //this is a bit overkill but none the less
            string sql = "";
            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (IsDigitsOnly(dataGridView1.Rows[row.Index].Cells[0].Value.ToString()) == true && (dataGridView1.Rows[row.Index].Cells[0].Value.ToString().Length) >0 )
                    {
                        sql = "SELECT [description] FROM dbo.stock WHERE stock_code = " + dataGridView1.Rows[row.Index].Cells[0].Value.ToString();
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            string missingData = "";
                            conn.Open();
                            missingData = Convert.ToString(cmd.ExecuteScalar());
                            conn.Close();
                            dataGridView1.Rows[row.Index].Cells[1].Value = missingData;
                        }
                    }
                    else
                    {
                        elseLoop = 1;
                        //keep track of which rows need to be changed
                        rowIndex[arrayIndex] = row.Index;
                        arrayIndex++;
                        //add to DT to pass over
                        DataTable data = new DataTable();
                        data.Rows.Add();
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            data.Columns.Add("column" + i.ToString());
                        data.Rows[0][0] = dataGridView1.Rows[row.Index].Cells[0].Value;
                        data.Rows[0][1] = dataGridView1.Rows[row.Index].Cells[1].Value;
                        data.Rows[0][2] = dataGridView1.Rows[row.Index].Cells[2].Value;
                        data.Rows[0][3] = dataGridView1.Rows[row.Index].Cells[3].Value;
                        data.Rows[0][4] = dataGridView1.Rows[row.Index].Cells[4].Value;
                        data.Rows[0][5] = dataGridView1.Rows[row.Index].Cells[5].Value;
                        //openform
                        frmFixStockCode frm = new frmFixStockCode(data);
                        frm.ShowDialog();
                        //add new vaLUes to dt if its not null
                        
                        if ((GlobalVariables.col0.Length) > 0)
                        {
                            fixedStockCodeDT.Rows.Add();
                            fixedStockCodeDT.Rows[datatableCount][0] = GlobalVariables.col0;
                            fixedStockCodeDT.Rows[datatableCount][1] = GlobalVariables.col1;
                            fixedStockCodeDT.Rows[datatableCount][2] = GlobalVariables.col2;
                            fixedStockCodeDT.Rows[datatableCount][3] = GlobalVariables.col3;
                            fixedStockCodeDT.Rows[datatableCount][4] = GlobalVariables.col4;
                            fixedStockCodeDT.Rows[datatableCount][5] = GlobalVariables.col5;
                            datatableCount++;
                        }


                    }
                }
                //delete rowindex and add new table
                if (elseLoop == 1)
                {
                    int adjust = 0;
                    for (int i = 0; i < arrayIndex; i++)
                    {
                       // MessageBox.Show("dgv count -> " + dataGridView1.Rows.Count.ToString());
                        //MessageBox.Show("array index -> " + rowIndex[i].ToString());
                        dataGridView1.Rows.RemoveAt(rowIndex[i] - adjust);
                        adjust++;
                    }
                    //if (fixedStockCodeDT.Rows.Count > 0)
                    //{
                    //    extendedDataTable.Rows.Clear();
                    //    foreach (DataGridViewRow row in dataGridView1.Rows)
                    //    {
                    //        DataRow DR = extendedDataTable.NewRow();
                    //        foreach (DataGridViewCell cell in row.Cells)
                    //            DR[cell.ColumnIndex] = cell.Value;
                    //        extendedDataTable.Rows.Add(DR);
                    //    }
                    //    //extendedDataTable.Merge(fixedStockCodeDT);
                    //    dataGridView1.DataSource = extendedDataTable;
                    //    fixedStockCodeDT = null;
                    //  //  missingDescription();
                    //}

                }
            }


            //add it to prop
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dataGridView1.Columns)
                dt.Columns.Add(col.Name);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                    dRow[cell.ColumnIndex] = cell.Value;
                dt.Rows.Add(dRow);
            }
            extendedDataTable = dt;
            extendedDataTable.Merge(fixedStockCodeDT);

            fixedStockCodeDT = null;
            fixedStockCodeDT = new DataTable();
            fixedStockCodeDT.Columns.AddRange(new[] {
                    new DataColumn ("item Code"),
                    new DataColumn ("item name"),
                    new DataColumn ("QTY"),
                    new DataColumn ("UoM"),
                    new DataColumn ("Location"),
                    new DataColumn ("TimeStamp")
                });

            //also maybe add the else loop thing here instead // else loop 0; If loop = 1 then reply this section
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
            }
            
            dataGridView1.DataSource = extendedDataTable;
            if (elseLoop == 1)
            {
                elseLoop = 0;
                missingDescription();
            }
            elseLoop = 0;
            return;
        }

        private void stockValidation()
        {
            return;
            lbl_prog.Text = "Checking for Errors...";
            //work out cost of each stock entered and if it is above X value then trigger a warning.
            using (SqlConnection conn = new SqlConnection(CONNECT.ConnectionString))
            {
                progression.Show();
                progression.Value = 0;
                progression_complete = dataGridView1.Rows.Count;
                progression.Maximum = progression_complete;
                decimal price;
                int isYellow = 0;
                int isRed = 0;
                string temp;
                decimal total_price;
                decimal quantity;
                conn.Open();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // MessageBox.Show(row.Cells[0].Value.ToString());
                    string sql_price = "SELECT [cost_price] from [dbo].[stock] where [stock_code] = '" + row.Cells[0].Value + "'";
                    // MessageBox.Show(sql_price);
                    using (SqlCommand cmd = new SqlCommand(sql_price, conn))
                    {

                        //  MessageBox.Show("it is open");
                        try
                        {

                            price = Convert.ToDecimal(cmd.ExecuteScalar());
                        }
                        catch
                        {
                            price = 0;
                        }
                        //   MessageBox.Show(price.ToString());




                        if (conn.State == ConnectionState.Closed)
                            MessageBox.Show("Connection error!");
                        // MessageBox.Show(dataGridView1.Rows[row].Cells[2].Value.ToString());
                        temp = (row.Cells[2].Value.ToString());
                        quantity = decimal.Parse(temp);

                        if (quantity > 5000) //THIS IS THE CRITERIA THAT CAN BE CHANGED
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            isYellow = isYellow + 1;
                            //MessageBox.Show("Total quantity" + quantity.ToString());
                        }
                        total_price = quantity * price;

                        if ((quantity * price) > 5000) // THIS ONE TOO
                        {
                            //  MessageBox.Show("Total price = " +total_price.ToString());
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            isYellow = isYellow + 1;
                        }

                        if (dataGridView1.Rows[row.Index].Cells[0].Value.ToString().Length > 4)
                        {
                            isRed = isRed + 1;
                            row.DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                    progression.Value = progression.Value + 1;
                }
                btn_check_csv.Show();
                if (isYellow > 0)
                    MessageBox.Show("There are " + isYellow.ToString() + " entries that have triggered warnings. Please click 'Check CSV' to amend these");
                if (isRed > 0)
                    MessageBox.Show("There are " + isRed.ToString() + "entries that have triggered ERRORS. Please click 'Check CSV' to remove these ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                progression.Hide();
                progression.Value = 0;
                lbl_prog.Text = "To fix any errors click 'Check CSV'!";
            }

        }

        private void Btn_check_csv_Click(object sender, EventArgs e)
        {

        }
    }
}
