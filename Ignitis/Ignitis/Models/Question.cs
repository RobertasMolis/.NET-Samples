using Ignitis.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignitis.Models
{
    public class Question : TitledEntity
    {
        public List<Answer> PossibleAnswers { get; set; }
        public int? AnswerId { get; set; }
        public int FormId { get; set; }
    }
}