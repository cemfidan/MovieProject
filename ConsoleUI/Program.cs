using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieManager movieManager = new MovieManager(new EfMovieDal());
            foreach (var movie in movieManager.GetAll())
            {
                Console.WriteLine(movie.Tagline);
            }
        }
    }
}