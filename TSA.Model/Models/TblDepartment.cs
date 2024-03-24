using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSA.Model.Models
{
    public class TblDepartment : BaseModel
    {
        public int Id { get; set; } // Department ID
        [MaxLength(50)]
        public string Name { get; set; } // Department Name

        public List<TblPersonnel> Personnels { get; set; }
    }
}
