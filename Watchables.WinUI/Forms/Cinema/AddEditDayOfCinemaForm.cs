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
    public partial class AddEditDayOfCinemaForm : Form
    {
        private readonly ScheduleForm _scheduleForm;
        private readonly int? _airingDayId;
        private readonly APIService _apiService = new APIService("cinemas");
        private readonly Model.Requests.CinemasScheduleRequest _schedule;
        private readonly Helper _helper = new Helper();
        private readonly MenuForm _menuForm;


        public AddEditDayOfCinemaForm(ScheduleForm scheduleForm, Model.Requests.CinemasScheduleRequest schedule, MenuForm menuForm, int? airingDayId=null) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 20 - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - saveBtn.Height - 20);
            _scheduleForm = scheduleForm;
            _schedule = schedule;
            _airingDayId = airingDayId;
            _menuForm = menuForm;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            _helper.CloseForm(this, 15);
        }

        private async void AddEditDayOfCinemaForm_Load(object sender, EventArgs e) {
            datePicker.MinDate = DateTime.Now;
            if (_airingDayId.HasValue) {
                Title.Text = $"Day of: {_schedule.Cinema.Name}";
                var daysApi = new APIService("AiringDaysOfCinema");
                var airingDay = await daysApi.GetById<Model.AiringDaysOfCinema>(_airingDayId);
                datePicker.Value = airingDay.Date;
            }
            else {
                Title.Text = $"Day to: {_schedule.Cinema.Name}";
            }
        }

        private async void reloadBtn_Click(object sender, EventArgs e) {
            if (_airingDayId.HasValue) {
                var daysApi = new APIService("AiringDaysOfCinema");
                var airingDay = await daysApi.GetById<Model.AiringDaysOfCinema>(_airingDayId);
                datePicker.Value = airingDay.Date;
            }
            else {
                datePicker.Value = DateTime.Now;
            }
        }

        private async void saveBtn_Click(object sender, EventArgs e) {
            var daysApi = new APIService("AiringDaysOfCinema");
            var messageBox = new CustomMessageBox();
            var allDays = await daysApi.Get<List<Model.AiringDaysOfCinema>>(null);
            foreach (var day in allDays) {
                if (day.Date.Date == datePicker.Value.Date && day.CinemaId == _schedule.Cinema.CinemaId) {
                    messageBox.Show("Day already generated!", "error");
                    return;
                }
            }
           

            if (_airingDayId.HasValue) {
                var Object = new Model.AiringDaysOfCinema() {
                    Date = datePicker.Value,
                    AiringDayId = 0,
                    CinemaId = _schedule.Cinema.CinemaId
                };
                await _apiService.UpdateItem<Model.AiringDaysOfCinema>(_airingDayId, "updateAiringDay", Object);
                messageBox.Show("Airing day updated successfully", "success");
            }
            else {
                var Object = new Model.AiringDaysOfCinema() {
                    Date = datePicker.Value,
                    AiringDayId = 0,
                    CinemaId = _schedule.Cinema.CinemaId
                };
                await _apiService.InsertItem<Model.AiringDaysOfCinema>("addAiringDay", Object);
                messageBox.Show("Airing day added successfully", "success");
            }
            this.Close();
            _scheduleForm.Close();
            ScheduleForm form = new ScheduleForm(_schedule.Cinema.CinemaId, _menuForm) {
                MdiParent = _menuForm,
                Dock = DockStyle.Fill
            };
            form.Show();
            
        }
    }
}
