﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeeLearnAndDo_WeDev.Models
{
    public class QuestionComment
    {
        public int Id { get; set; }
        public int QuestionID { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
    }
}