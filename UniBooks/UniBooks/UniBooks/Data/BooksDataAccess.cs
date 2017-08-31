using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System;
using static UniBooks.GoogleBooksService;
using SQLite.Net;
using SQLite.Net.Interop;
using SQLite.Net.Async;
using System.Threading.Tasks;

namespace UniBooks.Data
{
    public class BooksDataAccess
    {
        private static object collisionLock = new object();
        public ObservableCollection<ABook> Books { get; set; }
        SQLiteAsyncConnection _connection;
        public BooksDataAccess(string databaseName)
        {
            var pathToDatabaseFile = DependencyService.Get<ILocalFilePathProvider>().GetLocalPathToFile(databaseName);
            var platform = DependencyService.Get<ISqlitePlatformProvider>().GetPlatform();

            _connection = new SQLiteAsyncConnection(() =>
                new SQLiteConnectionWithLock(platform, new SQLiteConnectionString(pathToDatabaseFile, false)));
            _connection.CreateTablesAsync().Wait();

            _connection.CreateTableAsync<ABook>();          
        }
       
        public async Task<List<ABook>> GetAllBooks()
        {            
                var s=await _connection.Table<ABook>().ToListAsync();
            return s;                         
            
        }
        public Task<List<ABook>> GetFilteredBooks(string bookName)
        {
            lock (collisionLock)
            {
                var query = from cust in _connection.Table<ABook>()
                            where cust.title == bookName
                            select cust;
                return query.ToListAsync();
            }
        }
        public Task<List<ABook>> GetFilteredBooks()
        {
            lock (collisionLock)
            {
                return _connection.QueryAsync<ABook>(
                  "SELECT * FROM ABook WHERE title = 'self'");
            }
        }

        public async Task<ABook> GetBook(string id)
        {   
                return await _connection.Table<ABook>().Where(book => book.Id == id).
                  FirstOrDefaultAsync();
        }

        public async Task<string> SaveBook(ABook bookInstance)
        {
            var b =await GetBook(bookInstance.Id);
                if (b!= null)
                {
                    _connection.UpdateAsync(bookInstance);
                    return bookInstance.Id;
                }
                else
                {
                    _connection.InsertAsync(bookInstance);
                    return bookInstance.Id;
                }            
        }

        public void SaveAllBooks()
        {
            lock (collisionLock)
            {
                foreach (var bookInstance in this.Books)
                {
                    if (bookInstance.Id != "")
                    {
                        _connection.UpdateAsync(bookInstance);
                    }
                    else
                    {
                        _connection.InsertAsync(bookInstance);
                    }
                }
            }
        }

        public string DeleteBook(ABook bookInstance)
        {
            var id = bookInstance.Id;
            if (id != "")
            {
                lock (collisionLock)
                {
                    _connection.DeleteAsync<ABook>(id);
                }
            }
            this.Books.Remove(bookInstance);
            return id;
        }

        public void DeleteAllBooks()
        {
            lock (collisionLock)
            {
                _connection.DropTableAsync<ABook>();
                _connection.CreateTableAsync<ABook>();
            }
            this.Books = null;
            var bks = _connection.Table<ABook>().ToListAsync();
            this.Books = new ObservableCollection<ABook>(bks.Result);
        }


    }
}
