using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchables.WinUI.Forms.Movie
{
    public partial class AddEditMovieForm : Form
    {
        private readonly int? _movieId;
        private readonly MenuForm _menuForm;
        private readonly APIService _apiService = new APIService("movies");

        public AddEditMovieForm(MenuForm menuForm, int? movieId=null) {
            InitializeComponent();
            _menuForm = menuForm;
            _movieId = movieId;

            Duration.Format = DateTimePickerFormat.Custom;
            Duration.CustomFormat = "HH:mm";
            Duration.ShowUpDown = true;        
        }

        private void Close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void AddEditMovieForm_Load(object sender, EventArgs e) {
            if (_movieId.HasValue) {
                var movie = await _apiService.GetById<Model.Movie>(_movieId);
                PageTitle.Text = movie.Title;

                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                   $"<img alt='No available image with the provided link' src={movie.ImageLink} class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";
               
                var embed = "<html style='margin:0;'><head>" +
                  "<meta http-equiv='X-UA-Compatible' content='IE=Edge\'>" +
                  "</head><body style='margin:0; overflow:hidden';>" +
                  $"<div><iframe width={Trailer.Width} height={Trailer.Height} src='{movie.TrailerLink}'" +
                  "frameborder = '0' allow = 'autoplay; encrypted-media' allowfullscreen></iframe></div>" +
                  "</body></html>";
            
                Trailer.DocumentText = embed;

                MovieTitle.Text = movie.Title;
                Year.Value = movie.Year;
                Duration.Value = DateTime.Parse(movie.Duration);
                Rating.Text = movie.Rating.ToString();
                ImageLink.Text = movie.ImageLink;
                Description.Text = movie.Description;
                Cast.Text = movie.Cast;
                Price.Text = movie.Price.ToString();
                Standalone.Checked = movie.Standalone;
                TrailerLink.Text = movie.TrailerLink.Substring(30);

                Duration.Enabled = false;               
            }
            else {
                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                  $"<img alt='No available image with the provided link' src=https://www.colburnschool.edu/wp-content/uploads/2018/02/pix-vertical-placeholder.jpg class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";
                Trailer.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                $"<img alt='No available image with the provided link' src=https://womenandbloodclots.org/wp-content/uploads/2015/05/video-placeholder.png class='imgStyle' width='{Trailer.Width}' height='{Trailer.Height}'/>";
                PageTitle.Text = "Add a new movie";
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

        private async void Reset_Click_1(object sender, EventArgs e) {
            if (_movieId.HasValue) {
                var movie = await _apiService.GetById<Model.Movie>(_movieId);

                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                   $"<img alt='No available image with the provided link' src={movie.ImageLink} class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";

                var embed = "<html style='margin:0;'><head>" +
                  "<meta http-equiv='X-UA-Compatible' content='IE=Edge\'>" +
                  "</head><body style='margin:0; overflow:hidden';>" +
                  $"<div><iframe width={Trailer.Width} height={Trailer.Height} src='{movie.TrailerLink}'" +
                  "frameborder = '0' allow = 'autoplay; encrypted-media' allowfullscreen></iframe></div>" +
                  "</body></html>";

                Trailer.DocumentText = embed;

                MovieTitle.Text = movie.Title;
                Year.Value = movie.Year;
                Duration.Value = DateTime.Parse(movie.Duration);
                Rating.Text = movie.Rating.ToString();
                ImageLink.Text = movie.ImageLink;
                Description.Text = movie.Description;
                Cast.Text = movie.Cast;
                Price.Text = movie.Price.ToString();
                Standalone.Checked = movie.Standalone;
                TrailerLink.Text = movie.TrailerLink.Substring(30);
            }
            else {

                MovieTitle.Text = "";
                Year.Value = Year.Minimum;
                Duration.Value = DateTime.Now;
                Rating.Text = "";
                Description.Text = "";
                Cast.Text = "";
                Price.Text = "";
                Standalone.Checked = false;
                TrailerLink.Text = "";
                ImageLink.Text = "";
                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                  $"<img alt='No available image with the provided link' src=https://www.colburnschool.edu/wp-content/uploads/2018/02/pix-vertical-placeholder.jpg class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";
                Trailer.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                $"<img alt='No available image with the provided link' src=https://womenandbloodclots.org/wp-content/uploads/2015/05/video-placeholder.png class='imgStyle' width='{Trailer.Width}' height='{Trailer.Height}'/>";
                PageTitle.Text = "Add a new movie";
            }
        }

        private async void SaveBtn_Click(object sender, EventArgs e) {
            var messageBox = new CustomMessageBox();

            if (string.IsNullOrWhiteSpace(MovieTitle.Text) || MovieTitle.Text.Length < 4) {
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
            if(Year.Value<Year.Minimum || Year.Value > Year.Maximum) {
                messageBox.Show("Enter a valid year (1800-2025)!", "error");
                return;
            }
            var hours = Duration.Value.Hour;
            if(hours<0 || hours > 4) {
                messageBox.Show("Enter a valid duration (up to 5 hours)!", "error");
                return;
            }

            Model.Requests.InsertMovieRequest request = new Model.Requests.InsertMovieRequest() {
                Title = MovieTitle.Text,
                Year = (int)Year.Value,
                Duration = Duration.Value.ToString("HH:mm"),
                Rating = decimal.Parse(Rating.Text),
                Description = Description.Text,
                Cast = Cast.Text,
                ImageLink=ImageLink.Text,
                Standalone=Standalone.Checked,
                Price=decimal.Parse(Price.Text),
                TrailerLink=$"https://www.youtube.com/embed/{TrailerLink.Text}"
            };

            if (_movieId.HasValue) {
                await _apiService.Update<Model.Movie>(_movieId, request);
            }
            else {
                await _apiService.Insert<Model.Movie>(request);
            }

            this.Close();
            foreach (Form frm in _menuForm.MdiChildren) {
                frm.Close();
            }
            MoviesForm form = new MoviesForm {
                MdiParent = _menuForm,
                Dock = DockStyle.Fill
            };
            form.Show();
            if (_movieId.HasValue) {
                messageBox.Show("Movie updated successfully!", "success");
            }
            else {
                messageBox.Show("Movie added successfully!", "success");
            }

        }
    }
}
