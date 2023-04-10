using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.DataVisualization;

namespace prjMovieBackSys
{
    public partial class FrmStatics : Form
    {
        public FrmStatics()
        {
            InitializeComponent();
        }

        MovieEntities db = new MovieEntities();

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    showUserStatics();
                    break;
            }
        }

        public void showUserStatics()
        {
            chart1.Series[0].Enabled = true;
            chart1.Series[0].LegendText = "男";
            chart1.Series[1].Enabled = true;
            chart1.Series[1].LegendText = "女";
            chart1.Series[2].Enabled = true;
            chart1.Series[2].LegendText = "其他";

            var q =
                from m in db.Members.AsEnumerable()
                orderby m.BirthDate descending
                group m by GroupMembersByAges(m.BirthDate) into g
                select new { g.Key, Male =g.Where(i=>i.GenderID==1).Count(), 
                    Female = g.Where(i => i.GenderID ==2 ).Count(), Other = g.Where(i=>i.GenderID==3).Count() };

            chart1.DataSource = q.ToList();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series[0].XValueMember = "Key";
            chart1.Series[0].YValueMembers = "Male";

            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series[1].XValueMember = "Key";
            chart1.Series[1].YValueMembers = "Female";

            chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series[2].XValueMember = "Key";
            chart1.Series[2].YValueMembers = "Other";


        }

        public string GroupMembersByAges(DateTime? birth)
        {
            int age = ((DateTime.Now - birth).Value.Days)/365;
            if (age <= 20)
            {
                return "20歲以下";
            }else if (age <= 30)
            {
                return "20~30歲";
            }else if(age <= 40)
            {
                return "30~40歲";
            }else if (age <= 50)
            {
                return "40~50歲";
            }else if (age<= 60)
            {
                return "50~60歲";
            }
            else
            {
                return "60歲以上";
            }
            
        }

    }
}
