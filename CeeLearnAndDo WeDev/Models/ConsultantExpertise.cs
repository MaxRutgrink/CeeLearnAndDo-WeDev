using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeeLearnAndDo_WeDev.Models
{
    public class ConsultantExpertise
    {
        public Consultant Consultant { get; set; }
        public int ConsultantId { get; set; }
        public Expertise Expertise { get; set; }
        public int ExpertiseId { get; set; }
    }
}
