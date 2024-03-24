using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSA.Service;

namespace TSA.App
{
    public partial class FrmLogin : XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValid = DbService.Login(txtUsername.Text, txtPassword.Text);

            if (isValid)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                lblInfo.Text = "Invalid username or password!";
                lblInfo.Visible = true;
            }
        }
    }
}
