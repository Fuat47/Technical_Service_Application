using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSA.Model.Db;
using TSA.Model.Models;

namespace TSA.Service
{
    public class DbService
    {
        static TSADbContext TSADbContext = new TSADbContext();
        public static TblUser LoggedInUser { get; private set; }

        public static void Save()
        {
            TSADbContext.SaveChanges();
        }

        public static List<TblUser> GetUsers()
        {
            return TSADbContext.Users.ToList();
        }
        public static BindingList<TblUser> GetBindingUsers()
        {
            TSADbContext.Users.Load();
            return TSADbContext.Users.Local.ToBindingList();
        }
        public static void DeleteUser(TblUser user)
        {
            TSADbContext.Users.Remove(user);
        }

        public static bool Login(string username, string password)
        {
            TblUser user = TSADbContext.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static BindingList<TblMaintenanceRecord> GetBindingMaintenance()
        {
            TSADbContext.MaintenanceRecords.Load();
            return TSADbContext.MaintenanceRecords.Local.ToBindingList();
        }

        public static BindingList<TblDevice> GetBindingDevices()
        {
            TSADbContext.Devices.Load();
            return TSADbContext.Devices.Local.ToBindingList();
        }

        public static BindingList<TblPersonnel> GetBindingPersonnels()
        {
            TSADbContext.Personnels.Load();
            return TSADbContext.Personnels.Local.ToBindingList();
        }

        public static BindingList<TblDeviceType> GetBindingDeviceTypes()
        {
            TSADbContext.DeviceTypes.Load();
            return TSADbContext.DeviceTypes.Local.ToBindingList();
        }
        public static BindingList<TblDepartment> GetBindingDepartments()
        {
            TSADbContext.Departments.Load();
            return TSADbContext.Departments.Local.ToBindingList();
        }
    }
}
