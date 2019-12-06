using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Watchables.Model.ObservableLists
{
    public class CdmItem
    {
        public int CinemaDayMovieId { get; set; }
        public Model.Movie Movie { get; set; }
        public ObservableCollection<Model.Appointments> Appointments { get; set; }
    }
}
