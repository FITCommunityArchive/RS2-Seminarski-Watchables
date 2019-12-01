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
            dgvScheduledMovies.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(178, 8, 55);
            dgvScheduledMovies.EnableHeadersVisualStyles = false;
            dgvScheduledMovies.DataSource = list;
            Title.Text = $"{_day}, {_date.ToString("dd. MMMM yyyy")}, {_schedule.Cinema.Name}";
        }

        private void addMovieBtn_Click(object sender, EventArgs e) {
            AddMovieForm form = new AddMovieForm(_scheduleForm, _schedule, _menuForm, _airingDayId, _date, _day);
            _helper.CloseForm(this, 15);
            _helper.ShowForm(form, 15);
        }      

        private async void dgvScheduledMovies_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                var cinemaDayMovieId = dgvScheduledMovies.Rows[e.RowIndex].Cells["CinemaDayMovieId"].Value;
                var movieId = dgvScheduledMovies.Rows[e.RowIndex].Cells["MovieId"].Value;
                var action = dgvScheduledMovies.Columns[e.ColumnIndex].Name;
                var cdmApi = new APIService("cinemaDayMovie");
                var movieApi = new APIService("movies");
                var cdm = await cdmApi.GetById<Model.CinemaDayMovie>(cinemaDayMovieId);
                var movie = await movieApi.GetById<Model.Movie>(cdm.MovieId);
                CustomMessageBox messageBox = new CustomMessageBox();

                if (action == "Delete") {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to permanently delete '{movie.Title}' on the {DateTime.Parse(_date.ToString()).ToShortDateString()}, {_day}?", "Delete movie?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) {
                        await cdmApi.Delete<Model.CinemaDayMovie>(cinemaDayMovieId);

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

                        messageBox.Show("Movie deleted successfully", "success");
                    }
                }
                else if (action == "Apps") {
                    AppointmentsForm form = new AppointmentsForm(_scheduleForm, _schedule, _menuForm, _airingDayId, _date, _day, int.Parse(cinemaDayMovieId.ToString()), int.Parse(movieId.ToString()), this);
                    _helper.CloseForm(this, 15);
                    _helper.ShowForm(form, 15);
                }
            }
        }
    }
}
