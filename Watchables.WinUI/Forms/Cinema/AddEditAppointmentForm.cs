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
    public partial class AddEditAppointmentForm : Form
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
        private readonly int? _appointmentId;
        private readonly CinemaDayMovieForm _cinemaDayMovieForm;
        private readonly AppointmentsForm _appointmentsForm;
        private List<Model.Hall> _halls;

        public AddEditAppointmentForm(AppointmentsForm appointmentsForm, ScheduleForm scheduleForm, Model.Requests.CinemasScheduleRequest schedule, MenuForm menuForm, int airingDayId, DateTime date, string day, int cinemaDayMovieId, int movieId, CinemaDayMovieForm cinemaDayMovieForm, int? appointmentId=null) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 20 - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - saveBtn.Height - 20);
            _scheduleForm = scheduleForm;
            _schedule = schedule;
            _airingDayId = airingDayId;
            _menuForm = menuForm;
            _date = date;
            _day = day;
            _cinemaDayMovieId = cinemaDayMovieId;
            _movieId = movieId;
            _appointmentId = appointmentId;
            _cinemaDayMovieForm = cinemaDayMovieForm;
            _appointmentsForm = appointmentsForm;

            StartsAt.Format = DateTimePickerFormat.Custom;
            StartsAt.CustomFormat = "HH:mm"; 
            StartsAt.ShowUpDown = true;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            _helper.CloseForm(this, 15);
            AppointmentsForm form = new AppointmentsForm(_scheduleForm, _schedule, _menuForm, _airingDayId, _date, _day, _cinemaDayMovieId, _movieId, _cinemaDayMovieForm);
            _helper.ShowForm(form, 15);
        }

        private async void AddEditAppointmentForm_Load(object sender, EventArgs e) {
            _halls = await _apiService.CustomGet<List<Model.Hall>>("GetHalls", _schedule.Cinema.CinemaId);
            var moviesApi = new APIService("movies");
            var movie = await moviesApi.GetById<Model.Movie>(_movieId);
            HallsBox.DisplayMember = "Text";
            HallsBox.ValueMember = "Value";
            foreach (var hall in _halls) {
                HallsBox.Items.Add(new { Text = hall.HallName+" "+hall.HallNumber, Value = hall.HallId });
            }
            Cinema.Text = _schedule.Cinema.Name;
            Day.Text = $"{_day}, {_date.ToString("dd. MMM yyyy")}";
            Movie.Text = movie.Title;
            if (_appointmentId.HasValue) {
                Title.Text = $"Appointment of:";                
                var appApi = new APIService("Appointments");
                var app = await appApi.GetById<Model.Appointments>(_appointmentId);

                Price.Text = app.Price.ToString();
                StartsAt.Value = DateTime.Parse(app.StartsAt.ToString());
                var hallApi = new APIService("halls");
                var hall = await hallApi.GetById<Model.Hall>(app.HallId);
                HallsBox.SelectedIndex= HallsBox.Items.IndexOf(new { Text = hall.HallName + " " + hall.HallNumber, Value = hall.HallId });
            }
            else {
                Title.Text = $"Appointment to:";
            }

        }

        private async void saveBtn_Click(object sender, EventArgs e) {
            var messageBox = new CustomMessageBox();

            if (!_helper.ValidateDecimalString(Price.Text, 1, 100)) {
                messageBox.Show("Enter a valid price (1-100)!", "error");
                return;
            }
            if (HallsBox.SelectedIndex == -1) {
                messageBox.Show("Select a hall!", "error");
                return;
            }
          
            var appApi = new APIService("Appointments");
            var allApps = await appApi.Get<List<Model.Appointments>>(null);
            allApps.RemoveAll(a=>a.HallId != (HallsBox.SelectedItem as dynamic).Value);

            var cdmApi = new APIService("CinemaDayMovie");
            var allCdms =await cdmApi.Get<List<Model.CinemaDayMovie>>(null);
            var finalApps = new List<Model.Appointments>();

            foreach(var app in allApps) {
                foreach(var cdm in allCdms) {
                    if(app.CinemaDayMovieId == cdm.CinemaDayMovieId && cdm.AiringDaysOfCinemaId == _airingDayId) {
                        finalApps.Add(app);
                        break;
                    }
                }
            }

            var moviesApi = new APIService("movies");
            var movie = await moviesApi.GetById<Model.Movie>(_movieId);

            
            
            if (_appointmentId.HasValue) {
                var app = await appApi.GetById<Model.Appointments>(_appointmentId);
                finalApps.RemoveAll(a => a.AppointmentId == app.AppointmentId);
            }

            bool valid = true;

            foreach(var app in finalApps) {
                DateTime newBegins = new DateTime();
                DateTime newEnds = new DateTime();
                newBegins = DateTime.Parse(StartsAt.Text);
                newEnds= DateTime.Parse(StartsAt.Text).AddMinutes(TimeSpan.Parse(movie.Duration).TotalMinutes);


                var cdm = await cdmApi.GetById<Model.CinemaDayMovie>(app.CinemaDayMovieId);
                var thisMovie = await moviesApi.GetById<Model.Movie>(cdm.MovieId);

                DateTime begins = new DateTime();
                DateTime ends = new DateTime();
                begins = DateTime.Parse(app.StartsAt);
                ends = DateTime.Parse(app.StartsAt).AddMinutes(TimeSpan.Parse(thisMovie.Duration).TotalMinutes);

                bool overlap = begins < newEnds && newBegins < ends;
                if (overlap) {
                    valid = false;
                    break;
                }                
            }
            if (!valid) {
                messageBox.Show("The appointment is overlaping!", "error");
                return;
            }

            Model.Appointments Object = new Model.Appointments() {
                Price = decimal.Parse(Price.Text),
                CinemaDayMovieId = _cinemaDayMovieId,
                HallId = (HallsBox.SelectedItem as dynamic).Value,
                SoldSeats = 0,
                StartsAt = StartsAt.Value.ToString("HH:mm")
            };
            if (_appointmentId.HasValue) {
                await _apiService.UpdateItem<Model.Appointments>(_appointmentId, "updateAppointment", Object);
                messageBox.Show("Appointment updated succesfully", "Success");
            }
            else {
                await _apiService.InsertItem<Model.Appointments>("AddAppointment", Object);
                messageBox.Show("Appointment added succesfully", "Success");
            }

            this.Close();
            _appointmentsForm.Close();
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
        }

        private async void reloadBtn_Click(object sender, EventArgs e) {
            if (_appointmentId.HasValue) {
                var appApi = new APIService("Appointments");
                var app = await appApi.GetById<Model.Appointments>(_appointmentId);

                Price.Text = app.Price.ToString();
                StartsAt.Value = DateTime.Parse(app.StartsAt.ToString());
                var hallApi = new APIService("halls");
                var hall = await hallApi.GetById<Model.Hall>(app.HallId);
                HallsBox.SelectedIndex = HallsBox.Items.IndexOf(new { Text = hall.HallName + " " + hall.HallNumber, Value = hall.HallId });
            }
            else {
                Price.Text = "";
                StartsAt.Value = DateTime.Now;
                HallsBox.SelectedIndex = -1;
            }
        }
    }
}
