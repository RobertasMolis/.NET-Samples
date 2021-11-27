using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Models
{
    public class Books
    {

        public Books(string title, string description, int amount)
        {
            Title = title;
            Description = description;
            Amount = amount;
        }

        public string Title { get; set; }
        public string Description { get; set; } 
        public int Amount { get; set; }
    }

}
