using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = new List<string>();
            Storage storage = new StoreBookDetails();
        }
    }
    abstract class Storage
    {
        protected void StoreBookDetail()
        {
            public string Name { get; set; }    
            public string Description { get; set; }
            public double BookPrice { get; set; }
        }
        public void DisplayBooks()
        {

        }
    }
}
