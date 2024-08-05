using Assignment4_NewsApp.Models;
using Assignment4_NewsApp.Models.Services;
using Assignment4_NewsApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_NewsApp.View
{
    public class NewsView
    {
        private readonly NewsViewModel _newsViewModel;

        public NewsView(NewsViewModel newsViewModel) 
        {
            _newsViewModel = newsViewModel;
        }

        public async Task ShowNewsArticles()
        {
            // List<String> list = new List<String>();
            var news = await _newsViewModel.GetNewsArticles();
            DisplayNews(news);
        }

        private void DisplayNews(News? news)
        {
            if (news != null && news.Articles != null)
            {
                foreach (var articles in news.Articles)
                {
                    if(articles.Title!=null && articles.Description != null)
                    {
                        Console.WriteLine($"Title: {articles.Title}");
                        Console.WriteLine($"Author: {articles.Author}");
                        Console.WriteLine($"Source Name: {articles.Source.Name}");
                        Console.WriteLine($"Description: {articles.Description}");
                        Console.WriteLine($"PublishedAt: {articles.PublishedAt}\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("No news articles found.");
            }
        }
    }
}
