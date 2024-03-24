namespace TSA.App
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            bbiSave = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            nbgBasic = new DevExpress.XtraNavBar.NavBarGroup();
            nbiUsers = new DevExpress.XtraNavBar.NavBarItem();
            nbiSettings = new DevExpress.XtraNavBar.NavBarItem();
            nbgMaintenances = new DevExpress.XtraNavBar.NavBarGroup();
            nbiMaintenanceRecords = new DevExpress.XtraNavBar.NavBarItem();
            nbgDevices = new DevExpress.XtraNavBar.NavBarGroup();
            navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            nbgPersonnels = new DevExpress.XtraNavBar.NavBarGroup();
            navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            nbgDepartments = new DevExpress.XtraNavBar.NavBarGroup();
            navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            navBarItem10 = new DevExpress.XtraNavBar.NavBarItem();
            navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
            xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)navBarControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabControlMain).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.EmptyAreaImageOptions.ImagePadding = new Padding(26);
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, bbiSave, barButtonItem1, barButtonItem2 });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 4;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.OptionsMenuMinWidth = 283;
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl1.Size = new Size(986, 150);
            ribbonControl1.StatusBar = ribbonStatusBar1;
            // 
            // bbiSave
            // 
            bbiSave.Caption = "Save";
            bbiSave.Id = 1;
            bbiSave.ImageOptions.LargeImage = (Image)resources.GetObject("bbiSave.ImageOptions.LargeImage");
            bbiSave.Name = "bbiSave";
            bbiSave.ItemClick += bbiSave_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "File";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(bbiSave);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "General";
            // 
            // ribbonStatusBar1
            // 
            ribbonStatusBar1.Location = new Point(0, 782);
            ribbonStatusBar1.Name = "ribbonStatusBar1";
            ribbonStatusBar1.Ribbon = ribbonControl1;
            ribbonStatusBar1.Size = new Size(986, 27);
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.Dock = DockStyle.Fill;
            splitContainerControl1.Location = new Point(0, 150);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.Controls.Add(navBarControl1);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(xtraTabControlMain);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(986, 632);
            splitContainerControl1.SplitterPosition = 228;
            splitContainerControl1.TabIndex = 1;
            // 
            // navBarControl1
            // 
            navBarControl1.ActiveGroup = nbgBasic;
            navBarControl1.Dock = DockStyle.Fill;
            navBarControl1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] { nbgBasic, nbgMaintenances, nbgDevices, nbgPersonnels, nbgDepartments });
            navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] { nbiUsers, nbiSettings, nbiMaintenanceRecords, navBarItem1, navBarItem2, navBarItem3, navBarItem4, navBarItem5, navBarItem6, navBarItem7, navBarItem8, navBarItem9, navBarItem10, navBarItem11 });
            navBarControl1.Location = new Point(0, 0);
            navBarControl1.Name = "navBarControl1";
            navBarControl1.OptionsNavPane.ExpandedWidth = 228;
            navBarControl1.Size = new Size(228, 632);
            navBarControl1.TabIndex = 0;
            navBarControl1.Text = "navBarControl1";
            // 
            // nbgBasic
            // 
            nbgBasic.Caption = "Basic Operations";
            nbgBasic.Expanded = true;
            nbgBasic.ImageOptions.SmallImage = (Image)resources.GetObject("nbgBasic.ImageOptions.SmallImage");
            nbgBasic.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] { new DevExpress.XtraNavBar.NavBarItemLink(nbiUsers), new DevExpress.XtraNavBar.NavBarItemLink(nbiSettings) });
            nbgBasic.Name = "nbgBasic";
            // 
            // nbiUsers
            // 
            nbiUsers.Caption = "Users";
            nbiUsers.ImageOptions.SmallImage = Properties.Resources.usergroup_16x16;
            nbiUsers.Name = "nbiUsers";
            nbiUsers.LinkClicked += nbiUsers_LinkClicked;
            // 
            // nbiSettings
            // 
            nbiSettings.Caption = "Settings";
            nbiSettings.ImageOptions.LargeImage = Properties.Resources.properties_32x32;
            nbiSettings.ImageOptions.SmallImage = Properties.Resources.properties_16x16;
            nbiSettings.Name = "nbiSettings";
            nbiSettings.LinkClicked += nbiSettings_LinkClicked;
            // 
            // nbgMaintenances
            // 
            nbgMaintenances.Caption = "Maintenance";
            nbgMaintenances.Expanded = true;
            nbgMaintenances.ImageOptions.SmallImage = Properties.Resources.optimizing;
            nbgMaintenances.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] { new DevExpress.XtraNavBar.NavBarItemLink(nbiMaintenanceRecords) });
            nbgMaintenances.Name = "nbgMaintenances";
            // 
            // nbiMaintenanceRecords
            // 
            nbiMaintenanceRecords.Caption = "Maintenance Records";
            nbiMaintenanceRecords.ImageOptions.LargeImage = Properties.Resources.customizegrid_32x32;
            nbiMaintenanceRecords.ImageOptions.SmallImage = Properties.Resources.customizegrid_16x16;
            nbiMaintenanceRecords.Name = "nbiMaintenanceRecords";
            nbiMaintenanceRecords.LinkClicked += nbiMaintenanceRecords_LinkClicked;
            // 
            // nbgDevices
            // 
            nbgDevices.Caption = "Devices";
            nbgDevices.Expanded = true;
            nbgDevices.ImageOptions.SmallImage = Properties.Resources.device;
            nbgDevices.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] { new DevExpress.XtraNavBar.NavBarItemLink(navBarItem1), new DevExpress.XtraNavBar.NavBarItemLink(navBarItem2), new DevExpress.XtraNavBar.NavBarItemLink(navBarItem3), new DevExpress.XtraNavBar.NavBarItemLink(navBarItem4), new DevExpress.XtraNavBar.NavBarItemLink(navBarItem5) });
            nbgDevices.Name = "nbgDevices";
            // 
            // navBarItem1
            // 
            navBarItem1.Caption = "Laptop";
            navBarItem1.ImageOptions.SmallImage = Properties.Resources.laptop;
            navBarItem1.Name = "navBarItem1";
            // 
            // navBarItem2
            // 
            navBarItem2.Caption = "Smartphone";
            navBarItem2.ImageOptions.SmallImage = Properties.Resources.smartphone;
            navBarItem2.Name = "navBarItem2";
            // 
            // navBarItem3
            // 
            navBarItem3.Caption = "Tablet";
            navBarItem3.ImageOptions.SmallImage = Properties.Resources.tablet;
            navBarItem3.Name = "navBarItem3";
            // 
            // navBarItem4
            // 
            navBarItem4.Caption = "Desktop Computer";
            navBarItem4.ImageOptions.SmallImage = Properties.Resources.computer;
            navBarItem4.Name = "navBarItem4";
            // 
            // navBarItem5
            // 
            navBarItem5.Caption = "Smartwatch";
            navBarItem5.ImageOptions.SmallImage = Properties.Resources.smartwatch;
            navBarItem5.Name = "navBarItem5";
            // 
            // nbgPersonnels
            // 
            nbgPersonnels.Caption = "Personnel";
            nbgPersonnels.Expanded = true;
            nbgPersonnels.ImageOptions.SmallImage = Properties.Resources.avatar;
            nbgPersonnels.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] { new DevExpress.XtraNavBar.NavBarItemLink(navBarItem6) });
            nbgPersonnels.Name = "nbgPersonnels";
            // 
            // navBarItem6
            // 
            navBarItem6.Caption = "Personnels Info";
            navBarItem6.ImageOptions.SmallImage = Properties.Resources.man;
            navBarItem6.Name = "navBarItem6";
            // 
            // nbgDepartments
            // 
            nbgDepartments.Caption = "Departments";
            nbgDepartments.Expanded = true;
            nbgDepartments.ImageOptions.LargeImage = (Image)resources.GetObject("nbgDepartments.ImageOptions.LargeImage");
            nbgDepartments.ImageOptions.SmallImage = Properties.Resources.department;
            nbgDepartments.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] { new DevExpress.XtraNavBar.NavBarItemLink(navBarItem7), new DevExpress.XtraNavBar.NavBarItemLink(navBarItem8), new DevExpress.XtraNavBar.NavBarItemLink(navBarItem9), new DevExpress.XtraNavBar.NavBarItemLink(navBarItem10), new DevExpress.XtraNavBar.NavBarItemLink(navBarItem11) });
            nbgDepartments.Name = "nbgDepartments";
            // 
            // navBarItem7
            // 
            navBarItem7.Caption = "Human Resources";
            navBarItem7.ImageOptions.SmallImage = Properties.Resources.hr_manager;
            navBarItem7.Name = "navBarItem7";
            // 
            // navBarItem8
            // 
            navBarItem8.Caption = "Marketing";
            navBarItem8.ImageOptions.SmallImage = Properties.Resources.social_media;
            navBarItem8.Name = "navBarItem8";
            // 
            // navBarItem9
            // 
            navBarItem9.Caption = "Sales";
            navBarItem9.ImageOptions.SmallImage = Properties.Resources.acquisition;
            navBarItem9.Name = "navBarItem9";
            // 
            // navBarItem10
            // 
            navBarItem10.Caption = "R & D";
            navBarItem10.ImageOptions.SmallImage = Properties.Resources.research_and_development;
            navBarItem10.Name = "navBarItem10";
            // 
            // navBarItem11
            // 
            navBarItem11.Caption = "IT";
            navBarItem11.ImageOptions.SmallImage = Properties.Resources.information_technology;
            navBarItem11.Name = "navBarItem11";
            // 
            // xtraTabControlMain
            // 
            xtraTabControlMain.Appearance.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            xtraTabControlMain.Appearance.Options.UseFont = true;
            xtraTabControlMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            xtraTabControlMain.Dock = DockStyle.Fill;
            xtraTabControlMain.Location = new Point(0, 0);
            xtraTabControlMain.Name = "xtraTabControlMain";
            xtraTabControlMain.Size = new Size(748, 632);
            xtraTabControlMain.TabIndex = 0;
            xtraTabControlMain.CloseButtonClick += xtraTabControlMain_CloseButtonClick;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Add Item";
            barButtonItem1.Id = 2;
            barButtonItem1.ImageOptions.Image = Properties.Resources.add_16x16;
            barButtonItem1.ImageOptions.LargeImage = Properties.Resources.add_32x32;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Delete Item";
            barButtonItem2.Id = 3;
            barButtonItem2.ImageOptions.SvgImage = Properties.Resources.deletedatasource;
            barButtonItem2.Name = "barButtonItem2";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 809);
            Controls.Add(splitContainerControl1);
            Controls.Add(ribbonControl1);
            Controls.Add(ribbonStatusBar1);
            Name = "FrmMain";
            Text = "Technical Service Application";
            WindowState = FormWindowState.Maximized;
            Shown += FrmMain_Shown;
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)navBarControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabControlMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup nbgBasic;
        private DevExpress.XtraNavBar.NavBarItem nbiUsers;
        private DevExpress.XtraNavBar.NavBarItem nbiSettings;
        private DevExpress.XtraNavBar.NavBarGroup nbgMaintenances;
        private DevExpress.XtraNavBar.NavBarGroup nbgDevices;
        private DevExpress.XtraNavBar.NavBarGroup nbgPersonnels;
        private DevExpress.XtraNavBar.NavBarGroup nbgDepartments;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraNavBar.NavBarItem nbiMaintenanceRecords;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private DevExpress.XtraNavBar.NavBarItem navBarItem10;
        private DevExpress.XtraNavBar.NavBarItem navBarItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}
