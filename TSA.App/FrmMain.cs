using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using TSA.App.Pages;
using TSA.Service;

namespace TSA.App
{
    public partial class FrmMain : XtraForm
    {
        Dictionary<PageType, XtraTabPage> _pages = new Dictionary<PageType, XtraTabPage>();

        enum PageType
        {
            Users = 0,
            Settings = 1,
            MaintenanceRecords = 2,
            Laptops = 3,
            Smartphones = 4,
            Tablets = 5,
            DesktopComputers = 6,
            SmartWatches = 7,
            PersonnelsInfo = 8,
            HumarResources = 9,
            Marketing = 10,
            Sales = 11,
            ResearchAndDevelopment = 12,
            InformationTechnology = 13
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                XtraMessageBox.Show("Welcome", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nbiUsers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OpenPage(PageType.Users, "Users", Properties.Resources.usergroup_16x16, new UcUsers());
        }

        void OpenPage(PageType pageType, string title, Image image, UserControl control)
        {
            if (_pages.ContainsKey(pageType))
            {
                XtraTabPage oldPage = _pages[pageType];
                oldPage.Show();
                return;
            }

            XtraTabPage tabPage = new XtraTabPage();
            tabPage.Text = title;
            tabPage.ImageOptions.Image = image;
            tabPage.Tag = pageType;
            tabPage.Controls.Add(control);
            control.Dock = DockStyle.Fill;

            _pages.Add(pageType, tabPage);

            xtraTabControlMain.TabPages.Add(tabPage);
            tabPage.Show();
        }

        void ClosePage(XtraTabPage tabPage)
        {

            xtraTabControlMain.TabPages.Remove(tabPage);
            if (tabPage.Tag == null) return;
            PageType pageType = (PageType)tabPage.Tag;
            _pages.Remove(pageType);

        }
        private void nbiSettings_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            OpenPage(PageType.Settings, "Settings", Properties.Resources.properties_16x16, new UcSettings());
        }

        private void xtraTabControlMain_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs args = (ClosePageButtonEventArgs)e;
            ClosePage((XtraTabPage)args.Page);
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DbService.Save();
            XtraMessageBox.Show("Data saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nbiMaintenanceRecords_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OpenPage(PageType.MaintenanceRecords, "Maintenance Records", Properties.Resources.customizegrid_16x16, new UcMaintenanceRecords());
        }
    }
}
