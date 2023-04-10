using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMovieBackSys
{
    using System;
    using System.Collections.Generic;

    public partial class TheaterClass
    {
        public override string ToString()
        {
            return TheaterClass1;
        }
    }

    public partial class Session 
    {
        public override string ToString()
        {
            try
            {
                string session = this.Movie.MovieNameCht;
                return session;
            }catch(Exception e)
            {
                return "";
            }

        }
    }
    public partial class Movie
    {
        public override string ToString()
        {
            return this.MovieNameCht;
        }
    }

    public partial class Theater
    {
        public override string ToString()
        {
            return this.Theater1;
        }
    }

}