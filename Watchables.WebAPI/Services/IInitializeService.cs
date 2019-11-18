using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watchables.WebAPI.Services
{
    public interface IInitializeService
    {
        string AddDays();
        string AddMovies();
        string Init();
        string AddShows();
        string AddUsers();
    }
}
