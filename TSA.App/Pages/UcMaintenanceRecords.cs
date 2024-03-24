using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSA.Model.Models;
using TSA.Service;

namespace TSA.App.Pages
{
    public partial class UcMaintenanceRecords : UserControl
    {
        public UcMaintenanceRecords()
        {
            InitializeComponent();
            repositoryItemLookUpEdit1.DataSource = DbService.GetBindingDevices();
            repositoryItemImageComboBox1.Items.AddEnum(typeof(MaintenanceTypes));
            repositoryItemLookUpEdit2.DataSource = DbService.GetBindingUsers();
            gridControlMaintenance.DataSource = DbService.GetBindingMaintenance();
        }
    }
}
