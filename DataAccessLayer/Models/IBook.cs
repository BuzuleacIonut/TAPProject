using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public interface IBook
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        // int Quantity { get; set; }
        public DateTime? Return_Date { get; set; }
        public Books Books { get; set; }
        //public ICollection<IBook> BookBook { get; set; }


    }
}
