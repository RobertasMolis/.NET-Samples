using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Data;
using HotelApp.Models;

namespace HotelApp.Repositories
{
    public class CleanerRepository : RepositoryBase<Cleaner>
    {
        public CleanerRepository(DataContext context) : base(context)
        {

        }

    }
}
