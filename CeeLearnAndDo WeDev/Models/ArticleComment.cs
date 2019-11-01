using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeeLearnAndDo_WeDev.Models
{
    public class ArticleComment
    {
        public int Id { get; set; }
        public Article Article { get; set; }
        public int ArticleId { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
 