using BN.Infrastrure.Query.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BN.Infrastrure.Query.NewsQuerys
{
    public interface INewsQuery
    {
        List<NewsView> GetAll();
        List<NewsView> GetNewest();
        NewsView SelectRow(int id);

    }
}
