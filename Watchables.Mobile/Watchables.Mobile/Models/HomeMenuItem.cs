using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Cinemas,
        Movies,
        Shows
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
