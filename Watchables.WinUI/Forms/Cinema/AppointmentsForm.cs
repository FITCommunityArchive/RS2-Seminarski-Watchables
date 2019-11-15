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

        public AppointmentsForm(ScheduleForm scheduleForm, Model.Requests.CinemasScheduleRequest schedule, MenuForm menuForm, int airingDayId, DateTime date, string day, int cinemaDayMovieId, int movieId) {
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
            dgvAppointments.DataSource = list;            
            Title.Text = $"{_schedule.Cinema.Name}, {_day} {_date.ToString("dd. MMM yyyy")}, {movie.Title}";
        }      

        private void AddAppBtn_Click(object sender, EventArgs e) {
            MessageBox.Show("Add");
        }

        private void dgvAppointments_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                var appointmentId = dgvAppointments.Rows[e.RowIndex].Cells["AppointmentId"].Value;
                var movieId = dgvAppointments.Rows[e.RowIndex].Cells["HallId"].Value;
                var action = dgvAppointments.Columns[e.ColumnIndex].Name;
                if (action == "Edit") {
                    MessageBox.Show("Edit", appointmentId.ToString());
                }
                else if (action == "Delete") {
                    MessageBox.Show("Delete", appointmentId.ToString());
                }
            }
        }
    }
}
