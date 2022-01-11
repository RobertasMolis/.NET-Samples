using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Data;
using HotelApp.Models;

namespace HotelApp.Repositories
{
    public class HotelRepository : RepositoryBase<Hotel>
    {
        public HotelRepository(DataContext context) : base(context)
        {

        }
    }
}
