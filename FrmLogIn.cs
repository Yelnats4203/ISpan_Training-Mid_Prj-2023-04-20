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
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }
        MovieEntities db = new MovieEntities();
        public FrmMovieBackSys log= new FrmMovieBackSys();
        int access = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(db.Employees.Where(i => (i.EmployeeAccount == txtAcc.Text) && (i.Password == txtPsw.Text)).Any())
            {
                foreach(var q in db.Employees.Where(i => (i.EmployeeAccount == txtAcc.Text) && (i.Password == txtPsw.Text)))
                {
                    access = q.Access;
                }
                log.acess = access;
                this.DialogResult= DialogResult.OK;
            }
            else
            {
                MessageBox.Show("帳號密碼錯誤！"); 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            log.Close();
        }

        private void btnDemo1_Click(object sender, EventArgs e)
        {
            txtAcc.Text = "neil0101";
            txtPsw.Text = "0001";
        }

        private void btnDemo2_Click(object sender, EventArgs e)
        {
            txtAcc.Text = "van0202";
            txtPsw.Text = "0002";
        }
    }
}
