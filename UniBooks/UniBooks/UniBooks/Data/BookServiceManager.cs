using RestSharp.Portable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBooks.Data
{
    class BookServiceManager
    {
        IRestService restService;

        public BookServiceManager(IRestService service)
        {
            restService = service;
        }

        public Task<IRestResponse> GetBooksAsync(string q)
        {
            try
            {
                return restService.GetBooksAsync(q);
            }
            catch (Exception ex)
            {

            }
            return null;
        }

    }
}
