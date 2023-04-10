
using prjMovieBackSys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CSessionManager
    {
        public CSessionManager()
        {
        }
        
        public MovieEntities db = new MovieEntities();

        #region Properties

        #endregion

        #region Methods

        public IEnumerable<TimeSpan> LoadPlayTimes()     //load PlayTimeDetail，所有時間段
        //SQL型別time會轉成timespan
        {
            return db.PlayTimeDetails.OrderBy(i => i.PlayTime).Select(i => i.PlayTime);
        }
        public int LoadPlayTimeID(string time)              //輸入場次時間，取得場次ID
        {
            return db.PlayTimeDetails.Where(i => i.PlayTime.ToString() == time).First().PlayTime_ID;
        }

        public IEnumerable<Theater> LoadTheaters()   //取得所有theater集合
        {
            return db.Theaters.ToList();
        }

        public IEnumerable<Theater> LoadTheaters(int Class)   //取得所有符合目標class的theater集合
        {
            return db.Theaters.Where(i => i.TheaterClass_ID == Class).ToList();
        }

        public IEnumerable<TheaterClass> LoadTheaterClass()  //load TheaterClass，所有Theater的分級
        {
            return db.TheaterClasses.ToList();
        }

        public IEnumerable<Session> LoadSession(DateTime date)  //回傳符合日期的session
        {
            var q =
                from s in db.Sessions.AsEnumerable()
                orderby s.Theater_ID
                where s.PlayDate == date.Date
                select s;
            return q.ToList();
        }

        public IEnumerable<Session> LoadSession(DateTime date, int Class)  //回傳符合日期以及符合theaterClass的session
        {
            var q =
                from s in db.Sessions.AsEnumerable()
                orderby s.Theater_ID
                where (s.PlayDate == date.Date) && (s.Theater.TheaterClass_ID == Class)
                select s;
            return  q.ToList();
        }

        public IEnumerable<Movie> LoadMovie(DateTime date)   //playtime回傳playtimeID
        {
            var q = 
                from m in db.Movies.AsEnumerable()
                where ((m.MovieScheduleEnd >=date) && (m.MovieScheduleStart <=date))
                select m;
            return q.ToList();
        }

        public bool CheckHasOrder(int sessionID)   //確認該場次是否有訂票
        {
           return db.Orders.Where(i => i.Session_ID == sessionID).Any();
        }

        public Session LoadSession(int session) //回傳指定場次的session
        {
            return db.Sessions.Where(i=>i.Session_ID == session).First();
        }



        #endregion


    }
}
