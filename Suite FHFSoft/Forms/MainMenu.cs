using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Data.SqlClient;
using System.Data;
using Telerik.WinControls.Themes;
using Telerik.WinControls;
using System.Reflection;

namespace Suite_FHFSoft
{
    public partial class MainMenu : Form
    {
        int vClosetype = 0;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            TelerikMetroTheme ThemeTelerikMetroTheme = new TelerikMetroTheme();
            Office2013DarkTheme ThemeOffice2013DarkTheme = new Office2013DarkTheme();
            Office2013LightTheme ThemeOffice2013LightTheme = new Office2013LightTheme();
            //Windows8Theme ThemeWindows8Theme = new Windows8Theme();
            //VisualStudio2012DarkTheme ThemeVisualStudio2012DarkTheme = new VisualStudio2012DarkTheme();
            //VisualStudio2012LightTheme ThemeVisualStudio2012LightTheme = new VisualStudio2012LightTheme();
            //TelerikMetroBlueTheme ThemeTelerikMetroBlueTheme = new TelerikMetroBlueTheme();
            Office2010BlackTheme ThemeOffice2010BlackTheme = new Office2010BlackTheme();
            Office2010BlueTheme ThemeOffice2010BlueTheme = new Office2010BlueTheme();
            Office2010SilverTheme ThemeOffice2010SilverTheme = new Office2010SilverTheme();
            //AquaTheme ThemeAquaTheme = new AquaTheme();
            //BreezeTheme ThemeBreezeTheme = new BreezeTheme();
            //DesertTheme ThemeDesertTheme = new DesertTheme();
            //HighContrastBlackTheme ThemeHighContrastBlackTheme = new HighContrastBlackTheme();
            Office2007BlackTheme ThemeOffice2007BlackTheme = new Office2007BlackTheme();
            Office2007SilverTheme ThemeOffice2007SilverTheme = new Office2007SilverTheme();
            //Windows7Theme ThemeWindows7Theme = new Windows7Theme();

            // SetRibbon();


            ThemeResolutionService.ApplicationThemeName = ThemeOffice2007BlackTheme.ThemeName;

            
        }

