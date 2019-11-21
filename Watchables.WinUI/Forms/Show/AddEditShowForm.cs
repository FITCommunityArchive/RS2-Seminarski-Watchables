using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchables.WinUI.Forms.Show
{
    public partial class AddEditShowForm : Form
    {
        private readonly int? _showId;
        private readonly MenuForm _menuForm;
        private readonly APIService _apiService = new APIService("shows");

        public AddEditShowForm(MenuForm menuForm, int? showId = null) {
            InitializeComponent();
            _menuForm = menuForm;
            _showId = showId;
        }

        private void Close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void AddEditShowForm_Load(object sender, EventArgs e) {
            if (_showId.HasValue) {
                var show = await _apiService.GetById<Model.Show>(_showId);
                PageTitle.Text = show.Title;

                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                   $"<img alt='No available image with the provided link' src={show.ImageLink} class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";

                var embed = "<html style='margin:0;'><head>" +
                  "<meta http-equiv='X-UA-Compatible' content='IE=Edge\'>" +
                  "</head><body style='margin:0; overflow:hidden';>" +
                  $"<div><iframe width={Trailer.Width} height={Trailer.Height} src='{show.TrailerLink}'" +
                  "frameborder = '0' allow = 'autoplay; encrypted-media' allowfullscreen></iframe></div>" +
                  "</body></html>";

                Trailer.DocumentText = embed;

                ShowTitle.Text = show.Title;
                Year.Value = show.Year;
                Seasons.Value = show.NumberOfSeasons;
                Rating.Text = show.Rating.ToString();
                ImageLink.Text = show.ImageLink;
                Description.Text = show.Description;
                Cast.Text = show.Cast;
                Price.Text = show.Price.ToString();
                Ongoing.Checked = show.Ongoing;
                TrailerLink.Text = show.TrailerLink.Substring(30);
                Genre.Text = show.Genre;
            }
            else {
                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                  $"<img alt='No available image with the provided link' src=https://www.colburnschool.edu/wp-content/uploads/2018/02/pix-vertical-placeholder.jpg class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";
                Trailer.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                $"<img alt='No available image with the provided link' src=https://womenandbloodclots.org/wp-content/uploads/2015/05/video-placeholder.png class='imgStyle' width='{Trailer.Width}' height='{Trailer.Height}'/>";
                PageTitle.Text = "Add a new show";
            }
        }

        private async void Reset_Click(object sender, EventArgs e) {
            if (_showId.HasValue) {

                var show = await _apiService.GetById<Model.Show>(_showId);
                var movie = await _apiService.GetById<Model.Show>(_showId);

                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                    $"<img alt='No available image with the provided link' src={show.ImageLink} class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";

                var embed = "<html style='margin:0;'><head>" +
                  "<meta http-equiv='X-UA-Compatible' content='IE=Edge\'>" +
                  "</head><body style='margin:0; overflow:hidden';>" +
                  $"<div><iframe width={Trailer.Width} height={Trailer.Height} src='{show.TrailerLink}'" +
                  "frameborder = '0' allow = 'autoplay; encrypted-media' allowfullscreen></iframe></div>" +
                  "</body></html>";

                Trailer.DocumentText = embed;

                ShowTitle.Text = show.Title;
                Year.Value = show.Year;
                Seasons.Value = show.NumberOfSeasons;
                Rating.Text = show.Rating.ToString();
                ImageLink.Text = show.ImageLink;
                Description.Text = show.Description;
                Cast.Text = show.Cast;
                Price.Text = show.Price.ToString();
                Ongoing.Checked = show.Ongoing;
                TrailerLink.Text = show.TrailerLink.Substring(30);
                Genre.Text = show.Genre;
            }
            else {

                ShowTitle.Text = "";
                Year.Value = Year.Minimum;
                Seasons.Value =0;
                Rating.Text = "";
                Description.Text = "";
                Cast.Text = "";
                Price.Text = "";
                Ongoing.Checked = false;
                TrailerLink.Text = "";
                ImageLink.Text = "";
                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                  $"<img alt='No available image with the provided link' src=https://www.colburnschool.edu/wp-content/uploads/2018/02/pix-vertical-placeholder.jpg class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";
                Trailer.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                $"<img alt='No available image with the provided link' src=https://womenandbloodclots.org/wp-content/uploads/2015/05/video-placeholder.png class='imgStyle' width='{Trailer.Width}' height='{Trailer.Height}'/>";
                PageTitle.Text = "Add a new show";
                Genre.Text = "";
            }
        }

        private void ImageLink_KeyUp(object sender, KeyEventArgs e) {
            if (string.IsNullOrWhiteSpace(ImageLink.Text)) {
                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                  $"<img alt='No available image with the provided link' src=https://www.colburnschool.edu/wp-content/uploads/2018/02/pix-vertical-placeholder.jpg class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";
            }
            else {
                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                 $"<img src={ImageLink.Text} alt='No available image with the provided link' class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";
            }
        }

        private void TrailerLink_KeyUp(object sender, KeyEventArgs e) {
            if (string.IsNullOrWhiteSpace(TrailerLink.Text)) {
                Trailer.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                 $"<img alt='No available image with the provided link' src=https://womenandbloodclots.org/wp-content/uploads/2015/05/video-placeholder.png class='imgStyle' width='{Trailer.Width}' height='{Trailer.Height}'/>";
            }
            else {
                var embed = "<html style='margin:0;'><head>" +
                   "<meta http-equiv='X-UA-Compatible' content='IE=Edge\'>" +
                   "</head><body style='margin:0; overflow:hidden';>" +
                   $"<div><iframe width={Trailer.Width} height={Trailer.Height} src='https://www.youtube.com/embed/{TrailerLink.Text}'" +
                   "frameborder = '0' allow = 'autoplay; encrypted-media' allowfullscreen></iframe></div>" +
                   "</body></html>";

                Trailer.DocumentText = embed;
            }
        }

        private async void SaveBtn_Click(object sender, EventArgs e) {
            var messageBox = new CustomMessageBox();

            if (string.IsNullOrWhiteSpace(ShowTitle.Text) || ShowTitle.Text.Length < 4) {
                messageBox.Show("The title field requires 4 letters!", "error");
                return;
            }

            if (string.IsNullOrWhiteSpace(Description.Text) || Description.Text.Length < 5) {
                messageBox.Show("The description field requires 5 letters!", "error");
                return;
            }

            if (string.IsNullOrWhiteSpace(Cast.Text) || Cast.Text.Length < 15) {
                messageBox.Show("The cast field requires 15 letters!", "error");
                return;
            }
            if (string.IsNullOrWhiteSpace(ImageLink.Text) || !ImageLink.Text.Contains(".jpg")) {
                messageBox.Show("Enter a valid '.jpg' image link!", "error");
                return;
            }
            if (string.IsNullOrWhiteSpace(TrailerLink.Text)) {
                messageBox.Show("Enter a trailer id", "error");
                return;
            }

            if (string.IsNullOrWhiteSpace(Rating.Text) || !decimal.TryParse(Rating.Text, out decimal n)) {
                messageBox.Show("Enter a valid rating (0-10)!", "error");
                return;
            }
            decimal rating = decimal.Parse(Rating.Text);
            if (rating < 0 || rating > 10) {
                messageBox.Show("Enter a valid rating (0-10)!", "error");
                return;
            }

            if (string.IsNullOrWhiteSpace(Price.Text) || !decimal.TryParse(Price.Text, out decimal m)) {
                messageBox.Show("Enter a valid price (1-200)!", "error");
                return;
            }
            decimal price = decimal.Parse(Price.Text);
            if (price < 1 || price > 200) {
                messageBox.Show("Enter a valid price (1-200)!", "error");
                return;
            }
            if (Year.Value < Year.Minimum || Year.Value > Year.Maximum) {
                messageBox.Show("Enter a valid year (1800-2025)!", "error");
                return;
            }
            
            if (Seasons.Value<1 || Seasons.Value>100) {
                messageBox.Show("Enter a valid seasons number (1-100)!", "error");
                return;
            }

            if (string.IsNullOrWhiteSpace(Genre.Text) || Genre.Text.Length < 4) {
                messageBox.Show("The genre field requires 4 letters!", "error");
                return;
            }

            Model.Requests.InsertShowRequest request = new Model.Requests.InsertShowRequest() {
                Title = ShowTitle.Text,
                Year = (int)Year.Value,
                NumberOfSeasons = (int)Seasons.Value,
                Rating = decimal.Parse(Rating.Text),
                Description = Description.Text,
                Cast = Cast.Text,
                ImageLink = ImageLink.Text,
                Ongoing = Ongoing.Checked,
                Price = decimal.Parse(Price.Text),
                TrailerLink = $"https://www.youtube.com/embed/{TrailerLink.Text}",
                Genre = Genre.Text
            };

            if (_showId.HasValue) {
                await _apiService.Update<Model.Show>(_showId, request);
            }
            else {
                await _apiService.Insert<Model.Show>(request);
            }

            this.Close();
            foreach (Form frm in _menuForm.MdiChildren) {
                frm.Close();
            }
            ShowsForm form = new ShowsForm {
                MdiParent = _menuForm,
                Dock = DockStyle.Fill
            };
            form.Show();
            if (_showId.HasValue) {
                messageBox.Show("Show updated successfully!", "success");
            }
            else {
                messageBox.Show("Show added successfully!", "success");
            }
        }
    }
}
