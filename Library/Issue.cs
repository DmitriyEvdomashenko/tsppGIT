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
            this.objBook.nameAuthor = _nameAu;
            this.objCustomer.name = _cust;
            this.objCustomer.num = _numCust;
            this.date = dat;
            this.ObjWorker.name = workName;
        }
        ~Issue() { }
    }
}
