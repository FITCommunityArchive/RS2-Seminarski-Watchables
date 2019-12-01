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
    public partial class AppointmentsForm : Form
    {

        private readonly ScheduleForm _scheduleForm;
        private readonly int _airingDayId;
        private readonly APIService _apiService = new APIService("cinemas");
        private readonly Model.Requests.CinemasScheduleRequest _schedule;
        private readonly Helper _helper = new Helper();
        private readonly MenuForm _menuForm;
        private readonly DateTime _date;
        private readonly string _day;
        private readonly int _cinemaDayMovieId;
        private readonly int _movieId;
        private readonly CinemaDayMovieForm _cinemaDayMovieForm;

        public AppointmentsForm(ScheduleForm scheduleForm, Model.Requests.CinemasScheduleRequest schedule, MenuForm menuForm, int airingDayId, DateTime date, string day, int cinemaDayMovieId, int movieId, CinemaDayMovieForm cinemaDayMovieForm) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 20 - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - AddAppBtn.Height - 20);
            _scheduleForm = scheduleForm;
            _schedule = schedule;
            _airingDayId = airingDayId;
            _menuForm = menuForm;
            _date = date;
            _day = day;
            _cinemaDayMovieId = cinemaDayMovieId;           
            _movieId = movieId;
            _cinemaDayMovieForm = cinemaDayMovieForm;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            _helper.CloseForm(this, 15);
            CinemaDayMovieForm form = new CinemaDayMovieForm(_scheduleForm, _schedule, _menuForm, _airingDayId, _date, _day);
            _helper.ShowForm(form, 15);
        }

        private async void AppointmentsForm_Load(object sender, EventArgs e) {
            var moviesApi = new APIService("movies");
            var movie = await moviesApi.GetById<Model.Movie>(_movieId);
            var list = new List<Model.dgvLists.AppointmentItem>();
            foreach(var app in _schedule.Appointments) {
                if (app.CinemaDayMovieId == _cinemaDayMovieId) {
                    int hallId = 0;
                    string hall = "";
                    int hallSeats = 0;
                    foreach (var inHall in _schedule.Halls) {
                        if (app.HallId == inHall.HallId) {
                            hallId = inHall.HallId;
                            hall = inHall.HallName + " " + inHall.HallNumber.ToString();
                            hallSeats = inHall.NumberOfseats;
                            break;
                        }
                    }

                    Model.dgvLists.AppointmentItem Object = new Model.dgvLists.AppointmentItem() {
                        AppointmentId = app.AppointmentId,
                        HallId = hallId,
                        Hall = hall,
                        Price = app.Price,
                        SoldSeats = app.SoldSeats,
                        StartsAt = app.StartsAt,
                        MovieDuration = movie.Duration,
                        EndsAt = DateTime.Parse(app.StartsAt).AddMinutes(TimeSpan.Parse(movie.Duration).TotalMinutes).ToString("HH:mm"),
                        HallSeats=hallSeats
                    };
                    list.Add(Object);
                }               
            }
            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(178, 8, 55);
            dgvAppointments.EnableHeadersVisualStyles = false;
            list.Sort((a, b) => a.StartsAt.CompareTo(b.StartsAt));
            dgvAppointments.DataSource = list;            
            Title.Text = $"{_schedule.Cinema.Name}, {_day} {_date.ToString("dd. MMM yyyy")}, {movie.Title}";
        }      

        private void AddAppBtn_Click(object sender, EventArgs e) {
            var form = new AddEditAppointmentForm(this, _scheduleForm, _schedule, _menuForm, _airingDayId, _date, _day, _cinemaDayMovieId, _movieId, _cinemaDayMovieForm);
            _helper.CloseForm(this, 15);
            _helper.ShowForm(form, 15);
        }

        private async void dgvAppointments_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                var appointmentId = dgvAppointments.Rows[e.RowIndex].Cells["AppointmentId"].Value;
                var movieId = dgvAppointments.Rows[e.RowIndex].Cells["HallId"].Value;
                var action = dgvAppointments.Columns[e.ColumnIndex].Name;
                CustomMessageBox messageBox = new CustomMessageBox();
                var appApi = new APIService("appointments");
                var movieApi = new APIService("movies");
                var movie = await movieApi.GetById<Model.Movie>(movieId);
                if (action == "Edit") {
                    var form = new AddEditAppointmentForm(this, _scheduleForm, _schedule, _menuForm, _airingDayId, _date, _day, _cinemaDayMovieId, _movieId, _cinemaDayMovieForm, int.Parse(appointmentId.ToString()));
                    _helper.CloseForm(this, 15);
                    _helper.ShowForm(form, 15);
                }
                else if (action == "Delete") {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to permanently delete the appointment for '{movie.Title}' on the {DateTime.Parse(_date.ToString()).ToShortDateString()}, {_day}?", "Delete appointment?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) {
                        await appApi.Delete<Model.Appointments>(appointmentId);

                        this.Close();
                        _cinemaDayMovieForm.Close();
                        _scheduleForm.Close();
                        ScheduleForm sch = new ScheduleForm(_schedule.Cinema.CinemaId, _menuForm) {
                            MdiParent = _menuForm,
                            Dock = DockStyle.Fill
                        };
                        var schedule = await _apiService.CustomGet<Model.Requests.CinemasScheduleRequest>("GetCinemasSchedule", _schedule.Cinema.CinemaId);
                        AppointmentsForm form = new AppointmentsForm(sch, schedule, _menuForm, _airingDayId, _date, _day, _cinemaDayMovieId, _movieId, _cinemaDayMovieForm);

                        sch.Show();
                        _helper.ShowForm(form, 15);
                        messageBox.Show("Appointment deleted successfully", "success");
                    }
                }
            }
        }
    }
}
