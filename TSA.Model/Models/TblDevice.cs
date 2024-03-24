using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSA.Model.Models
{
    public class TblDevice : BaseModel
    {
        public int Id { get; set; } // Device ID
        [MaxLength(50)]
        public String Name { get; set; } // Device name
        public int TypeId { get; set; } // Device type ID
        [MaxLength(100)]
        public string? Description { get; set; } // Device description
        public DateTime? PurchaseDate { get; set; } // Purchase date
        public int? AssignedPersonnelId { get; set; } // Assigned personnel ID
        public DateTime? AssignDate { get; set; } // Assignment date

        public List<TblMaintenanceRecord> MaintenanceRecords { get; set; }

        public TblDeviceType Type { get; set; }

        public TblPersonnel AssignedPersonnel { get; set; }


    }
}
