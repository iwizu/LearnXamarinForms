using RestSharp.Portable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBooks.Data
{
    public interface IRestService
    {
        Task<IRestResponse> GetBooksAsync(string q);
    }
}
