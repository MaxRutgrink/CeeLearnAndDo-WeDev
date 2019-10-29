using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeeLearnAndDo_WeDev.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public Question Question { get; set; }
        public int QuestionId { get; set; }
        public Consultant Consultant { get; set; }
        public int ConsultantId { get; set; }
    }
}
