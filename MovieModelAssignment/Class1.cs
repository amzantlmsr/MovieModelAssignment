using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Filmsorting
{
    public class Movies
    {
        public int ratings { get; set; }
        public string Moviename { get; set; }
        public int Revenue { get; set; }
        public string actors { get; set; }
        public string reviews { get; set; }

        public override string ToString()
        {
            return "review:" + " " + ratings + " " + " Name: " + Moviename + "  " + "with revenue of" + " " + Revenue;
        }

    }

    public static class MovieModelAssignment
    {

        public static void demo()
        {

            var movies = new List<Movies>();


            movies.Add(new Movies() { ratings = 4, Moviename = "The Rock", Revenue = 1500000, actors = "jerar departier", reviews = " moderate" });
            movies.Add(new Movies() { ratings = 10, Moviename = "Deadpool", Revenue = 2300000, actors = "jerar departier", reviews = " excellent" });
            movies.Add(new Movies() { ratings = 9, Moviename = "Game of Thrones", Revenue = 1100000, actors = "jerar departier", reviews = " very good" });
            movies.Add(new Movies() { ratings = 6, Moviename = "lord of The Ring", Revenue = 1400000, actors = "jerar departier", reviews = " boring" });
            movies.Add(new Movies() { ratings = 1, Moviename = "Always", Revenue = 1300000, actors = "jerar departier", reviews = " very disapointed" });
            movies.Add(new Movies() { ratings = 5, Moviename = "Better", Revenue = 1900000, actors = "jerar departier", reviews = " moderate" });
            movies.Add(new Movies() { ratings = 7, Moviename = "The Rock", Revenue = 1500000, actors = "jerar departier", reviews = " good" });
            movies.Add(new Movies() { ratings = 9, Moviename = "Jurassic World: Fallen Kingdom", Revenue = 1100000, actors = "jerar departier", reviews = " very good" });
            movies.Add(new Movies() { ratings = 8, Moviename = "Better", Revenue = 1900000, actors = "jerar departier", reviews = " moderate" });
            movies.Add(new Movies() { ratings = 4, Moviename = "Black Panther", Revenue = 900000, actors = "jerar departier", reviews = " good" });
            movies.Add(new Movies() { ratings = 6, Moviename = "Ocean's 8", Revenue = 5500000, actors = "jerar departier", reviews = " good" });
            movies.Add(new Movies() { ratings = 8, Moviename = "Ocean's 8", Revenue = 5500000, actors = "jerar departier", reviews = " good" });
            movies.Add(new Movies() { ratings = 10, Moviename = "Deadpool", Revenue = 2300000, actors = "jerar departier", reviews = " excellent" });
            movies.Add(new Movies() { ratings = 5, Moviename = "Game of Thrones", Revenue = 1100000, actors = "jerar departier", reviews = " very good" });
            movies.Add(new Movies() { ratings = 4, Moviename = "The Greatest Showman", Revenue = 7700000, actors = "jerar departier", reviews = " boring" });
            movies.Add(new Movies() { ratings = 8, Moviename = "Game of Thrones", Revenue = 1100000, actors = "jerar departier", reviews = " very good" });
            movies.Add(new Movies() { ratings = 5, Moviename = "The Rock", Revenue = 1500000, actors = "jerar departier", reviews = " moderate" });
            movies.Add(new Movies() { ratings = 7, Moviename = "Black Panther", Revenue = 900000, actors = "jerar departier", reviews = " good" });
            movies.Add(new Movies() { ratings = 8, Moviename = "Deadpool", Revenue = 2300000, actors = "jerar departier", reviews = " excellent" });
            movies.Add(new Movies() { ratings = 2, Moviename = "Super Mario Bros", Revenue = 8700000, actors = "jerar departier", reviews = " very disapointed" });
            movies.Add(new Movies() { ratings = 1, Moviename = "Upgrade", Revenue = 7200000, actors = "jerar departier", reviews = " very disapointed" });
            movies.Add(new Movies() { ratings = 5, Moviename = "Game of Thrones", Revenue = 1100000, actors = "jerar departier", reviews = " very good" });

            var finalprint = movies.GroupBy(byname => new { byname.Moviename })
                          .Select(f => new
                          {
                              name = f.Key.Moviename,
                              ratings = f.Select(s => s.ratings).Average()
                          }).ToList();

            var finalsorting = from a in finalprint
                               orderby a.ratings descending
                               select a;



            Console.WriteLine("\nThe users input are");


            foreach (var film in movies)

            {
                Console.WriteLine(" " + film.Moviename + " " + "with rate" + " " + film.ratings + " " + "and actor " + " " + film.actors + " " + "with earnings  " + " " + film.Revenue + " " + "and review " + film.reviews);
            }

            Console.WriteLine("\nThe best 10 movies are:");

            int i = 0;

            foreach (var list in finalsorting)

            {
                Console.WriteLine(" " + list.name + " " + "with rate" + " " + list.ratings);
                i = i + 1;
                if (i >= 10)
                    break;
            }

        }


    }
};
