using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSA.Model.Models
{
    public class TblUser : BaseModel
    {
        public int Id { get; set; } // User ID
        [MaxLength(50)]
        public string Username { get; set; } // Username
        [MaxLength(50)]
        public string Password { get; set; } // Password
        [MaxLength(50)]
        public string? Name { get; set; } // User's name
        [MaxLength(50)]
        public string? Surname { get; set; } // User's surname
        public AuthorizationType Authorization { get; set; } // User's authorization level


        public List<TblMaintenanceRecord> MaintenanceRecords { get; set;}
    }
}
