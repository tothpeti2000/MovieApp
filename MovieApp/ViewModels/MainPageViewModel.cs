using MovieApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;

namespace MovieApp.ViewModels
{
    public class MainPageViewModel: ViewModelBase
    {
        public DelegateCommand NavigateCommand { get; set; }

        public MainPageViewModel(): base()
        {
            NavigateCommand = new DelegateCommand(NavigateToPopularShows);
        }

        public void NavigateToPopularShows()
        {
            NavigationService.Navigate(typeof(PopularShowsPage));
        }
    }
}
