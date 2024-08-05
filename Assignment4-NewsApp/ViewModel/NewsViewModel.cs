
using Assignment4_NewsApp.Models.Services;
using Assignment4_NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_NewsApp.ViewModel
{
    public class NewsViewModel
    {

        private readonly NewsService _newsService;

        public NewsViewModel(NewsService newsService) 
        {
            _newsService = newsService;
        }

        public async Task<News?> GetNewsArticles()
        {
            return await _newsService.GetNewsArticles();
        }
    }
}
