using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Watchables.WebAPI.CBF
{
    public class WordBagGenerator
    {

        public string GenerateWordBag<T>(object item) {

            if (typeof(T) == typeof(Model.Movie)) {
                var movie = (item as Model.Movie);
                string wordBag = movie.Genre.ToLower() + "_" + movie.Year + "_" + movie.Cast.Replace(",", "_").Replace(" ", "").Replace(".","").ToLower();
                return wordBag;
            }
            else {
                var show = (item as Model.Show);
                string wordBag = show.Genre.ToLower() + "_" + show.Year + "_" + show.Cast.Replace(",", "_").Replace(" ", "").Replace(".", "").ToLower();
                return wordBag;
            }

        }

    }
}
