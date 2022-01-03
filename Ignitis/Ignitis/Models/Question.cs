using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignitis.Models
{
    public class Question : Entity
    {
        // public List<Answer> Answers { get; set; }
        public int AnswerId { get; set; }
        public int FormId { get; set; }
    }
}