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
        }

        private void Close_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
