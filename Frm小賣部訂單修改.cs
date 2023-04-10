using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMovieBackSys
{
    public partial class Frm小賣部訂單修改 : Form
    {
        public Frm小賣部訂單修改()
        {
            InitializeComponent();
        }
            MovieEntities dbContext = new MovieEntities();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var q =dbContext.Receipts.AsEnumerable().Where(r => r.Member_ID ==int.Parse( txtMemberID.Text));
            this.dataGridView1.DataSource = q.ToList();
            this.dataGridView1.SelectionChanged+= dataGridView1_SelectionChanged;
        }

        int receiptID;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            receiptID = (int)dataGridView1.CurrentRow.Cells["Receipt_ID"].Value;
            var q = from r in dbContext.ReceiptDetails
                    where r.Receipt_ID == receiptID
                    select r;
            this.dataGridView2.DataSource = q.ToList();
        }

        void Read_RefreshDataGridView()
        {
            var q = from r in dbContext.ReceiptDetails
                    where r.Receipt_ID == receiptID
                    select r;
            this.dataGridView2.DataSource = q.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var q = (from rd in this.dbContext.ReceiptDetails
                    where rd.Receipt_Detail_ID == receiptDetailID
                    select rd).FirstOrDefault();

            if (q == null) return;
            this.dbContext.ReceiptDetails.Remove(q);
            this.dbContext.SaveChanges();

            this.Read_RefreshDataGridView();            
        }

        int receiptDetailID;

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            receiptDetailID = (int)dataGridView2.CurrentRow.Cells["Receipt_Detail_ID"].Value;
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            ReceiptDetail rd = new ReceiptDetail();
            this.dbContext.SaveChanges();
            this.Read_RefreshDataGridView();
        }
    }
}
