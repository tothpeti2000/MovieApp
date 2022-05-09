using MovieApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Template10.Services.NavigationService;

namespace MovieApp.ViewModels
{
    public class MainPageViewModel: ViewModelBase
    {
        public DelegateCommand NavigateCommand { get; set; }

        public MainPageViewModel()
        {
            NavigateCommand = new DelegateCommand(NavigateToPopularShows);
        }

        public void NavigateToPopularShows()
        {
            NavigationService.Navigate(typeof(PopularShowsPage));
        }
    }
}
