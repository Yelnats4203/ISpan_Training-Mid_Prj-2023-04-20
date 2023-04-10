using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;
using static System.Collections.Specialized.BitVector32;

namespace prjMovieBackSys
{
    public partial class FrmSession : Form
    {
        public FrmSession()
        {
            InitializeComponent();
            sm = new CSessionManager();  
            loadComboClass();
            loadDate();
            comboClass.SelectedIndexChanged += gridShow;
            comboClass.SelectedIndex = 0;
        }



        CSessionManager sm = null;
        DataTable dt = null;
        int _days = 21;
        string allClass = "(All)";


        public void loadDate()
        {
            dateTimePicker.Value = DateTime.Now.AddDays(1);
            dateTimePicker.MinDate = DateTime.Now.AddDays(1);
            dateTimePicker.MaxDate = DateTime.Now.AddDays(_days);
            dateTimePicker.ValueChanged += gridShow;
        }

        private void loadComboClass()   //Form生成時，load ComboClass，並計算Theater Class數
        {
            foreach (TheaterClass i in sm.LoadTheaterClass())
            {
                comboClass.Items.Add(i);
            }

        }

        void gridShow(object sender, EventArgs e)   //顯示選取天數及影廳的場次資訊
        {
            resetInfo();
            dt = new DataTable();
            if (comboClass.SelectedItem.ToString() == allClass)        //未篩選影廳
            {
                dt.Columns.Add("影廳", typeof(Theater));
                foreach (var q in sm.LoadPlayTimes())                               //將所有時段存為table的column
                {
                    dt.Columns.Add(q.ToString(), typeof(Session));
                }
                foreach (var q in sm.LoadTheaters())                                 //將所有影廳存為第一column的資料格
                {
                    dt.Rows.Add(q);
                }
                foreach (var q in sm.LoadSession(dateTimePicker.Value))          //所有session在比對第一column的影廳後，存入對應時段的資料格內
                {
                    for (int r = 0; r < dt.Rows.Count; r++)
                    {
                        if (q.Theater.Theater1 == dt.Rows[r][0].ToString())
                        {
                            dt.Rows[r][$"{q.PlayTimeDetail.PlayTime}"] = q;
                        }
                    }
                }
                dataGridSession.DataSource = dt;
                for (int c = 0; c < dataGridSession.Columns.Count; c++)
                {
                    dataGridSession.Columns[c].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            else
            {
                dt.Columns.Add("影廳", typeof(Theater));
                foreach (var q in sm.LoadPlayTimes())
                {
                    dt.Columns.Add(q.ToString(), typeof(Session));
                }

                foreach (var q in sm.LoadTheaters(((TheaterClass)comboClass.SelectedItem).TheaterClass_ID))   //有篩選影廳
                {
                    dt.Rows.Add(q);
                }
                foreach (var q in sm.LoadSession(dateTimePicker.Value, ((TheaterClass)comboClass.SelectedItem).TheaterClass_ID))
                {
                    for (int r = 0; r < dt.Rows.Count; r++)
                    {
                        if (q.Theater.Theater1 == dt.Rows[r][0].ToString())
                        {
                            dt.Rows[r][$"{q.PlayTimeDetail.PlayTime}"] = q;
                        }
                    }
                }
                dataGridSession.DataSource = dt;
                for (int c = 0; c < dataGridSession.Columns.Count; c++)
                {
                    dataGridSession.Columns[c].SortMode= DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        public void resetInfo()   //清除資料修改相關的控制項
        {
            btnCreate.Enabled = false;
            btnAlter.Enabled = false;
            btnDelete.Enabled = false;
            labelMovie.Text = string.Empty;
            labelStart.Text = string.Empty;
            labelEnd.Text = string.Empty;
            labelHasOrder.Text = string.Empty;
            comboMovie.Items.Clear();
            comboMovie.Text = string.Empty;
        }


        private void dataGridSession_CellClick(object sender, DataGridViewCellEventArgs e)  //點擊datagridview儲存格，顯示場次相關資訊，並修改場次增修控制項狀態
        {
            resetInfo();
            if (e.RowIndex ==-1)                                                       //點在column格上，則不會有反應
            {
                
            }
            else if(dt.Rows[e.RowIndex][e.ColumnIndex] is Session)    //點的資料格是有場次資料的狀況
            {
                labelMovie.Text = ((Session)dt.Rows[e.RowIndex][e.ColumnIndex]).Movie.MovieNameCht;
                labelStart.Text = ((Session)dt.Rows[e.RowIndex][e.ColumnIndex]).Movie.MovieScheduleStart.ToString("d");
                labelEnd.Text = ((Session)dt.Rows[e.RowIndex][e.ColumnIndex]).Movie.MovieScheduleEnd.ToString("d");
                showPoster(((Session)dt.Rows[e.RowIndex][e.ColumnIndex]).Movie.MoviePoster);
                if(!sm.CheckHasOrder(((Session)dt.Rows[e.RowIndex][e.ColumnIndex]).Session_ID))
                {
                    btnDelete.Enabled = true;
                    labelHasOrder.ForeColor = Color.Blue;
                    labelHasOrder.Text = "該場次尚無訂票資料。";
                    loadComboMovie();
                }
                else
                {
                    labelHasOrder.ForeColor = Color.Red;
                    labelHasOrder.Text = "該場次已有訂票資料，無法修改。";
                }
                //pictureMovie.Image = ((Session)dt.Rows[e.RowIndex][e.ColumnIndex]).Movie.MoviePoster.

            }
            else if(dt.Rows[e.RowIndex][e.ColumnIndex] is DBNull)   //點的資料格是沒有資料的狀況
            {
                loadComboMovie();
                pictureMovie.Image = null;
            }
        }

        public void loadComboMovie() 
        {
            foreach (var m in sm.LoadMovie(dateTimePicker.Value))
            {
                comboMovie.Items.Add(m);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)   //新增場次
        {
            Session session = new Session()
            {
                Theater_ID = ((Theater)dt.Rows[dataGridSession.CurrentCell.RowIndex][0]).Theater_ID,
                Movie_ID = ((Movie)(comboMovie.SelectedItem)).Movie_ID,
                PlayDate = dateTimePicker.Value.Date,
                PlayTime_ID = sm.LoadPlayTimeID(dataGridSession.CurrentCell.OwningColumn.Name)
            };
            sm.db.Sessions.Add(session);
            sm.db.SaveChanges();
            gridShow(sender,e);
        }
        private void btnAlter_Click(object sender, EventArgs e)   //修改場次
        {
            int id=((Session)dt.Rows[dataGridSession.CurrentCell.RowIndex][dataGridSession.CurrentCell.ColumnIndex]).Session_ID;
            sm.db.Sessions.Where(i=>i.Session_ID==id).First().Movie_ID = ((Movie)(comboMovie.SelectedItem)).Movie_ID;
            sm.db.SaveChanges();
            gridShow(sender, e);
        }
        private void btnDelete_Click(object sender, EventArgs e)  //刪除場次
        {
            int id = ((Session)dt.Rows[dataGridSession.CurrentCell.RowIndex][dataGridSession.CurrentCell.ColumnIndex]).Session_ID;
            sm.db.Sessions.Remove(sm.db.Sessions.Where(s=>s.Session_ID ==id ).First());
            sm.db.SaveChanges();
            gridShow(sender, e);
        }
        private void comboMovie_SelectedIndexChanged(object sender, EventArgs e)  //點選comboBOX，選擇要修改或加入的電影
        {
            labelMovie.Text = comboMovie.SelectedItem.ToString();
            labelStart.Text = ((Movie)(comboMovie.SelectedItem)).MovieScheduleStart.ToString("d");
            labelEnd.Text = ((Movie)(comboMovie.SelectedItem)).MovieScheduleEnd.ToString("d");
            showPoster(((Movie)(comboMovie.SelectedItem)).MoviePoster);
            if (dt.Rows[dataGridSession.CurrentCell.RowIndex][dataGridSession.CurrentCell.ColumnIndex] is DBNull)
            {
                btnCreate.Enabled = true;
            }
            else
            {
                btnAlter.Enabled = true;
            }
        }

        public void showPoster(byte[] image)
        {
            try
            {
                MemoryStream ms = new MemoryStream(image);
                pictureMovie.Image = System.Drawing.Image.FromStream(ms);
            }catch(Exception ex)
            {
                pictureMovie.Image = pictureMovie.ErrorImage;
            }
            
        }
      
    }
    }

