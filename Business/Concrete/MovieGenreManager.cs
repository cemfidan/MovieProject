using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MovieGenreManager : IMovieGenreService
    {
        IMovieGenreDal _movieGenreDal;

        public MovieGenreManager(IMovieGenreDal movieGenreDal)
        {
            _movieGenreDal = movieGenreDal;
        }
    }
}
