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
    public partial class CinemaDayMovieForm : Form
    {
        private readonly ScheduleForm _scheduleForm;
        private readonly int _airingDayId;
        private readonly APIService _apiService = new APIService("cinemas");
        private readonly Model.Requests.CinemasScheduleRequest _schedule;
        private readonly Helper _helper = new Helper();
        private readonly MenuForm _menuForm;
        private readonly DateTime _date;
        private readonly string _day;
        
        public CinemaDayMovieForm(ScheduleForm scheduleForm, Model.Requests.CinemasScheduleRequest schedule, MenuForm menuForm, int airingDayId, DateTime date, string day) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 20 - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - addMovieBtn.Height - 20);
            _scheduleForm = scheduleForm;
            _schedule = schedule;
            _airingDayId = airingDayId;
            _menuForm = menuForm;
            _date = date;
            _day = day;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            _helper.CloseForm(this, 15);
        }

        private void CinemaDayMovieForm_Load(object sender, EventArgs e) {
            var list = new List<Model.dgvLists.CinemaDayMovieItem>();
            foreach(var item in _schedule.CinemaDayMovies){
                if (item.AiringDaysOfCinemaId == _airingDayId) {
                    string movie = "";
                    int movieId = 0;
                    int numberOfAppointments = 0;
                    foreach (var mv in _schedule.Movies) {
                        if (mv.MovieId == item.MovieId) {
                            movie = mv.Title;
                            movieId = mv.MovieId;
                            break;
                        }
                    }
                    foreach (var ap in _schedule.Appointments) {
                        if (ap.CinemaDayMovieId == item.CinemaDayMovieId) numberOfAppointments++;
                    }
                    var Object = new Model.dgvLists.CinemaDayMovieItem() {
                        CinemaDayMovieId = item.CinemaDayMovieId,
                        MovieId=movieId,
                        Movie = movie,
                        NumberOfAppointments = numberOfAppointments
                    };
                    list.Add(Object);
                }
            }
            dgvScheduledMovies.DataSource = list;
            Title.Text = $"{_day}, {_date.ToString("dd. MMMM yyyy")}, {_schedule.Cinema.Name}";
        }

        private void addMovieBtn_Click(object sender, EventArgs e) {
            AddMovieForm form = new AddMovieForm(_scheduleForm, _schedule, _menuForm, _airingDayId, _date, _day);
            _helper.CloseForm(this, 15);
            _helper.ShowForm(form, 15);
        }

        private void dgvScheduledMovies_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                var cinemaDayMovieId = dgvScheduledMovies.Rows[e.RowIndex].Cells["CinemaDayMovieId"].Value;
                var movieId = dgvScheduledMovies.Rows[e.RowIndex].Cells["MovieId"].Value;
                var action = dgvScheduledMovies.Columns[e.ColumnIndex].Name;
                if (action == "Delete") {
                    MessageBox.Show("Delete", cinemaDayMovieId.ToString());
                }
                else if (action == "Apps") {
                    AppointmentsForm form = new AppointmentsForm(_scheduleForm, _schedule, _menuForm, _airingDayId, _date, _day, int.Parse(cinemaDayMovieId.ToString()), int.Parse(movieId.ToString()));
                    _helper.CloseForm(this, 15);
                    _helper.ShowForm(form, 15);
                }
            }
        }
    }
}
