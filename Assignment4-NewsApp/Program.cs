
using Assignment4_NewsApp.Models.Services;
using Assignment4_NewsApp.View;
using Assignment4_NewsApp.ViewModel;

namespace Assignment4_NewsApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("News App\n\n");
            
            User.GetUserRequirements();

            NewsService newsService = new NewsService();
            NewsViewModel newsViewModel = new NewsViewModel(newsService);
            NewsView newsView = new NewsView(newsViewModel);

            await newsView.ShowNewsArticles();

            Console.ReadLine();
        }
    }
}
