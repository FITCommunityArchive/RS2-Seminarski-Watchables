using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchables.WinUI.Forms
{
    public partial class DashboardForm : Form
    {
        public readonly APIService _notificationsApi = new APIService("Notifications");
        public readonly APIService _ordersApi = new APIService("orders");
        public readonly APIService _usersApi = new APIService("users");
        public readonly APIService _analyticsApi = new APIService("Analytics");
        public readonly APIService _subscriptionsApi = new APIService("Subscriptions");
        public readonly APIService _moviesApi = new APIService("movies");
        public readonly APIService _showsApi = new APIService("shows");

        public DashboardForm() {
            InitializeComponent();
            dgvNotifications.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(178, 8, 55);
            dgvNotifications.EnableHeadersVisualStyles = false;
            dgvTopMovies.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(178, 8, 55);
            dgvTopMovies.EnableHeadersVisualStyles = false;
            dgvTopShows.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(178, 8, 55);
            dgvTopShows.EnableHeadersVisualStyles = false;
        }

        private async void DashboardForm_Load(object sender, EventArgs e) {
            var notifications = await _notificationsApi.Get<List<Model.Notification>>(null);
            notifications = notifications.OrderByDescending(n => n.Created).ToList();
            dgvNotifications.AutoGenerateColumns = false;
            dgvNotifications.DataSource = notifications;
            var orders = await _ordersApi.Get<List<Model.Order>>(null);
            decimal orderRavenue = 0;
            foreach(var order in orders) {
                orderRavenue += order.Total;
            }
            Orders.Text = orderRavenue.ToString();

            decimal moviesRavenue = 0;
            var analyticsMovies = await _analyticsApi.Analytics<List<Model.UsersMovies>>("Movies");
            foreach(var item in analyticsMovies) {
                moviesRavenue += item.PurchaseAmount;
            }
            MoviesRavenue.Text = moviesRavenue.ToString();

            decimal showsRavenue = 0;
            var analyticsShows = await _analyticsApi.Analytics<List<Model.UsersShows>>("Shows");
            foreach (var item in analyticsShows) {
                showsRavenue += item.PurchaseAmount;
            }
            ShowsRavenue.Text = showsRavenue.ToString();

            decimal subscriptionRavenue = 0;
            var analyticsSubscriptions = await _analyticsApi.Analytics<List<Model.UsersSubscriptions>>("Subscriptions");
            foreach (var item in analyticsSubscriptions) {
                var sub = await _subscriptionsApi.GetById<Model.Subscription>(item.SubscriptionId);
                subscriptionRavenue += sub.Price;
            }
            SubRavenue.Text = subscriptionRavenue.ToString();

            var allMovies = await _moviesApi.Get<List<Model.Movie>>(null);
            List<Model.dgvLists.ScoreItem<Model.Movie>> movies = new List<Model.dgvLists.ScoreItem<Model.Movie>>();
            foreach(var movie in allMovies) {
                Model.dgvLists.ScoreItem<Model.Movie> newItem = new Model.dgvLists.ScoreItem<Model.Movie>() {
                    Title=movie.Title
                };
                foreach(var anMovie in analyticsMovies) {
                    if (anMovie.MovieId == movie.MovieId) newItem.Ravenue += anMovie.PurchaseAmount;
                }
                movies.Add(newItem);
            }
            movies = movies.OrderByDescending(i => i.Ravenue).ToList();
            dgvTopMovies.AutoGenerateColumns = false;
            dgvTopMovies.DataSource = movies;

            var allShows = await _showsApi.Get<List<Model.Show>>(null);
            List<Model.dgvLists.ScoreItem<Model.Show>> shows = new List<Model.dgvLists.ScoreItem<Model.Show>>();
            foreach (var show in allShows) {
                Model.dgvLists.ScoreItem<Model.Show> newItem = new Model.dgvLists.ScoreItem<Model.Show>() {
                    Title = show.Title
                };
                foreach (var anShow in analyticsShows) {
                    if (anShow.ShowId == show.ShowId) newItem.Ravenue += anShow.PurchaseAmount;
                }
                shows.Add(newItem);
            }
            shows = shows.OrderByDescending(i => i.Ravenue).ToList();
            dgvTopShows.AutoGenerateColumns = false;
            dgvTopShows.DataSource = shows;

        }

     
    }
}
