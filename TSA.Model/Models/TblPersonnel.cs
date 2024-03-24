using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSA.Model.Models
{
    public class TblPersonnel : BaseModel
    {
        public int Id { get; set; } // Personnel ID
        [MaxLength(50)]
        public string Name { get; set; } // Personnel Name
        [MaxLength(50)]
        public string Surname { get; set; } // Personnel Surname
        public int DepartmentId { get; set; } // Department ID

        public List<TblDevice> AssignedDevices { get; set; }

        public TblDepartment Department { get; set; }

    }
}
