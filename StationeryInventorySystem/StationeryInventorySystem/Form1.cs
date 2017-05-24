using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryInventorySystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            panelInvisible();
            PnlHome.Visible = true;

        }

        public void panelInvisible()
        {
            SrnPanel.Visible = false;
            ReportPanel.Visible = false;
            MsgPanel.Visible = false;
            MessagesLabel.Visible = false;
            StoreRequisitionNoteLabel.Visible = false;
            ReportHistoryLabel.Visible = false;
            AboutPanel.Visible = false;
            AboutLabel.Visible = false;
            PnlHome.Visible = false;
            GRNPanel.Visible = false;
            LblGRN.Visible = false;
            MsgList.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelInvisible();
            StoreRequisitionNoteLabel.Visible = true;
            SrnPanel.Visible = true;
            //hard coded sample data
            dataGridView1.ForeColor = Color.Blue;

            dataGridView1.Rows.Add(2);

            dataGridView1.Rows[0].Cells[0].Value ="Department of Industrial Management";
            dataGridView1.Rows[0].Cells[1].Value ="SRN0421";
            dataGridView1.Rows[0].Cells[2].Value ="High";
            dataGridView1.Rows[0].Cells[3].Value ="Please provide before sunday";

            dataGridView1.Rows[1].Cells[0].Value = "Department of Chemistry";
            dataGridView1.Rows[1].Cells[1].Value = "SRN0123";
            dataGridView1.Rows[1].Cells[2].Value = "Medium";
            dataGridView1.Rows[1].Cells[3].Value = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Current_Stock cs = new Current_Stock();
            cs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelInvisible();
            ReportHistoryLabel.Visible = true;
            ReportPanel.Visible = true;

            SRNHistoryTable.Rows.Add(2);

            SRNHistoryTable.Rows[0].Cells[0].Value = "SRN0421";
            SRNHistoryTable.Rows[0].Cells[1].Value = "Department of Industrial Management";
            SRNHistoryTable.Rows[0].Cells[2].Value = "12/04/2017";
            SRNHistoryTable.Rows[0].Cells[3].Value = "01/05/2017";

            SRNHistoryTable.Rows[1].Cells[0].Value = "SRN0421";
            SRNHistoryTable.Rows[1].Cells[1].Value = "Department of Industrial Management";
            SRNHistoryTable.Rows[1].Cells[2].Value = "10/03/2017";
            SRNHistoryTable.Rows[1].Cells[3].Value = "12/05/2017";

            dataGridView3.Rows.Add(2);

            dataGridView3.Rows[0].Cells[0].Value = "SRN0421";
            dataGridView3.Rows[0].Cells[1].Value = "Department of Industrial Management";
            dataGridView3.Rows[0].Cells[2].Value = "12/04/2017";
            dataGridView3.Rows[0].Cells[3].Value = "01/05/2017";

            dataGridView3.Rows[1].Cells[0].Value = "IO0421";
            dataGridView3.Rows[1].Cells[1].Value = "Department of Industrial Management";
            dataGridView3.Rows[1].Cells[2].Value = "10/03/2017";
            dataGridView3.Rows[1].Cells[3].Value = "12/05/2017";

            dataGridView4.Rows.Add(2);

            dataGridView4.Rows[0].Cells[0].Value = "GRN0421";
            dataGridView4.Rows[0].Cells[1].Value = "Department of Industrial Management";
            dataGridView4.Rows[0].Cells[2].Value = "12/04/2017";
            dataGridView4.Rows[0].Cells[3].Value = "01/05/2017";

            dataGridView4.Rows[1].Cells[0].Value = "SRN0421";
            dataGridView4.Rows[1].Cells[1].Value = "Department of Industrial Management";
            dataGridView4.Rows[1].Cells[2].Value = "10/03/2017";
            dataGridView4.Rows[1].Cells[3].Value = "12/05/2017";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelInvisible();
            MessagesLabel.Visible = true;
            MsgList.Visible = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelInvisible();
            AboutPanel.Visible = true;
            AboutLabel.Visible = true;

        }

        private void About_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Issue_Order io = new Issue_Order();
            io.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString()+","+ e.ColumnIndex.ToString());
            if(e.RowIndex==1 && e.ColumnIndex==1)
            {
                SRN srn = new SRN();
                srn.Show();
            }



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            panelInvisible();
            LblGRN.Visible = true;
            GRNPanel.Visible = true;
            //hard coded sample data
            /*dataGridView1.ForeColor = Color.Blue;

              dataGridView1.Rows.Add(2);

           dataGridView1.Rows[0].Cells[0].Value = "Department of Industrial Management";
           dataGridView1.Rows[0].Cells[1].Value = "SRN0421";
           dataGridView1.Rows[0].Cells[2].Value = "High";
           dataGridView1.Rows[0].Cells[3].Value = "Please provide before sunday";

           dataGridView1.Rows[1].Cells[0].Value = "Department of Chemistry";
           dataGridView1.Rows[1].Cells[1].Value = "SRN0123";
           dataGridView1.Rows[1].Cells[2].Value = "Medium";
           dataGridView1.Rows[1].Cells[3].Value = "";*/
        }

        private void label16_Click(object sender, EventArgs e)
        {
            panelInvisible();
            MsgPanel.Visible = true;
            MessagesLabel.Visible = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelInvisible();
            MsgList.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panelInvisible();
            PnlHome.Visible = true;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Cursor = Cursors.Hand;
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
