using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_NewsApp.Models.Services
{
    public interface INewsServices
    {
        public Task<News> GetNewsArticles();
    }
}
