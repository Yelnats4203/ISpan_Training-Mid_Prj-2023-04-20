using prjMovieBackSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMovieBackSys
{
    public partial class FrmMovieBackSys : Form
    {
        public FrmMovieBackSys()
        {
            InitializeComponent();
        }

        private void FrmMovieBackSys_Load(object sender, EventArgs e)
        {
            LogIn();
        }

        public int acess = 0;
        public void LogIn()
        {

            FrmLogIn frm= new FrmLogIn();
            frm.log = this;
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                switch (acess)
                {
                    case 1:
                        btnMovie.Enabled = true;
                        btnSession.Enabled = true;
                        btnOrder.Enabled = true;
                        btnMember.Enabled = true;
                        btnCMT.Enabled = true;
                        btnSales.Enabled = true;
                        btnSaleProducts.Enabled = true;
                        btnCoupon.Enabled = true;
                        btnStatics.Enabled = true;
                        break;
                    case 2:
                        btnMovie.Enabled = false;
                        btnSession.Enabled = false;
                        btnOrder.Enabled = false;
                        btnMember.Enabled = false;
                        btnCMT.Enabled = false;
                        btnSales.Enabled = true;
                        btnSaleProducts.Enabled = true;
                        btnCoupon.Enabled= true;
                        btnStatics.Enabled = false;
                        break;
                }
                WindowState= FormWindowState.Maximized;
            }
            else
            {
                this.Close();
            }

        }

        public void CreateForm(Form frm)
        {
            splitContainer1.Panel2.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }
        private void btnSession_Click(object sender, EventArgs e)
        {
            FrmSession frm = new FrmSession();
            CreateForm(frm);
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            frm_Movie_MovieBack_01 frm = new frm_Movie_MovieBack_01();
            CreateForm(frm);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Form_OrderManagement frm = new Form_OrderManagement();
            CreateForm(frm);
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            Member_backend frm = new Member_backend();
            CreateForm(frm);
        }

        private void btnCMT_Click(object sender, EventArgs e)
        {
            FrmCnQManager frm= new FrmCnQManager();
            CreateForm(frm);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Frm小賣部訂單修改 frm = new Frm小賣部訂單修改();
            CreateForm(frm);
        }

        private void btnSaleProducts_Click(object sender, EventArgs e)
        {
            Frm商品管理系統 frm = new Frm商品管理系統();
            CreateForm(frm);
        }

        private void btnCoup_Click(object sender, EventArgs e)
        {
            Frm優惠券管理系統 frm = new Frm優惠券管理系統();
            CreateForm(frm);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            LogIn();
        }

        private void btnStatics_Click(object sender, EventArgs e)
        {
            FrmStatics frm = new FrmStatics();
            CreateForm(frm);
        }
    }
}
