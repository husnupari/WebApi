using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using husnuWebApi.Models;

namespace husnuWebApi.Controllers
{
    public class MovieController : ApiController
    {
        public static List<Movie> movies;

        public MovieController()
        {
            movies = new List<Movie>();
            Movie movie1 = new Movie();
            movie1.id = 1;
            movie1.name = "Avatar";
            movie1.description = "abcd";
            movie1.genre = "Scifi";

            movies.Add(movie1);

            Movie movie2 = new Movie();
            movie2.id = 2;
            movie2.name = "Mummy";
            movie2.description = "abcd";
            movie2.genre = "Horror";

            movies.Add(movie2);
        }
        
        // GET: api/Movie
        public IEnumerable<Movie> Get()
        {         
            return movies;
        }

        // GET: api/Movie/5
        public Movie Get(int id)
        {
            return movies.Where(x => x.id == id).FirstOrDefault();
        }

        // POST: api/Movie
        public List<Movie> Post(Movie movie)
        {
            try
            {
                movies.Add(movie);
                return movies;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        // PUT: api/Movie/5
        public List<Movie> Put(int id,[FromBody] string description)
        {
          //Movie movieToBeUpdated = movies.Where(x => x.id == movie.id).FirstOrDefault();
            //movieToBeUpdated.name = movie.name;
            //movieToBeUpdated.description = movie.description;
            //movieToBeUpdated.genre = movie.genre;
             Movie movieToBeUpdated = movies.Where(x => x.id == id).FirstOrDefault();
            movieToBeUpdated.description = description;
            return movies;
        }

        // DELETE: api/Movie/5
        public List<Movie> Delete(int id)
        {
            Movie movieToBeDeleted = movies.Where(x => x.id == id).FirstOrDefault();
            movies.Remove(movieToBeDeleted);
            return movies;
        }
    }
}
