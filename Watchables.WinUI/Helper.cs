using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchables.WinUI
{
    public class Helper
    {

        public async void ShowForm(Form form, int delay) {
            form.Show();

            form.Opacity = 0;
            while (form.Opacity < 1.0) {
                await Task.Delay(delay);
                form.Opacity += 0.05;
            }
            form.Opacity = 1;
        }

        public async void CloseForm(Form form, int delay) {
            form.Opacity = 1;
            while (form.Opacity > 0.0) {
                await Task.Delay(delay);
                form.Opacity -= 0.05;
            }
            form.Opacity = 0;
            form.Close();
        }

        public bool ValidateDecimalString(string value, int from, int to) {
            if (!string.IsNullOrWhiteSpace(value) && !decimal.TryParse(value, out decimal n)) return false;
            decimal decimalValue = (!string.IsNullOrWhiteSpace(value)) ? decimal.Parse(value) : (-1);
            if (decimalValue < from || decimalValue > to) return false;
            return true;
        }
    }
}
