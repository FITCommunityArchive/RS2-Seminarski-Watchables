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
                Title.Text = movie.Title;

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
                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                  $"<img alt='No available image with the provided link' src=https://www.colburnschool.edu/wp-content/uploads/2018/02/pix-vertical-placeholder.jpg class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";
                Trailer.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                $"<img alt='No available image with the provided link' src=https://a73klm6pq0-flywheel.netdna-ssl.com/wp-content/uploads/2018/10/video-placeholder.jpg class='imgStyle' width='{Trailer.Width}' height='{Trailer.Height}'/>";
                Title.Text = "Add a new movie";
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
                $"<img alt='No available image with the provided link' src=https://a73klm6pq0-flywheel.netdna-ssl.com/wp-content/uploads/2018/10/video-placeholder.jpg class='imgStyle' width='{Trailer.Width}' height='{Trailer.Height}'/>";
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
    }
}
