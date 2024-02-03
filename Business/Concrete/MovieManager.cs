using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MovieManager : IMovieService
    {
        IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public void Add(Movie movie)
        {
            //First business rules then add operation
            _movieDal.Add(movie); 
        }

        public void Delete(Movie movie)
        {
            _movieDal.Delete(movie);
        }

        public List<Movie> GetAll()
        {
            return _movieDal.GetAll().ToList();
        }

        public Movie GetById(int id)
        {
            return _movieDal.GetById(id);
        }

        public void Update(Movie movie)
        {
            _movieDal.Update(movie);
        }
    }
}
