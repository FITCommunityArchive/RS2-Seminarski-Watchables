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


        public AddEditDayOfCinemaForm(ScheduleForm scheduleForm, Model.Requests.CinemasScheduleRequest schedule, int? airingDayId=null) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 20 - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - saveBtn.Height - 20);
            _scheduleForm = scheduleForm;
            _schedule = schedule;
            _airingDayId = airingDayId;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            _helper.CloseForm(this, 15);
        }

        private void AddEditDayOfCinemaForm_Load(object sender, EventArgs e) {
            datePicker.MinDate = DateTime.Now;
            if (_airingDayId.HasValue) {
                Title.Text = $"Day of: {_schedule.Cinema.Name}";
            }
            else {
                Title.Text = $"Day to: {_schedule.Cinema.Name}";
            }
        }
    }
}
