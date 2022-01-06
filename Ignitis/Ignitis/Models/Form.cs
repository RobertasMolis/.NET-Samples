using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignitis.Models
{
    public class Form : Entity
    {
        public List<Question> Questions { get; set; }
    }
}
