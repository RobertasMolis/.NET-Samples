using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignitis.Models.Bases
{
    public abstract class TitledEntity : Entity
    {
        public string Title { get; set; }
    }
}
