using Ignitis.Models.Bases;
using System.ComponentModel.DataAnnotations;


namespace Ignitis.Models
{
    public class Answer : TitledEntity
    {
        [Required]
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}