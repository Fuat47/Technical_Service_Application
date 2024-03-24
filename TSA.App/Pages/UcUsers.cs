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
    public partial class UcUsers : UserControl
    {
        public UcUsers()
        {
            InitializeComponent();
            repositoryItemButtonEdit2.ButtonClick += RepositoryItemButtonEdit2_ButtonClick;

            GetUsers();
        }

        private void RepositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            TblUser user = gridView1.GetFocusedRow() as TblUser;

            if (user != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected user?", "User Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DbService.DeleteUser(user);
                }
            }
        }

        void GetUsers()
        {
            var userLists = DbService.GetBindingUsers();
            gridControlUsers.DataSource = userLists;
        }




    }
}
