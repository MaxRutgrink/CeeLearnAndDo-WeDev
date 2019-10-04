using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeeLearnAndDo_WeDev.Models
{
    public class ArticleComment
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
