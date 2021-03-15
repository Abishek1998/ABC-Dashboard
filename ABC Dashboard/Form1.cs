using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Dashboard
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
            CustomDesign();
        }

        private void CustomDesign()
        {
            panelWorkingDaysHours.Visible = false;
            panelLecturers.Visible = false;
            panelSubjects.Visible = false;
            panelStudents.Visible = false;
            panelTags.Visible = false;
            panelLocation.Visible = false;
            panelSession.Visible = false;
        }
        
        private void HideSubMenu()
        {
            if (panelWorkingDaysHours.Visible == true)
                panelWorkingDaysHours.Visible = false;

            if (panelLecturers.Visible == true)
                panelLecturers.Visible = false;

            if (panelSubjects.Visible == true)
                panelSubjects.Visible = false;

            if (panelStudents.Visible == true)
                panelStudents.Visible = false;

            if (panelTags.Visible == true)
                panelTags.Visible = false;

            if (panelLocation.Visible == true)
                panelLocation.Visible = false;

            if (panelSession.Visible == true)
                panelSession.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void BtnWorkingDaysHours_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelWorkingDaysHours);
        }

        private void BtnAddWorkingDaysHours_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void BtnManageWorkingDaysHours_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void BtnLecturers_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelLecturers);
        }

        private void BtnAddLecturers_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void BtnManageLecturers_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void BtnSubjects_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubjects);
        }

        private void BtnAddSubjects_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void BtnManageSubjects_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelStudents);
        }

        private void BtnAddStudents_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void BtnManageStudents_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void BtnTags_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelTags);
        }

        private void BtnAddTags_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void BtnManageTags_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void BtnLocation_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelLocation);
        }

        private void BtnAddLocation_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void BtnManageLocation_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
    }
}
