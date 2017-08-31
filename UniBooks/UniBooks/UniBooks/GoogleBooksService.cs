using Newtonsoft.Json;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniBooks.Data;

namespace UniBooks
{
    public class GoogleBooksService : IRestService
    {
        static string key = "AIzaSyDPbl1nJ6rV3Ig1CjNE_BioxcY42LoBMA8";
        public GoogleBooksService()
        {
            
        }
        public async Task<IRestResponse> GetBooksAsync(string q) 
        {
            using (var client = new RestClient(new Uri("https://www.googleapis.com/books/v1/volumes?q="+q+"&key=" + key + "&maxResults=40")))
            {
                var request = new RestRequest(Method.GET);
                return await client.Execute(request);
            }
        }
        public class ABook
        {
            [PrimaryKey]
            public string Id
            {
                get;
                set;
            }
            public string saleability
            {
                get;
                set;
            }
            public double? listPrice
            {
                get;
                set;
            }
            public string title
            {
                get;
                set;
            }
            public string subtitle
            {
                get;
                set;
            }
            public string authors
            {
                get;
                set;
            }
            public string publisher
            {
                get;
                set;
            }
            public string publishedDate
            {
                get;
                set;
            }
            public string description
            {
                get;
                set;
            }
            public int? pageCount
            {
                get;
                set;
            }
            public double? averageRating
            {
                get;
                set;
            }
            public int? ratingsCount
            {
                get;
                set;
            }
            public string smallThumbnail
            {
                get;
                set;
            }
            public string thumbnail
            {
                get;
                set;
            }
        }
        public class Books
        {
            public string kind
            {
                get;
                set;
            }
            public int? totalItems
            {
                get;
                set;
            }
            public List<BookModel> items
            {
                get;
                set;
            }
        }
        public class BookModel
        {
            public string id
            {
                get;
                set;
            }
            public volumeInfo volumeInfo
            {
                get;
                set;
            }
            public saleInfo saleInfo
            {
                get;
                set;
            }
        }
        public class saleInfo
        {
            public string saleability
            {
                get;
                set;
            }
            public listPrice listPrice
            {
                get;
                set;
            }
        }
        public class listPrice
        {
            public double? amount
            {
                get;
                set;
            }
        }
        public class volumeInfo
        {
            public string title
            {
                get;
                set;
            }
            public string subtitle
            {
                get;
                set;
            }            
            public List<string> authors
            {
                get;
                set;
            }
            public string publisher
            {
                get;
                set;
            }
            public string publishedDate
            {
                get;
                set;
            }
            public string description
            {
                get;
                set;
            }
            public int? pageCount
            {
                get;
                set;
            }
            public double? averageRating
            {
                get;
                set;
            }
            public int? ratingsCount
            {
                get;
                set;
            }
            public imageLinks imageLinks
            {
                get;
                set;
            }
            public string Ratings => string.Format("{0} {1}", averageRating, ratingsCount.HasValue?"("+ ratingsCount+")":"");

        }
        public class imageLinks
        {
            public string smallThumbnail
            {
                get;
                set;
            }
            public string thumbnail
            {
                get;
                set;
            }
        }
            
    }
}
