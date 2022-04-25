using DataSource;
using Model;

namespace DataSqlite
{
    class DataSourceSqlite : IDataSource
    {
        public bool AddBook(Book book, int total)
        {
            throw new NotImplementedException();
        }

        public bool AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public BookBalance GetBook(string bookId)
        {
            throw new NotImplementedException();
        }

        public CustomerBook GetCustomer(string customerId)
        {
            throw new NotImplementedException();
        }

        public bool PopBook(Customer customer, Book book)
        {
            throw new NotImplementedException();
        }

        public bool PushBook(Customer customer, Book book)
        {
            throw new NotImplementedException();
        }
    }
}