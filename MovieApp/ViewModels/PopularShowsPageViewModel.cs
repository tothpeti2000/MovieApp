using MovieApp.Models.Shows;
using MovieApp.Services.Shows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Windows.UI.Xaml.Navigation;

namespace MovieApp.ViewModels
{
    public class PopularShowsPageViewModel: ViewModelBase
    {
        public ObservableCollection<ShortShowDetails> PopularShows { get; set; } = new ObservableCollection<ShortShowDetails>();
        private readonly IShowService showService;

        public PopularShowsPageViewModel() { }

        public PopularShowsPageViewModel(IShowService showService)
        {
            this.showService = showService;
        }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            var response = await showService.GetPopularAsync();

            foreach (var show in response.Results)
            {
                PopularShows.Add(show);
            }

            await base.OnNavigatedToAsync(parameter, mode, state);
        }
    }
}
