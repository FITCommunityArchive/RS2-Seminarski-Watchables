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
    public partial class ScheduleForm : Form
    {
        private readonly int _cinemaId;
        private readonly MenuForm _menuForm;
        private readonly APIService _apiService = new APIService("cinemas");
        private List<Model.dgvLists.ScheduleItem> _list = new List<Model.dgvLists.ScheduleItem>();
        private Model.Requests.CinemasScheduleRequest _schedule = new Model.Requests.CinemasScheduleRequest();
        private readonly Helper _helper = new Helper();

        public ScheduleForm(int cinemaId, MenuForm menuForm) {
            InitializeComponent();
            _cinemaId = cinemaId;
            _menuForm = menuForm;

            dgvSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(178, 8, 55);
            dgvSchedule.EnableHeadersVisualStyles = false;
        }

     

        private async void ScheduleForm_Load(object sender, EventArgs e) {
            var schedule = await _apiService.CustomGet<Model.Requests.CinemasScheduleRequest>("GetCinemasSchedule", _cinemaId);
            _schedule = schedule;
            Title.Text = $"{schedule.Cinema.Name} schedule";

            var list = new List<Model.dgvLists.ScheduleItem>();
            foreach(var item in schedule.AiringDaysOfCinema) {
                string airingDay = "";
                int numberOfMovies = 0;
                foreach(var day in schedule.AiringDays) {
                    if (item.AiringDayId == day.AiringDayId) {
                        airingDay = day.Name;
                        break;
                    }
                }
                foreach(var movie in schedule.CinemaDayMovies) {
                    if (movie.AiringDaysOfCinemaId == item.AiringDaysOfCinemaId) numberOfMovies++;
                }
                var Object = new Model.dgvLists.ScheduleItem() {
                    AiringDaysOfCinemasId=item.AiringDaysOfCinemaId,
                    Date = item.Date.Date,
                    Day = airingDay,
                    NumberOfMovies=numberOfMovies
                };
                list.Add(Object);
            }
            dgvSchedule.AutoGenerateColumns = false;       

            dgvSchedule.DataSource = list;
            _list = list;
            selectList.DataSource = new string[] {
                "All",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
        }

        private void Close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void selectList_SelectionChangeCommitted(object sender, EventArgs e) {
            var day = selectList.SelectedItem;
            var list = new List<Model.dgvLists.ScheduleItem>(_list);
            if (day.ToString() != "All") list.RemoveAll(x => x.Day != day.ToString());
            dgvSchedule.DataSource = list;
        }

        private void AddDaybtn_Click(object sender, EventArgs e) {
            var form = new AddEditDayOfCinemaForm(this, _schedule, _menuForm);
            _helper.ShowForm(form,15);
        }

        private void Title_Click(object sender, EventArgs e) {

        }

        private void dgvSchedule_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                var airingDayOfCinemaId = dgvSchedule.Rows[e.RowIndex].Cells["AiringDaysOfCinemasId"].Value;
                var action = dgvSchedule.Columns[e.ColumnIndex].Name;
                var date = dgvSchedule.Rows[e.RowIndex].Cells["Date"].Value;
                var day = dgvSchedule.Rows[e.RowIndex].Cells["Day"].Value;
                if (action == "Edit") {
                    var form = new AddEditDayOfCinemaForm(this, _schedule, _menuForm, int.Parse(airingDayOfCinemaId.ToString()));
                    _helper.ShowForm(form, 15);
                }
                else if (action == "Delete") {
                    MessageBox.Show("delete", airingDayOfCinemaId.ToString());
                }
                else if (action == "MoviesBtn") {
                    var form = new CinemaDayMovieForm(this, _schedule, _menuForm, int.Parse(airingDayOfCinemaId.ToString()), (DateTime)date, day.ToString());
                    _helper.ShowForm(form, 15);
                }
            }
        }
    }
}
