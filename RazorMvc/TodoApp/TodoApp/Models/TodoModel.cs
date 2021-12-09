using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TodoApp.Models
{
    public class TodoModel
    {
        [DisplayName("What is needed to do")]
        public string Todo { get; set; }
    }
}
