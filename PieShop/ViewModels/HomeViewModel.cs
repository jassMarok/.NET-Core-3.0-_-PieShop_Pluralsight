using System.Collections.Generic;
using PieShop.Models;

namespace PieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}