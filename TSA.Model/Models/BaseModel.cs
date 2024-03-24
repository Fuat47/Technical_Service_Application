using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSA.Model.Models
{
    public class BaseModel
    {
        public int? CreatedByUserId { get; set; } // User ID who created the record
        public DateTime? CreationDate { get; set; } // Date and time when the record was created
        public int? UpdatedByUserId { get; set; } // User ID who last updated the record
        public DateTime? UpdateDate { get; set; } // Date and time when the record was last updated
    }
}
