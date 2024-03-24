using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSA.Model.Models
{
    public class TblMaintenanceRecord : BaseModel
    {
        public int Id { get; set; } // Record ID
        public int? DeviceId { get; set; } // Device ID
        public int? UserId { get; set; } // User ID
        public MaintenanceTypes? MaintenanceType { get; set; } // Maintenance type
        public DateTime? MaintenanceDate { get; set; } // Maintenance date
        [MaxLength(50)]
        public String? Explanation { get; set; } // Explanation

        public TblUser User { get; set; }

        public TblDevice Device { get; set; }
        

    }
}
