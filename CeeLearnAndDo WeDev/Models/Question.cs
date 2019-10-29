using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeeLearnAndDo_WeDev.Models
{
    public class Question
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsVisible { get; set; }
        public string Title { get; set; }
    }
}
