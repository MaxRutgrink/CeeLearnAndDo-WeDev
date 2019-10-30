using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeeLearnAndDo_WeDev.Models
{
    public class QuestionComment
    {
        public int Id { get; set; }
        public Question Question { get; set; }
        public int QuestionId { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
