using System;

namespace Library
{
    public class Issue
    {
        public Book objBook = new Book();
        public Customer objCustomer = new Customer();
        public DateTime date = new DateTime();
        public Worker ObjWorker = new Worker();
        public Issue(string _nameAu, string _cust, int _numCust, DateTime dat, string workName)
        {
            objBook.nameAuthor = _nameAu;
            objCustomer.name = _cust;
            objCustomer.num = _numCust;
            date = dat;
            ObjWorker.name = workName;
        }
        ~Issue() { }
    }
}
