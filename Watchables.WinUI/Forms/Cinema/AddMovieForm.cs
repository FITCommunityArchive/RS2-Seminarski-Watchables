using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchables.WinUI.Forms.Cinema
{
    public partial class AddMovieForm : Form
    {
        private readonly ScheduleForm _scheduleForm;
        private readonly int _airingDayId;
        private readonly APIService _apiService = new APIService("cinemas");
        private readonly Model.Requests.CinemasScheduleRequest _schedule;
        private readonly Helper _helper = new Helper();
        private readonly MenuForm _menuForm;
        private readonly DateTime _date;
        private readonly string _day;

        public AddMovieForm(ScheduleForm scheduleForm, Model.Requests.CinemasScheduleRequest schedule, MenuForm menuForm, int airingDayId, DateTime date, string day) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 20 - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - saveBtn.Height - 20);
            _scheduleForm = scheduleForm;
            _schedule = schedule;
            _airingDayId = airingDayId;
            _menuForm = menuForm;
            _date = date;
            _day = day;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            _helper.CloseForm(this, 15);
            CinemaDayMovieForm form = new CinemaDayMovieForm(_scheduleForm, _schedule, _menuForm, _airingDayId, _date, _day);
            _helper.ShowForm(form, 15);
        }

        private async void AddMovieForm_Load(object sender, EventArgs e) {
            Title.Text = $"{_day}, {_date.ToString("dd. MMMM yyyy")}";
            var moviesApi = new APIService("Movies");
            var allMovies = await moviesApi.Get<List<Model.Movie>>(null);
            allMovies.RemoveAll(m => m.Standalone);            

            var listMovies = new List<Model.Movie>();
            var finalMovies = new List<Model.Movie>();

            foreach (var item in _schedule.CinemaDayMovies) {
                if (item.AiringDaysOfCinemaId == _airingDayId) {
                    foreach (var mv in _schedule.Movies) {
                        if (mv.MovieId == item.MovieId) {
                            listMovies.Add(mv);
                        }
                    }
                }
            }
            foreach (var inMovie in allMovies) {
                bool hasIt = false;
                foreach(var movie in listMovies) {
                    if (inMovie.MovieId == movie.MovieId) {
                        hasIt = true;
                        break;
                    }
                }
                if (!hasIt) finalMovies.Add(inMovie);
            }

            finalMovies.Sort((a, b) => a.Title.CompareTo(b.Title));

            select.DisplayMember = "Text";
            select.ValueMember = "Value";
            foreach(var movie in finalMovies) {
                select.Items.Add(new { Text = movie.Title, Value = movie.MovieId });
            }
            if (select.Items.Count != 0) {
                select.SelectedIndex = 0;
            }
            else {
                saveBtn.Dispose();
                select.Dispose();
                Title.Text = "All movies are airing that day";
            }
                   
            
        }

        private async void saveBtn_Click(object sender, EventArgs e) {
            var movieId = (select.SelectedItem as dynamic).Value;
            var Object = new Model.CinemaDayMovie() {
                AiringDaysOfCinemaId = _airingDayId,
                MovieId = movieId
            };
            APIService cdmService = new APIService("cinemaDayMovie");
            await cdmService.Insert<Model.CinemaDayMovie>(Object);
            this.Close();
            _scheduleForm.Close();
            ScheduleForm sch = new ScheduleForm(_schedule.Cinema.CinemaId, _menuForm) {
                MdiParent = _menuForm,
                Dock = DockStyle.Fill
            };
           
            var schedule = await _apiService.CustomGet<Model.Requests.CinemasScheduleRequest>("GetCinemasSchedule", _schedule.Cinema.CinemaId);
            CinemaDayMovieForm form = new CinemaDayMovieForm(sch, schedule, _menuForm, _airingDayId, _date, _day);
            sch.Show();
            _helper.ShowForm(form, 15);
            var messageBox = new CustomMessageBox();
            messageBox.Show("Movie added successfully", "success");
        }
        
    }
}
