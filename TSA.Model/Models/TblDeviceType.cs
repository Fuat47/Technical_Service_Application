using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSA.Model.Models
{
    public class TblDeviceType : BaseModel
    {
        public int Id { get; set; } // Device Type ID
        [MaxLength(50)]
        public string Name { get; set; } // Device Type Name

        public List<TblDevice> Devices { get; set; }
    }
}