        public void setStatus()
        {
            RadLabelElement labelElement = new RadLabelElement();
            labelElement.Text = C.vUserName + "@" + C.vProfileName + "      Sucursal:" + C.vSucursalName;
            RadButtonElement buttonElement = new RadButtonElement();
            buttonElement.Text = "My ButtonElement";
            buttonElement.Visibility = ElementVisibility.Hidden;
            //buttonElement.Click += new EventHandler(buttonElement_Click);
            RadRepeatButtonElement repeatButtonElement = new RadRepeatButtonElement();
            repeatButtonElement.Text = "My Repeat button";
            repeatButtonElement.Visibility = ElementVisibility.Hidden;
            // repeatButtonElement.Click += new EventHandler(repeatButtonElement_Click);
            CommandBarSeparator separator = new CommandBarSeparator();
            RadProgressBarElement progressBarElement = new RadProgressBarElement();
            progressBarElement.Text = "My Progress Bar";
            progressBarElement.Visibility = ElementVisibility.Hidden;
            radStatusStrip1.Items.AddRange(new RadItem[] { labelElement, buttonElement, repeatButtonElement, separator, progressBarElement });
        }
        public void SetRibbon(DataTable Datos )
        {
            int item1 = -1;
            int item2 = -1;
            int item3 = -1;

            RibbonTab[] tabItem = new RibbonTab[20];
            RadRibbonBarGroup[] radRibbonBarGroup = new RadRibbonBarGroup[40];
            RadButtonElement[] radButtonElement = new RadButtonElement[50];

            radRibbonBar1.ImageList = imageList1;
            

            foreach (DataRow vRow in Datos.Rows)
            {
                if(vRow["ItemOrder2"].ToString()=="0")
                {
                    item1++;
                    tabItem[item1] = new RibbonTab();
                    tabItem[item1].Text = vRow["Descripcion"].ToString();
                    radRibbonBar1.CommandTabs.Add(tabItem[item1]);
                }
                else if(vRow["ItemOrder3"].ToString() == "0")
                {
                    item2++;
                    radRibbonBarGroup[item2] = new RadRibbonBarGroup();
                    radRibbonBarGroup[item2].Text = vRow["Descripcion"].ToString();
                    radRibbonBarGroup[item2].MinSize = new Size(300, 300);
                    ((RibbonTab)radRibbonBar1.CommandTabs[item1]).Items.Add(radRibbonBarGroup[item2]);
                }
                else
                {
                    item3++;
                    radButtonElement[item3] = new RadButtonElement();
                    radButtonElement[item3].Text = vRow["Descripcion"].ToString();
                    radButtonElement[item3].TextAlignment = ContentAlignment.BottomCenter;
                    radButtonElement[item3].TextWrap = true;
                    radButtonElement[item3].Tag = ((string)vRow["FormName"]);
                    radButtonElement[item3].ImageIndex = ((int)vRow["ImageID"]);
                    radButtonElement[item3].ImageAlignment = ContentAlignment.MiddleCenter;
                    radButtonElement[item3].Size = new Size(100, 80);
                    radButtonElement[item3].AutoSize = false;
                    radButtonElement[item3].Click += ClickRibbonbar;
                    radRibbonBarGroup[item2].Items.Add(radButtonElement[item3]);
                }
            }

            return;


            tabItem[0] = new RibbonTab();
            tabItem[0].Text = "Manage";
            radRibbonBar1.CommandTabs.Add(tabItem[0]);
           
           
           

            radRibbonBarGroup[0] = new RadRibbonBarGroup();
            radRibbonBarGroup[0].Text = "Options";
            radRibbonBarGroup[0].AutoSize = false;
            //radRibbonBarGroup[0].AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            ((RibbonTab)radRibbonBar1.CommandTabs[0]).Items.Add(radRibbonBarGroup[0]);

            tabItem[1] = new RibbonTab();
            tabItem[1].Text = "Manage2";
            radRibbonBar1.CommandTabs.Add(tabItem[1]);

            radRibbonBarGroup[1] = new RadRibbonBarGroup();
            radRibbonBarGroup[1].Text = "Options";
            ((RibbonTab)radRibbonBar1.CommandTabs[1]).Items.Add(radRibbonBarGroup[1]);

           
           
            radButtonElement[1] = new RadButtonElement();
            radButtonElement[2] = new RadButtonElement();
            radButtonElement[1].Text = "texto1";
            radButtonElement[2].Text = "Configuraciones";
            radButtonElement[2].TextAlignment = ContentAlignment.BottomCenter;
            radButtonElement[2].TextWrap = true;
            radButtonElement[2].ImageIndex = 0;
            radButtonElement[2].ImageAlignment = ContentAlignment.MiddleCenter;
            radButtonElement[2].Click += ClickRibbonbar;
            //radButtonElement[2]

            radButtonElement[2].AutoSize = false;
            radButtonElement[1].AutoSize = false;
            radButtonElement[2].Size = new Size(128, 64);
            radButtonElement[1].Size = new Size(128, 64);
            //  radRibbonBarGroup[1].Items.Add(radButtonElement[1]);

            RadRibbonBarButtonGroup radRibbonBarButtonGroup1 = new RadRibbonBarButtonGroup();
            radRibbonBarButtonGroup1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            radRibbonBarButtonGroup1.MinSize = new System.Drawing.Size(400, 400);
           
            radRibbonBarButtonGroup1.ShowBorder = true;


            radRibbonBarButtonGroup1.Items.AddRange(new RadItem[] { radButtonElement[1], radButtonElement[2] });
            radRibbonBarGroup[1].Items.Add(radRibbonBarButtonGroup1);

        }

        private void  ClickRibbonbar(object sender, EventArgs e)
        {
            C.OpenForm(((RadButtonElement)sender).Tag.ToString());
        }

   
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (vClosetype == 0)
            {
                Application.Exit();
            }
        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void vCerrarSesion_Click(object sender, EventArgs e)
        {
            //


            Assembly asm = Assembly.GetEntryAssembly();
            Type formtype = asm.GetType("Suite_FHFSoft.Login");
            Form form = (Form)Activator.CreateInstance(formtype);

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == form.GetType())
                {
                    frm.Show();
                    frm.BringToFront();
                    vClosetype = 1;
                    this.Close();
                    return;
                }
            }

        }
    }
}
